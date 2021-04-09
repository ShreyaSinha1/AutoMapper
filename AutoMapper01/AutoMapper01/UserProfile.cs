using AutoMapper;
using AutoMapper01.Models;
using AutoMapper01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper01
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
                //.ForMember(dest => dest.FullName,
                //opt => opt.MapFrom(src => src.GetFullName))
                //.ForMember(dest => dest.AddressCountry,
                //opt => opt.MapFrom(src => src.Addresss))
                //.ForMember(dest => dest.LastName,
                //opt => opt.MapFrom(src => src.LastName))
                //.ForMember(dest => dest.Email,
                //opt => opt.MapFrom(src => src.Email))
                //.ForMember(dest => dest.Id,
                //opt => opt.MapFrom(src => src.Id));
        }

        protected override void Configure()
        {
            throw new NotImplementedException();
        }
    }
}