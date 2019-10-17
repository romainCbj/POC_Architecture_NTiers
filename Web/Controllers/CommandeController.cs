using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CommandeController : Controller
    {
        private ICommandeManager _commandeManager;

        public CommandeController(ICommandeManager commandeManager)
        {
            _commandeManager = commandeManager;
        }

        public IActionResult Index()
        {
            return View(_commandeManager.RecupererCommandes());
        }
    }
}