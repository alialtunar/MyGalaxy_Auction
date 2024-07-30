using MailKit.Net.Smtp;
using MimeKit;

namespace MyGalaxy_Auction_Core.MailHelper
{
    public class MailService : IMailService
    {
      
        public void SendMail(string subject, string body, string email)
        {
            try
            {
                var emailToSend = new MimeMessage();
                emailToSend.From.Add(MailboxAddress.Parse("YourGalaxyAuction@gmail.com"));
                emailToSend.To.Add(MailboxAddress.Parse(email));
                emailToSend.Subject = subject;
                emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };


                //send mail

                using var emailClient = new SmtpClient();
                emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("altunarali284@gmail.com", "nmckgddkytdiqjsp");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}