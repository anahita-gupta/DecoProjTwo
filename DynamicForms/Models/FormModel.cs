using System.ComponentModel.DataAnnotations;

namespace DynamicForms.Models
{
    public class FormModel
    {
        [Required]
        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Gender { get; set; }

        public bool AgeMandatory { get; set; }

        public bool GenderMandatory { get; set; }
    }
}
