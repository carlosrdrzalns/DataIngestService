using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataIngestService.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DataIngestService.DBModels
{
    public class DTDataContext : DbContext
    {
        public DTDataContext(DbContextOptions<DTDataContext> options) : base(options)
        {
        }

        public DbSet<WaterPumpData> WaterPumpData { get; set; }

        public DbSet<WaterPumpStatusPredictions> WaterPumpStatusPredictions { get; set; }
    }
}
