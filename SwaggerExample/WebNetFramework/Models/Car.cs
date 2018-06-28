namespace WebNetFramework.Models
{
    /// <summary>
    /// Holds wehicle data
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Unique identifier in the system
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// License plate number in format ABC-123
        /// </summary>
        public string PlateNumber { get; set; }
    }
}