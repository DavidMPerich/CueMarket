using AutoMapper;
using CueMarket.API.Models.Domain;
using CueMarket.API.Models.DTO;

namespace CueMarket.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cue, CueDto>().ReverseMap();
            CreateMap<AddCueRequestDto, Cue>().ReverseMap();
            CreateMap<UpdateCueRequestDto, Cue>().ReverseMap();

            CreateMap<WeightBolt, WeightBoltDto>().ReverseMap();
            CreateMap<AddWeightBoltRequestDto, WeightBolt>().ReverseMap();
            CreateMap<UpdateWeightBoltRequestDto, WeightBolt>().ReverseMap();

            CreateMap<Bumper, BumperDto>().ReverseMap();
            CreateMap<AddBumperRequestDto, Bumper>().ReverseMap();
            CreateMap<UpdateBumperRequestDto, Bumper>().ReverseMap();

            CreateMap<ButtSleeve, ButtSleeveDto>().ReverseMap();
            CreateMap<AddButtSleeveRequestDto, ButtSleeve>().ReverseMap();
            CreateMap<UpdateButtSleeveRequestDto, ButtSleeve>().ReverseMap();

            CreateMap<Butt, ButtDto>().ReverseMap();
        }
    }
}
