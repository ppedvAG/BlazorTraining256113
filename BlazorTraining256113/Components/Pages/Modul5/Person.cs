using System.ComponentModel.DataAnnotations;

namespace BlazorTraining256113.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, MinimumLength =2, ErrorMessage = "Name cannot be longer than 10 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Größe is required")]
        [Range(100, 300, ErrorMessage = "Größe must be between 100 and 300")]
        public  int Gross { get; set; }
        [Required(ErrorMessage = "GebDat is required")]
        public DateTime GebDat { get; set; }
    }
}
