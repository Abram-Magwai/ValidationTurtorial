using ValidationTurtorial.Models;

namespace ValidationTurtorial.Interfaces
{
    public interface IUserService
    {
        public bool AddUser(User user);
        public bool SchoolLevelCorrespondsWithAge(User user);
    }
}
