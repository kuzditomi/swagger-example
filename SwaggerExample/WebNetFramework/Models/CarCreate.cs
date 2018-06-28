using System.ComponentModel.DataAnnotations;

namespace WebNetFramework.Models
{
    /// <summary>
    /// Used in car creation request
    /// </summary>
    public class CarCreate
    {
        /// <summary>
        /// License plate number in format ABC-123
        /// </summary>
        /// <example>ABC-123</example>
        [Required]
        [RegularExpression("[A-Z]{3}-[0-9]{3}", ErrorMessage = "Plate number must be in format ABC-123")]
        public string PlateNumber { get; set; }
    }
}