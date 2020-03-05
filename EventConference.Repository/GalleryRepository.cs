using EventConference.Contracts;
using EventConference.Entities;
using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventConference.Repository
{
    public class GalleryRepository : RepositoryBase<Gallery>,IGalleryRepository
    {
        public GalleryRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
