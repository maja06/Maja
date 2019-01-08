using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesDevice.Models
{
    public class RazorPagesDeviceContext : DbContext
    {
        public RazorPagesDeviceContext()
            : base(options)
        {
        }

        public DbSet<RazorPagesDevice.Models.Device> Device { get; set; }
    }
}
