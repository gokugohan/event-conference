using AutoMapper;
using EventConference.Api.ViewModels;
using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Api
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Session, SessionViewModel>()
                //.ForMember(s => s.StartTime, opt => opt.MapFrom(source => source.StartTime.Value.ToString("d", CultureInfo.CurrentCulture)))
                //.ForMember(s => s.EndTime, opt => opt.MapFrom(source => source.StartTime.Value.ToString("d", CultureInfo.CurrentCulture)))
                .ForMember(s => s.Duration, opt => opt.MapFrom(source =>$"{source.Duration.TotalMinutes} minutes"));
            this.CreateMap<SessionByDayModel, SessionByDayViewModel>();
            this.CreateMap<Speaker, SpeakerViewModel>();
            this.CreateMap<Country, CountryViewModel>();
        }
    }
}
