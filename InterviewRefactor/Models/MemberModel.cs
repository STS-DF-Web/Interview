
namespace InterviewRefactor.Models
{
    public class MemberModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ReversedFullName { get; set; }
        public int Age { get; set; }
        public bool HasLastName { get; set; }
    }

    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FormattedAddress {
            get { return Street + ","+ City +","+ State; }
        }
    }
}