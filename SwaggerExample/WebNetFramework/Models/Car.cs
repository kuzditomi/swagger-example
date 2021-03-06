﻿namespace WebNetFramework.Models
{
    /// <summary>
    /// Holds wehicle data
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Unique identifier in the system
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// License plate number in format ABC-123
        /// </summary>
        /// <example>ABC-123</example>
        public string PlateNumber { get; set; }

        /// <summary>
        /// Color of car
        /// </summary>
        /// <example>Red</example>
        public CarColor Color { get; set; }
    }
}