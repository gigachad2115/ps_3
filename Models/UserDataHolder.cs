using System.ComponentModel.DataAnnotations;



namespace PS3.Models
{
    public class UserDataHolder
    {   
        [Required]
        [Range(1899,2022,ErrorMessage = "zakres lat 1899-2022")]
            public int? year { get; set; }

        [Required]
        [StringLength(maximumLength:100, ErrorMessage = "imie może mieć maks. 100 znaków")]
        public string? name { get; set; }
        public string checkYear()
        {
            if (this.year == null)
            {
                return "";
            }
            if (this.year % 100 != 0 && this.year % 4 == 0 || this.year%400==0)
            {
                return "rok przestępny";
            }
            return "rok nieprzestępny";
        }
    }
}
