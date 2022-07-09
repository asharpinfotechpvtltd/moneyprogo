using moneyprogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace QDEE.Areas.Dashboard.Pages
{
    public class IndexModel : PageModel
    {

        ApplicationDbContext context;

        public IndexModel(ApplicationDbContext _context)
        {
            context = _context;
        }
        [BindProperty]
        public List<SelectListItem> Province { get; set; }
        [BindProperty]
        // public IList<PickUpAddress>? PickUpAddress { get; set; }

        //  public IList<DeliveryAddress>? DeliveryAddress { get; set; }

        public string CustomerId { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
            //if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Code")))
            //{
            //    try
            //    {
            //        CustomerId = HttpContext.Session.GetString("Code");
            //        //Province = await context.TblProvince.Select(a => new SelectListItem { Text = a.ProvinceName, Value = a.Id.ToString() }).ToListAsync();
            //        //PickUpAddress = await context.TblPickUpAddress.Where(ccid => ccid.CustomerId == CustomerId).ToListAsync();
            //        //DeliveryAddress = await context.TblDeliveryAddress.Where(ccid => ccid.CustomerId == CustomerId).ToListAsync();

            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    return Page();
            //}
            //else
            //{
            //    return Redirect("~/Index");
            //}

        }

        public IActionResult OnGetLogout()
        {

            HttpContext.Session.Remove("Code");
            HttpContext.Session.Remove("Schedulecart");
            HttpContext.Session.Clear();
            return Redirect("~/Index");
        }

    }
}
        
