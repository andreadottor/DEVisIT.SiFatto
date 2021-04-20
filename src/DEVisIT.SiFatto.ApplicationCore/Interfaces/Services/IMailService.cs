namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Services
{
    public interface IMailService
    {

        void SendMail(string to, string subject, string text);
    }
}
