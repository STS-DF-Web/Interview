using System;
using System.Linq;
using InterviewRefactor.Models;

namespace InterviewRefactor.Library
{
    public class MemberManager
    {        
        public string CreateSpecialMember(string reversedName)
        {
            string result = String.Empty;

            MemberModel member = new MemberModel();

            if (member != null)
            {
                member.FirstName = "Test";
            }
            else if (member == null)
            {
                member = new MemberModel();
            }

            if (reversedName == null)
            {
                member.ReversedFullName = member.FirstName.Reverse().ToString();    
            }
            else if (reversedName.Length > 20)
            {
                member.ReversedFullName = member.FirstName.Reverse().ToString();
                member.ReversedFullName = member.ReversedFullName.Substring(0, 20);
            }
            else if (reversedName.Length < 20 && reversedName.Length > 10)
            {
                member.ReversedFullName = member.FirstName.Reverse().ToString();
                member.ReversedFullName = member.ReversedFullName.Substring(10, 10);
            }
            else
            {
                throw new Exception("Scenario not valid.");
            }
            

            int age = member.Age;
            bool isOldEnough;
            if (age > 18)
            {
                isOldEnough = true;
            }
            else
            {
                isOldEnough = false;
            }

            result = isOldEnough ? "Yes" : "No";

            member.MiddleName = "MiddleTest";
            member.LastName = "LastTest";

            if (member.LastName.Length > 0)
            {
                member.HasLastName = true;
            }

            while (age < 35)
            {
                
                age++;
            }

            return result;
        }

        public MemberModel CompareMemberAddress(string userType)
        {
            MemberModel member = new MemberModel();
            switch (userType)
            {
                case "FirstUser":
                    member.FirstName = "Test";
                    member.LastName = "User";
                    member.MiddleName = "Francis";
                    break;

                case "SecondUser":
                    member.FirstName = "Billy";
                    member.LastName = "Maginus";
                    member.MiddleName = "Grapes";
                    break;

                case "ThirdUser":
                    member.FirstName = "Dave";
                    member.LastName = "Toranga";
                    member.MiddleName = "Leala";
                    break;

                default:
                    break;
            }

            if (userType == "FirstUser")
            {
                member.FirstName = "Tester";
            }

            return member;
        }

        public bool ValidateMember()
        {
            bool hasGoodData = false;
            MemberModel member = new MemberBuilder().GetCurrentMember();

            if (member.FirstName == "Billy")
            {
                member.LastName = "Fry";
            }

            if (member.FirstName == null)
            {
                hasGoodData = false;

                if (member.LastName == null)
                {
                    hasGoodData = false;

                    if (member.MiddleName == null)
                    {
                        hasGoodData = true;
                    }
                }
            }

            return hasGoodData;
        }
    }
}