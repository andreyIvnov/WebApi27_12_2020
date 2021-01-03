using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi27_12_2020.Model
{
    public class Cat
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Photo { get; set; }
        
        [Range(0,25)]
        public int Age { get; set; }
       
        public Color Color { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Female,
        Male,
        Unknown
    }
    public enum Color
    {
        Black,
        White,
        Red,
        Brown
    }
}
