using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            //ABOUT
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            //BOOKING
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<BookingCreateDto, Booking>().ReverseMap();
            CreateMap<BookingResultDto, Booking>().ReverseMap();

            //CONTACT
            CreateMap<ContactCreateDto, Contact>().ReverseMap();

            //GUEST
            CreateMap<AddGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            //USER
            CreateMap<UserCreateDto, AppUser>().ReverseMap();
            CreateMap<UserLoginDto, AppUser>().ReverseMap();

            //ROOM
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            //SERVICE
            CreateMap<ServiceResultDto, Service>().ReverseMap();
            CreateMap<ServiceCreateDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();

            //STAFF
            CreateMap<StaffResultDto, Staff>().ReverseMap();

            //SUBSCRIBE
            CreateMap<SubscribeCreateDto, Subscribe>().ReverseMap();

            //TESTIMONIAL
            CreateMap<TestimonialResultDto, Testimonial>().ReverseMap();

        }
    }
}