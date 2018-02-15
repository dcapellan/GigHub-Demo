using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GigHub.Controllers.Api;
using GigHub.Dtos;
using GigHub.Models;


namespace GigHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser,UserDto>();
            CreateMap<Gig,UserDto>();
            CreateMap<Notification,NotificationDto>();
         
        }
    }
}