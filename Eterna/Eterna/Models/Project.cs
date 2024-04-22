namespace Eterna.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }

        public Category Category { get; set; }
        public List<ProjectImage> ProjectImages { get; set; }
    }   
}
