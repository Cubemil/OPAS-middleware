using AutoMapper;

namespace src.Models
{
    public class ApplicationMappingProfile : Profile
    {
        /// <summary>
        /// Represents the mapping profile for application models.
        /// </summary>
        public ApplicationMappingProfile()
        {
            CreateMap<JsonOffenseRecord, DtoOffenseRecord>()
                .ForMember(dest => dest.HausnummerInt, opt => opt.Ignore())
                .ForMember(dest => dest.HausnummerExtra, opt => opt.Ignore())
                .ForMember(dest => dest.RecordId, opt => opt.Ignore()) // ignore RecordId during mapping
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore()); // ignore RowVersion during initial mapping
        }
    }
}