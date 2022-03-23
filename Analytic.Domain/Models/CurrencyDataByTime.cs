using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytic.Domain.Models
{
    public class CurrencyDataByTime
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        private DateTime _dateTime;
        public DateTime Date 
        { 
            get => _dateTime.Date; 
            set => _dateTime = value.Date +  _dateTime.TimeOfDay; 
        }

        public TimeSpan Time 
        { 
            get => _dateTime.TimeOfDay; 
            set => _dateTime = _dateTime.Date + value; 
        }

        public CurrencyDataByTime(DateTime dateTime)
        {
            this._dateTime = dateTime;
        }
    }
}
