using System.ComponentModel.DataAnnotations;

namespace denemproje.Models
{
    public class Renkler
    {
        [Key]
        public int RenkId { get; set; }
        public string RenkAd { get; set; }
    }
}
