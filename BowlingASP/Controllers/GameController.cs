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
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                GameService.ServiceGameClient client = new GameService.ServiceGameClient();
                GameService.game game = client.createGame();
                for (int i = 1; i < collection.Count; i++)
                {
                    String name = "Pseudo" + i;
                    String playerPseudo = collection[name];
                    if (playerPseudo != "")
                    {
                        GameService.player player = new GameService.player();
                        player.Pseudo = playerPseudo;
                        client.addPlayer(game.Id.ToString(), player);
                    } else {
                        return View();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
