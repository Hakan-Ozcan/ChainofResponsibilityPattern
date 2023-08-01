using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern.Entities
{
    public class Complaint
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Complaint(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
