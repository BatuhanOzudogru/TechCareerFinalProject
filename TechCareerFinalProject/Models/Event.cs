namespace TechCareerFinalProject.Models
{
    public class Event:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string GoogleMapLink { get; set; }
        public decimal TicketPrice { get; set; }
        public string[] Images { get; set; }
        public Category Category { get; set; }

    }
}
