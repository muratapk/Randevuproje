using System.ComponentModel.DataAnnotations;

namespace denemproje.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Adı Soyadı:")]
        [Required(ErrorMessage ="Boş Bırakamazsınız")]
        public string AdiSoyadi { get; set; } = string.Empty;
        [Display(Name ="Cep Telefonu Girin:")]
        [Required(ErrorMessage ="Cep Telefonunu Girin")]
        public string CepNo { get; set; }= string.Empty;
        [Display(Name = "Tarih Bilgisi Girin:")]
        [Required(ErrorMessage = "Tarih Boş Geçilemez Girin")]
        public DateTime? RandevuSaati { get; set; }
        [Display(Name = "Yapılan İşlem Girin:")]
        [Required(ErrorMessage = "Yapılan İşlem Boş Geçilemez Girin")]
        public string YapilanIslem { get; set; } = string.Empty;
    }
}
