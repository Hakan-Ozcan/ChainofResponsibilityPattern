using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainofResponsibilityPattern.Entities;

namespace ChainofResponsibilityPattern.Handlers
{
    public class CustomerServiceHandler : IComplaintHandler
    {
        private IComplaintHandler ?nextHandler;

        public void SetNextHandler(IComplaintHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleComplaint(Complaint complaint)
        {
            if (complaint.Title.Contains("Customer Service"))
            {
                Console.WriteLine($"Complaint handled by Customer Service: {complaint.Title}");
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
