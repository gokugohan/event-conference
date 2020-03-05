using EventConference.Contracts;
using EventConference.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private readonly RepositoryContext context;

        private IFaqRepository faqRepository;
        private IGalleryRepository galleryRepository;
        //private IScheduleRepository scheduleRepository;
        private ISettingRepository settingRepository;
        private ISponsorRepository sponsorRepository;
        private ISpeakerRepository speakerRepository;
        private IVenueRepository venueRepository;

        private ISessionRepository sessionRepository;
        private IParticipantRepository participantRepository;
        private ICountryRepository countryRepository;

        private IVolunteerRepository volunteerRepository;
        private IEventRepository eventRepository;



        public RepositoryWrapper(RepositoryContext context)
        {
            this.context = context;
        }
        public void Save()
        {
            this.context.SaveChanges();
        }



        public IFaqRepository Faq {
            get {
                if (this.faqRepository == null)
                {
                    this.faqRepository = new FaqRepository(this.context);
                }

                return this.faqRepository;
            }
        }

        public IGalleryRepository Gallery {
            get
            {
                if (null == this.galleryRepository)
                {
                    this.galleryRepository = new GalleryRepository(this.context);
                }
                return this.galleryRepository;
            }
        }

        public ISessionRepository Session
        {
            get
            {
                if (null == this.sessionRepository)
                {
                    this.sessionRepository = new SessionRepository(this.context);
                }
                return this.sessionRepository;
            }
        }


        public ISettingRepository Setting
        {
            get
            {
                if (null == this.settingRepository)
                {
                    this.settingRepository = new SettingRepository(this.context);
                }

                return this.settingRepository;
            }
        }

        public ISponsorRepository Sponsor
        {
            get
            {
                if(this.sponsorRepository == null)
                {
                    this.sponsorRepository = new SponsorRepository(this.context);
                }
                return this.sponsorRepository;
            }
        }

        public IVenueRepository Venue
        {
            get
            {
                if(this.venueRepository == null)
                {
                    this.venueRepository = new VenueRepository(this.context);
                }
                return this.venueRepository;
            }
        }

        public ISpeakerRepository Speaker {
            get
            {
                if(null == this.speakerRepository)
                {
                    this.speakerRepository = new SpeakerRepository(this.context);
                }
                return this.speakerRepository;
            }
        }

        public IParticipantRepository Participant
        {
            get
            {
                if(null == this.participantRepository)
                {
                    this.participantRepository = new ParticipantRepository(this.context);
                }
                return this.participantRepository;
            }
        }

        public ICountryRepository Country
        {
            get
            {
                if(null == this.countryRepository)
                {
                    this.countryRepository = new CountryRepository(this.context);
                }
                return this.countryRepository;
            }
        }

        public IVolunteerRepository Volunteer {
            get
            {
                if (null == this.volunteerRepository)
                {
                    this.volunteerRepository = new VolunteerRepository(this.context);
                }
                return this.volunteerRepository;
            }
        }

        public IEventRepository Event {
            get
            {
                if(null== this.eventRepository)
                {
                    this.eventRepository = new EventRepository(this.context);
                }
                return this.eventRepository;
            }
        }
    }
}
