﻿using EntityService.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityService.Model
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = "";
        public string? Icon { get; set; } = "";
        public Guid? IdImage { get; set; }
        public Guid? IdFatherCategory { get; set; }

        public Image? Image { get; set; }
        public Category? FatherCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> SonCategories { get; set; }
    }
}
