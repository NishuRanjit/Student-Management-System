using System.ComponentModel.DataAnnotations;
namespace SMS.Application.DTOs
{
    public class StudentCreateDTO
    {
        [Required]
        public string Name { get; set; }
        [Range(16,60)]
        public int Age { get; set; }
        [Required]
        public string Program { get; set; }
        public int Semester { get; set; }
        public int TotalMarks { get; set; }
        public string StudentType { get; set; }
        public decimal? ScholorshipAmount { get; set; }
       
    }
}
