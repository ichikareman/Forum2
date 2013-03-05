using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Forum2.AutoMapperProfiles;

namespace Forum2.App_Start
{
    public class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new ThreadEntityToThreadEntityViewModel());
        }
    }
}