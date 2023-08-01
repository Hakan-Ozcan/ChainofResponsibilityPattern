using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainofResponsibilityPattern.Entities;

namespace ChainofResponsibilityPattern.Handlers
{
    public class TechnicalSupportHandler : IComplaintHandler
    {
        private IComplaintHandler ?nextHandler;

        public void SetNextHandler(IComplaintHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleComplaint(Complaint complaint)
        {
            if (complaint.Title.Contains("Technical Support"))
            {
                Console.WriteLine($"Complaint handled by Technical Support: {complaint.Title}");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleComplaint(complaint);
            }
            else
            {
                Console.WriteLine("No handler found for the complaint.");
            }
        }
    }
}
