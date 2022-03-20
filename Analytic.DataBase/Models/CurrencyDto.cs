using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
