using System.Security.Cryptography.X509Certificates;
using ValidationTurtorial.Interfaces;
using ValidationTurtorial.Models;

namespace ValidationTurtorial.Services
{
    public class UserService : IUserService
    {
        public bool AddUser(User user) => true;

        public bool SchoolLevelCorrespondsWithAge(User user)
        {
            int userAge = user.Age;
            string userSchoolLevel = user.SchoolLevel;

            bool correspondsWithPrimary = ( ((userAge >= 6) && (userAge < 12)) && userSchoolLevel.Equals("Primary") );
            bool correspondsWithSecondary = ((userAge >= 12 && userAge < 16) && (userSchoolLevel.Equals("Secondary")) );
            bool correspondsWithHigh = user.Age >= 16 && userSchoolLevel.Equals("High");

            if (correspondsWithPrimary || correspondsWithSecondary || correspondsWithHigh) return true;
            return false;
        }
    }
}
