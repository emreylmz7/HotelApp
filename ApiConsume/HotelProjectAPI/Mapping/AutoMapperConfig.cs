using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.DtoLayer.Dtos.RoomDto;

namespace HotelProjectAPI.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto,Room>();
            CreateMap<Room,RoomAddDto>();

            //Bu ikisi aynı alttaki kolay işlem

            CreateMap<Room,RoomUpdateDto>().ReverseMap();


           
        }
        
    }
}