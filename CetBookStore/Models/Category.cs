﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(100,MinimumLength =3, ErrorMessage = "Kategori isim alanı 3 ile 100 karakter arasında olmalıdır")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [Display(Name="İsim")]
        public string Name { get; set; } 

        public virtual List<Book> Books { get; set; }
    }
}
