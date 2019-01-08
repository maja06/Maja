﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesDevice.Models;

namespace RazorPagesDevice.Pages.Devices
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesDevice.Models.RazorPagesDeviceContext _context;

        public DetailsModel(RazorPagesDevice.Models.RazorPagesDeviceContext context)
        {
            _context = context;
        }

        public Device Device { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Device = await _context.Device.FirstOrDefaultAsync(m => m.ID == id);

            if (Device == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
