using System.ComponentModel.DataAnnotations;

namespace denemproje.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Boş Bırakamazsınız")]
        public string UserName { get; set; }=string.Empty;
        [Required(ErrorMessage = "Boş Bırakamazsınız")]
        public string PassWord { get; set; } = string.Empty;
    }
}
