using System.ComponentModel.DataAnnotations;
using ValidationTurtorial.Interfaces;
using ValidationTurtorial.Models;

namespace ValidationTurtorial.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SchoolLevelValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult("Object is null");
            User user = (User)value;  

            IUserService userService = (IUserService) validationContext.GetService(typeof(IUserService))!;
            if (userService == null) throw new Exception("IUserService not registered");

            return userService.SchoolLevelCorrespondsWithAge(user) ? ValidationResult.Success :  new ValidationResult("Age doesn't match School Level", new List<string>() { nameof(user.SchoolLevel) });
        }
    }
}
