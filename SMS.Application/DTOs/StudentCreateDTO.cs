namespace SMS.Application.DTOs
{
    public class StudentCreateDTO
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }
        public int Semester { get; set; }
        public int TotalMarks { get; set; }
        public string StudentType { get; set; }
        public decimal? ScholorshipAmount { get; set; }
       
    }
}
