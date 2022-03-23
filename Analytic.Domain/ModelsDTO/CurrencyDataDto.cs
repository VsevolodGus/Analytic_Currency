using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Analytic.DataBase.Models
{
    public class CurrencyDataDto
    {
        [Key]
        public long PKID { get; init; }

        public long Nominal { get; init; }

        public DateTime DateTime { get; init; }

        public decimal Value { get; init; }

        public virtual CurrencyDto Currency { get; set; }
    }
}
