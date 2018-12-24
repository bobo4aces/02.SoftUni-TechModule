namespace LogNoziroh.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Report
    {
        //TODO
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Origin { get; set; }

    }
}
