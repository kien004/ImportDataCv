using ImportDataCv.Server.ModelMails;

namespace ImportDataCv.Server.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(Mailrequest mailrequest);
    }
}
