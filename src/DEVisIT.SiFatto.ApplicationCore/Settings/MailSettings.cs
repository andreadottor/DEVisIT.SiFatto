namespace DEVisIT.SiFatto.ApplicationCore.Settings
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MailSettings
    {
        [Required]
        public string Host { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Port { get; set; }
    }
}
