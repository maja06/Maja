using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace RazorPagesDevice.Models
{
    public class Device
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public string DeviceTypes { get; set; }
        public string DeviceTypeProperties { get; set; }
        public int DevicesTypeValues { get; set; }
    }

    
        public class RazorPagesDeviceContext : DbContext
        {
            public RazorPagesDeviceContext(DbContextOptions<RazorPagesDeviceContext> options)
                : base(options)
            {
            }

            public DbSet<RazorPagesDevice.Models.Device> Device { get; set; }
        }
    }

