using FlcVilla_API.Data;
using FlcVilla_API.Models.DTO;
using System.ComponentModel.DataAnnotations;

namespace FlcVilla_API.Models.Validation
{
    public class UniqueVillaNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            VillaDTO villaDTO = (VillaDTO)validationContext.ObjectInstance;

            if (VillaStore.villas.FirstOrDefault(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                return new ValidationResult("Villa already Exists!"); ;
            }
            return ValidationResult.Success;
        }
    }
}
