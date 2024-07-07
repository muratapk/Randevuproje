using System.ComponentModel.DataAnnotations;

namespace denemproje.Models
{
    public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        public String  KategoriAd { get; set; }
    }
}
