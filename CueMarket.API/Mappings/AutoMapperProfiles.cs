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

            CreateMap<Wrap, WrapDto>().ReverseMap();
            CreateMap<AddWrapRequestDto, Wrap>().ReverseMap();
            CreateMap<UpdateWrapRequestDto, Wrap>().ReverseMap();

            CreateMap<Forearm, ForearmDto>().ReverseMap();
            CreateMap<AddForearmRequestDto, Forearm>().ReverseMap();
            CreateMap<UpdateForearmRequestDto, Forearm>().ReverseMap();

            CreateMap<Ring, RingDto>().ReverseMap();
            CreateMap<AddRingRequestDto, Ring>().ReverseMap();
            CreateMap<UpdateRingRequestDto, Ring>().ReverseMap();

            CreateMap<Butt, ButtDto>().ReverseMap();
            CreateMap<AddButtRequestDto, Butt>().ReverseMap();
            CreateMap<UpdateButtRequestDto, Butt>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<AddUserRequestDto, User>().ReverseMap();
            CreateMap<UpdateUserRequestDto, User>().ReverseMap();

            CreateMap<Material, MaterialDto>().ReverseMap();
        }
    }
}
