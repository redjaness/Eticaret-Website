﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "Açıklaması")]
        public string? Description { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }

        [Display(Name = "Üst Menüde Göster")]
        public bool IsTopMenu { get; set; }

        [Display(Name = "Üst Kategori")]
        public int ParentId { get; set; }

        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateData { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }

    }
}
