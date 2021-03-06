﻿using System.ComponentModel.DataAnnotations;

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
        /// <example>AAA-111</example>
        [Required]
        [RegularExpression("[A-Z]{3}-[0-9]{3}", ErrorMessage = "Plate number must be in format ABC-123")]
        public string PlateNumber { get; set; }

        /// <summary>
        /// Color of car
        /// </summary>
        /// <example>Blue</example>
        [Required]
        public CarColor Color { get; set; }
    }
}