using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventConference.Web.Models
{
    public class FaqViewModel
    {
        public Guid FaqId { get; set; } = Guid.NewGuid();
        public string Answer { get; set; }
        public string Question { get; set; }
    }
}
