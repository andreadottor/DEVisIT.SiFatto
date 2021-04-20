namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMailService
    {

        void SendMail(string to, string subject, string text);
    }
}
