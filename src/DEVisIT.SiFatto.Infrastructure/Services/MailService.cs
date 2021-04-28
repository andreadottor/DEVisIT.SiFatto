namespace DEVisIT.SiFatto.Infrastructure.Services
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using DEVisIT.SiFatto.ApplicationCore.Settings;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;

        public MailService(MailSettings mailSettings)
        {
            _mailSettings = mailSettings;
        }

        public void SendMail(string to, string subject, string text)
        {
            var smtp = _mailSettings.Host;

            throw new NotImplementedException();
        }
    }
}
