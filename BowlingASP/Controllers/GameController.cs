using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BowlingASP.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Index()
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            List<GameService.game> list = new List<GameService.game>();
            list = client.findAll("0");
            return View(list);
        }

        public ActionResult Create()
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            PlayerService.ServicePlayerClient clientPlayer = new PlayerService.ServicePlayerClient();
            return View();
        }
    }
}
