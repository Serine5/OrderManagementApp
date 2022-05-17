using DAL;
using DAL.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderManagementApp
{
    public class CascadingDropdownComponentBase : ComponentBase
    {
        [Inject] public IDropdownService DropdownService { get; set; }
        protected CascadingDropdownViewModel CascadingVM { get; set; } = new CascadingDropdownViewModel();
    }
}
