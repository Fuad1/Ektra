using Ektra.Core;
using Ektra.Persistence;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace Ektra.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FolloweesController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Followees
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artist = _unitOfWork.Users.GetArtistsFollowedBy(userId);

            return View(artist);
        }
    }
}