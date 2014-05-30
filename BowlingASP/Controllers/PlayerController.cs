using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BowlingASP.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        // Suppression d'un joueur assigné à une partie et redirection sur la vue en cours d'édition.
        public ActionResult Delete(int id) 
        {
            PlayerService.ServicePlayerClient client = new PlayerService.ServicePlayerClient();
            PlayerService.player p = client.find(id.ToString());
            client.deletePlayer(id.ToString());
            return RedirectToAction("Edit", "Game", new { id = p.Game_id.ToString() });
        }
    }
}
