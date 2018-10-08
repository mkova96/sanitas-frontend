﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DrugData.Models
{
    public class Medication
    {
        [Key]
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public Package Package { get; set; }
        public DateTime DateProduced { get; set; }
        public DateTime DateExpires {get; set; }
        public string ImagePath { get; set; }

        public String Usage { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Currency Currency { get; set; }
        public virtual ICollection<DrugDisease> DrugDiseases { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<DrugSideEffect> DrugSideEffects { get; set; }
        public virtual ICollection<Medication> Substitutions { get; set; }
        public virtual ICollection<DrugCart> DrugCarts { get; set; }

    }
}
