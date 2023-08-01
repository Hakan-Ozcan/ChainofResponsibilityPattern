using ChainofResponsibilityPattern.Entities;
using ChainofResponsibilityPattern.Handlers;

class Program
{
    static void Main(string[] args)
    {
        // İşleyici sınıflarını oluşturuyoruz
        IComplaintHandler customerServiceHandler = new CustomerServiceHandler();
        IComplaintHandler technicalSupportHandler = new TechnicalSupportHandler();
        IComplaintHandler financeHandler = new FinanceHandler();

        // Zinciri oluşturuyoruz: Customer Service -> Technical Support -> Finance
        customerServiceHandler.SetNextHandler(technicalSupportHandler);
        technicalSupportHandler.SetNextHandler(financeHandler);

        // Şikayetleri işlemek için zincirin başına gönderiyoruz
        Complaint complaint1 = new Complaint("Technical Support Issue", "My internet is not working.");
        Complaint complaint2 = new Complaint("Finance Inquiry", "I have a question about my billing.");

        customerServiceHandler.HandleComplaint(complaint1);
        customerServiceHandler.HandleComplaint(complaint2);


    }
}