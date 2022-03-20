using Analytic.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Analytic.DataBase
{
    public class DbContextAnalytic :  DbContext
    {
        public DbSet<CurrencyDto> Currencies { get; }

        public DbSet<CurrencyDataDto> CurrencyDatas { get; }


    }
}
