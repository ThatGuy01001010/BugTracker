using AutoMapper;
using BugTracker.Domain.Models;
using BugTracker.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMaps() {
            Mapper.CreateMap<Bug, BugDTO>();
            Mapper.CreateMap<Bug, BugDTO>();
            Mapper.CreateMap<BugDTO, Bug>();
        }
    }
}