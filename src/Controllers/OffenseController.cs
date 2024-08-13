using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseController(OffenseDbContext context, IMapper mapper) : ControllerBase
    {
        private readonly OffenseDbContext _context = context;
        private readonly IMapper _mapper = mapper;

        /// <summary>
        /// Call: 'POST /api/Offense'
        /// -> Posts a new record to the database.
        /// </summary>
        /// <param name="record">The record to be added to the database.</param>
        /// <returns> 
        /// <see cref="IActionResult"/> interface defines a contract that represents the result of an action method.
        /// This interface is implemented by <see cref="BadRequestObjectResult"/> and <see cref="OkObjectResult"/>.
        /// and is used to return an HTTP status code and a value (string, object, etc.).
        /// The value is serialized into the response body.
        /// In this case, the method returns a BadRequestObjectResult if the record is null or if the server side validation fails.
        /// Otherwise, the method maps the JsonOffenseRecord to a DtoOffenseRecord, splits the Hausnummer into digits/extra part,
        /// adds the new record to the database context, saves the changes, retrieves the saved record from the database, and returns it.
        /// If the saved record is null, the method returns a StatusCode 500 with an error message.
        /// </returns>
        [HttpPost]
        public IActionResult Post([FromBody] JsonOffenseRecord record)
        {
            if (record == null)
                return BadRequest(new { message = "Invalide Daten." });

            // server side validation
            var validationResults = JsonOffenseRecord.ValidateRecord(record);
            if (validationResults.Count != 0)
                return BadRequest(new { message = "Validation fehlgeschlagen.", errors = validationResults });

            // map JsonOffenseRecord to DtoOffenseRecord
            var dtoRecord = _mapper.Map<DtoOffenseRecord>(record);

            // split Hausnummer into digits/extra part
            dtoRecord.SplitHausnummer();

            // add new record to db context
            _context.OffenseRecords.Add(dtoRecord);
            _context.SaveChanges();

            // get saved record to ensure RecordId is included
            var savedRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == dtoRecord.RecordId);

            // no empty record is allowed
            if (savedRecord == null)
                return StatusCode(500, new { message = "Fehler beim Speichern der Ordnungswidrigkeit." });

            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich eingetragen.", data = savedRecord });
        }

        /// <summary>
        /// Call: 'GET /api/Offense' 
        /// -> Retrieves all records from the database
        /// </summary>
        /// <returns>
        /// <see cref="IActionResult"/> Representing every record in database
        /// The method returns a list of all records in the database, their RecordIds, and a message indicating success.
        /// </returns>
        [HttpGet]
        public IActionResult Get()
        {
            var records = _context.OffenseRecords.ToList();
            var ids = records.Select(r => r.RecordId);
            return Ok(new { message = "Ordnungswidrigkeiten erfolgreich übertragen.", data = records, ids });
        }

        /// <summary>
        /// Call: 'GET /api/Offense/{id}'
        /// -> Retrieves a single record from the database by RecordId
        /// </summary>
        /// <param name="id"> The RecordId of the record to be retrieved. </param>
        /// <returns>
        /// The method returns a single record from the database by RecordId, represented as <see cref="IActionResult"/> , if it exists.
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);
            if (record == null)
                return NotFound(new { message = "Ordnungswidrigkeit nicht gefunden." });

            return Ok(new { message = "Ordnungswidrigkeit erfolgreich übertragen.", data = record });
        }

        /// <summary>
        /// Call: 'PUT /api/Offense/{id}'
        /// -> Updates a single record in the database by RecordId
        /// </summary>
        /// <remarks>
        /// The method updates a single record in the database by RecordId.
        /// </remarks>
        /// <param name="id"> The RecordId of the record to be updated. </param>
        /// <param name="updatedRecord"> The updated record to be saved to the database. </param>
        /// <returns>
        /// If record does not exist -> returns NotFoundObjectResult.
        /// If RowVersion of existing record does not match RowVersion of updated record -> returns ConflictObjectResult.
        /// Otherwise, updates existing record with values from updated record, increments RowVersion, saves changes and returns updated record.
        /// If the changes cannot be saved -> returns ConflictObjectResult.
        /// </returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] JsonOffenseRecord updatedRecord)
        {
            if (updatedRecord == null)
                return BadRequest(new { message = "Invalide Daten. Ordnungswidrigkeit ist leer." });

            // server side validation
            var validationResults = JsonOffenseRecord.ValidateRecord(updatedRecord);
            if (validationResults.Count != 0)
                return BadRequest(new { message = "Validation fehlgeschlagen.", errors = validationResults });

            var existingRecord = _context.OffenseRecords.FirstOrDefault(r => r.RecordId == id);
            if (existingRecord == null)
                return NotFound(new { message = "Ordnungswidrigkeit nicht gefunden." });

            if (existingRecord.RowVersion != updatedRecord.RowVersion)
                return Conflict(new { message = "Speichern fehlgeschlagen. Die Ordnungswidrigkeit wurde von einem anderen Nutzer bereits gespeichert." });

            // update existing record with new values (+ increment RowVersion)
            existingRecord.UpdateRecord(updatedRecord);

            // Save changes to db
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict(new { message = "Die Ordnungswidrigkeit wurde von einem anderen Nutzer überarbeitet." });
            }

            return Ok(new { message = "Ordnungswidrigkeit erfolgreich aktualisiert.", data = existingRecord });
        }
    }
}
