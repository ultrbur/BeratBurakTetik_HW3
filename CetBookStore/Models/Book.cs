using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength =3, ErrorMessage ="3 ile 50 karakter arası giriş yapınız.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable

        [Range(1, 999999, ErrorMessage = "1 ile 999999 arası giriş yapınız.")]
        [Display(Name = "Sayfa Sayısı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int? PageCount { get; set; }

        [StringLength(100, MinimumLength = 3,ErrorMessage = "3 ile 100 karakter arası giriş yapınız.")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }
        
        [StringLength(500, MinimumLength = 3,ErrorMessage ="3 ile 500 karakter arası giriş yapınız.")]
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }
        
        [Range(0, 9999999999999999.99,ErrorMessage = "0 ile 9999999999999999.99 arasında bir fiyat giriniz.")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [Display(Name = "Fiyat")]
        public Decimal Price { get; set; }

        [Range(1500, 2500, ErrorMessage = "1500 ile 2500 arası giriş yapınız.")]
        [Display(Name = "Basım yılı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int? PressYear { get; set; }
        
        [Range(0, 9999999999, ErrorMessage = "0 ile  9999999999 arası giriş yapınız.")]
        [Display(Name = "Stok sayısı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int? StockCount { get; set; }


        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public  Category Category { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          
        }

    }
}
