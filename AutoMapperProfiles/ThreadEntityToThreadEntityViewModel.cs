using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DomainObjects;
using Forum2.ViewModel;

namespace Forum2.AutoMapperProfiles
{
    public class ThreadEntityToThreadEntityViewModel : Profile
    {
        public ThreadEntityToThreadEntityViewModel()
        {
            Mapper.CreateMap<ThreadEntity, ThreadViewModels>();
        }
    }
}