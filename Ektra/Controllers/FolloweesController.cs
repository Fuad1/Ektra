using Ektra.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace Ektra.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FolloweesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Followees
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artist = _context.Followings
                .Where(f => f.FollowerId == userId)
                .Select(f => f.Followee)
                .ToList();

            return View(artist);
        }
    }
}