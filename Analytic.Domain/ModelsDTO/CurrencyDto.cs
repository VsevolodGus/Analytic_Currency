using System;
using System.ComponentModel.DataAnnotations;

namespace Analytic.DataBase.Models
{
    public class CurrencyDto
    {
        [Key]
        public Guid CurrencyId { get; init; }
       
        public string NumberCode { get; init; }
        
        public string TitleCurrnecy { get; init; }
    }
}
