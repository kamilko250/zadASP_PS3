using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS3.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Liczba od 1 do 1000")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbe z zakresu 1 - 1000.")]
        [Required(ErrorMessage = "Podaj liczbe")]
        public int? Number { get; set; }

        public string FizzBuzzing() 
        {
            string result = "";
            if (Number % 3 == 0)
                result += "Fizz";

            if (Number % 5 == 0)
                result += "Buzz";

            return result == string.Empty ? Number.ToString() : result;
        }


    }
}
