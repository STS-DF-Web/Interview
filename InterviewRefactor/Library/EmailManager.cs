using System.Net.Mail;

namespace InterviewRefactor.Library
{
    public class EmailManager
    {
        public bool SendEmail()
        {
            SmtpClient client = new SmtpClient("host.server", 25);
            MailMessage message = new MailMessage("Test@Test.com", "to@to.com", "Test subject", "Hello test body");

            client.Send(message);

            return true;
        }
    }
}