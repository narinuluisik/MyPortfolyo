using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo.Dal.Entities
{
    public class DashboardMetric
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Unit { get; set; } 
        public int Value { get; set; }
    }

}
