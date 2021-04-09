using AutoMapper;
using AutoMapper01.Models;
using AutoMapper01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapper01
{
    public class DefaultController : Controller
    {
        // GET: Default
        private readonly IMapper _mapper;

        public DefaultController()
        {

        }
        public DefaultController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var user = GetDetails();
            var userViewModel = user;
            ////var userViewModel1 = _mapper.Map<UserViewModel>(user);
            Mapper.CreateMap<User, UserViewModel>()
            .ForMember(dest => dest.FullName,
            opt => opt.MapFrom(src => src.GetFullName))
            .ForMember(dest => dest.AddressCountry,
            opt => opt.MapFrom(src => src.Addresss))
            .ForMember(dest => dest.LastName,
            opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.Email,
            opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Id,
            opt => opt.MapFrom(src => src.Id));

            var mappedUser = Mapper.Map<UserViewModel>(user);

            return View(userViewModel);
        }

        private static User GetDetails()
        {
           return  new User
            {
                Id = 1,
                FirstName="John",
                LastName="Ram",
                Email="a@abc.com",
                Addresss=new Address()
                {
                    Country="USA"
                }
            };
        }
    }
}