using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDevice.Models;

namespace RazorPagesDevice.Pages.Devices
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesDevice.Models.RazorPagesDeviceContext _context;

        public IndexModel(RazorPagesDevice.Models.RazorPagesDeviceContext context)
        {
            _context = context;
        }

        public IList<Device> Device { get;set; }

        public async Task OnGetAsync()
        {
            Device = await _context.Device.ToListAsync();
        }
    }
}
