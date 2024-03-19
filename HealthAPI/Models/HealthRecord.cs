namespace HealthAPI.Models
{
    public class HealthRecord
    {
        public int Id{get;set;}
        public string PatientName{get;set;}
        public string RecordDetails{get;set;}
        public DateTime Date{get;set;}
    }
}