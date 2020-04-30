using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        
        [Required(ErrorMessage ="Başlık alanı zorunludur.")]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Başlık 3 ila 30 karakter arasında olmalıdır.")]
        [Display(Name ="Başlık")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş yorum yazılamaz.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Yorum 5 ile 500 karakter arasında olmalıdır.")]
        [Display(Name = "Yorum detayı")]
        public string Detail { get; set; }

        [Display(Name = "Puan")]
        [Range(0,5)]
        public int? Rating { get; set; }
        [Display(Name = "Yorum Tarihi")]
        public DateTime CreatedDate { get; set; }
        
        public int BookId { get; set; }
        
        public Book Book { get; set; }

        public Comment()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
