using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BowlingASP.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            List<GameService.game> list = new List<GameService.game>();
            list = client.findAll("0", null, null);
            return View(list);
        }

        public ActionResult Show(int id)
        {
            return View();
        }

        public ActionResult Filter(String state) 
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            List<GameService.game> list = new List<GameService.game>();
            list = client.findAll("0", "state", state);
            
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
        
        public ActionResult Cancel(int id)
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            client.updateState(id.ToString(), "canceled");
            return RedirectToAction("Index");
        }
          
        public ActionResult Start(int id)
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            LaneService.ServiceLaneClient clientLane = new LaneService.ServiceLaneClient();
            GameService.game game = client.find(id.ToString());
                
            if (clientLane.isAvalaible(game.Lane_id.ToString()))
            {
                client.updateState(id.ToString(), "in progress");
            } else {
                RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            GameService.game game = client.find(id.ToString());
            return View(game);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                PlayerService.ServicePlayerClient client = new PlayerService.ServicePlayerClient();
                GameService.ServiceGameClient clientGame = new GameService.ServiceGameClient();

                PlayerService.game game = client.findGame(id.ToString());

                for (int i = 0; i < collection.Count-1; i++)
                {                    
                    String name = "Pseudo" + i;
                    String playerPseudo = collection[name];
                    
                    if (playerPseudo != "")
                    {
                        if (i < game.players.Count)
                        {
                            game.players.ElementAt(i).Pseudo = playerPseudo;
                            client.updatePlayer(game.players.ElementAt(i));
                        } else {
                            GameService.player player = new GameService.player();
                            player.Pseudo = playerPseudo;
                            clientGame.addPlayer(id.ToString(), player);
                        }
                    }
                    else
                    {
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
