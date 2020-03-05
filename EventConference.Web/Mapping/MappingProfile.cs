using AutoMapper;
using EventConference.Entities.Models;
using EventConference.Web.Models;
using EventConference.Web.Models.Event;
using EventConference.Web.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Mapping
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            this.CreateMap<Faq, FaqViewModel>().ReverseMap().ForMember(m=>m.CreatedAt,opt=>opt.Ignore());
            
            this.CreateMap<Speaker, SpeakerViewModel>().ReverseMap().ForMember(m => m.CreatedAt, opt => opt.Ignore());
            this.CreateMap<Country, CountryViewModel>().ReverseMap().ForMember(m => m.CreatedAt, opt => opt.Ignore());

            this.CreateMap<Session, SessionViewModel>().ReverseMap().ForMember(m => m.CreatedAt, opt => opt.Ignore());
            this.CreateMap<SessionByDayModel, SessionByDayViewModel>();
            //.ForMember(s => s.StartTime, opt => opt.MapFrom(source => source.StartTime.Value.ToString("d", CultureInfo.CurrentCulture)))
            this.CreateMap<Session, EditSessionViewModel>();
            this.CreateMap<EditSessionViewModel, Session>();
            this.CreateMap<CreateSessionViewModel, Session>();


            this.CreateMap<Event, EventViewModel>();
            this.CreateMap<Event, EditEventViewModel>();
            this.CreateMap<EditEventViewModel, Event>().ForMember(m => m.CreatedAt, opt => opt.Ignore());


            this.CreateMap<Volunteer, VolunteerModelView>();
            this.CreateMap<Sponsor, SponsorViewModel>();


        }

    }
}
