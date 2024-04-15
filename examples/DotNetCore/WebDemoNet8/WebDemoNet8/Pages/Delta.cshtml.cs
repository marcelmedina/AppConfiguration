using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement.Mvc;

namespace WebDemoNet8.Pages
{
    [FeatureGate("Delta")]
    public class DeltaModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
