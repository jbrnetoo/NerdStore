
using Microsoft.AspNetCore.Mvc;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class BaseController : Controller
    {
        protected Guid ClienteId = Guid.Parse("c38ea4df-0b95-4b53-b9e3-bf81ac3d2a7a");
    }
}
