using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Core.MailHelper
{
    public interface IMailService
    {
        public void SendMail(string subject, string body, string email);

    }
}
