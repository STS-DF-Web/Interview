using System.Collections.Generic;
using System.Net.Mail;
using InterviewRefactor.Models;

namespace InterviewRefactor.Library
{
    public interface IMemberBuilder
    {
        MemberModel GetCurrentMember();
        string BuildDefaultMemberAddress();
        bool SendEmail();
    }

    public class MemberBuilder : IMemberBuilder
    {
        public MemberModel GetCurrentMember()
        {
            return new MemberModel(){FirstName = "happy", LastName = "Gilmore", MiddleName = "Bart"};
        }

        public List<MemberModel> GetMembers()
        {
            return new List<MemberModel>(); //GET from DB
        }

        public string BuildDefaultMemberAddress()
        {
            return new AddressModel().FormattedAddress;
        }

        public bool SendEmail()
        {
            SmtpClient client = new SmtpClient("host.server", 25);
            MailMessage message = new MailMessage("Test@Test.com", "to@to.com", "Test subject", "Hello test body");

            client.Send(message);

            return true;
        }
    }
}