using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Contracts
{
    public interface IRepositoryWrapper
    {
        IFaqRepository Faq { get; }
        IGalleryRepository Gallery { get; }
        //IScheduleRepository Schedule { get; }
        ISettingRepository Setting { get; }
        ISponsorRepository Sponsor { get; }

        ISpeakerRepository Speaker { get; }


        IVenueRepository Venue { get; }

        ISessionRepository Session { get; }

        IParticipantRepository Participant { get; }

        ICountryRepository Country { get; }

        IVolunteerRepository Volunteer { get; }

        IEventRepository Event { get; }

        void Save();
    }
}
