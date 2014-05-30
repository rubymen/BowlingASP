using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BowlingASP.Controllers
{
    public class GameController : Controller
    {
        // L'ensemble des actions sont connectées au webservice SOAP : bowling.noip.me 

        // Action Index retournant l'ensemble des parties
        public ActionResult Index()
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            List<GameService.game> list = new List<GameService.game>();
            list = client.findAll("0", null, null);
            return View(list);
        }

        // Action Show retournant une partie en fonction de son Id
        public ActionResult Show(int id)
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            GameService.game game = client.find(id.ToString());
            return View(game);
        }

        /* Action Filter permet de filtrer les parties. Elle prend en paramètre le filtre (date ou statut)
         * et le paramètre souhaité. Retourne une liste de parties.
         */
        public ActionResult Filter(String filter, String param) 
        {
            GameService.ServiceGameClient client = new GameService.ServiceGameClient();
            List<GameService.game> list = new List<GameService.game>();
            list = client.findAll("0", filter, param);
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        /* Action Create qui récupère le formulaire de la vue Create.
         * Il se charge de créer une partie et d'associer des joueurs à celle-ci. 
         */
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
        
        // Action Start et Cancel permettant d'annuler ou de démarrer une partie en fonction de son Id.
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

        // Action Edit permettant d'éditer et modifier une partie (Suppression de joueurs et modification de leurs pseudos)
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
