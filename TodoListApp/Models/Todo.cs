using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Description require") ]
        public string Description { get; set; }
        [Required (ErrorMessage ="Start date is required")]
        public DateTime startDate { get; set; }
        [Required (ErrorMessage ="Status is required")]
        public string Status { get; set; }
        [Required (ErrorMessage ="End date is required")]
        public DateTime endDate { get; set; }

    }
}
