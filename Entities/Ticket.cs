using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Net;

namespace Ovn2_FlowControl.Entities
{
    internal class Ticket
    {
        public decimal Price { get; private set; }
        public AgeCategory AgeCategory { get; private set; }

        public Ticket(int age) 
        {
            AgeCategory = SetAgeCategory(age);
            Price = GetPrice(AgeCategory);
        }

        private AgeCategory SetAgeCategory(int age)
        {
            return age switch
            {
                < 5 => AgeCategory.Child,
                < 20 => AgeCategory.Youngster,
                < 65 => AgeCategory.Adult,
                < 100 => AgeCategory.Senior,
                _ => AgeCategory.SeniorPlus
            };
        }

        private decimal GetPrice(AgeCategory ageCategory)
        {
            return ageCategory switch
            {
                AgeCategory.Child => 0m,
                AgeCategory.Youngster => 80m,
                AgeCategory.Adult => 120m,
                AgeCategory.Senior => 90m,
                AgeCategory.SeniorPlus => 0m,
                _ => throw new ArgumentOutOfRangeException(nameof(ageCategory), "Invalid age category")
            };
        }

        public override string ToString()
        {
            return $"Biljett {Helpers.GetEnumDisplayName(AgeCategory)}: {Price:C}";
        }
    }

    public enum AgeCategory
    {
        [Display(Name = "Barn")]
        Child,
        [Display(Name = "Ungdom")]
        Youngster,
        [Display(Name = "Vuxen")]
        Adult,
        [Display(Name = "Senior")]
        Senior,
        [Display(Name = "Extra mycket senior")]
        SeniorPlus
    }
}
