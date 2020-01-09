using BlockedUsers.Models;
using BlockedUsers.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlockedUsers.Controllers
{
    public class HomeController : Controller
    {
        BlockedUsersDB context = new BlockedUsersDB();
        public ActionResult Index()
        {
            SearchViewModel resultScreen = new SearchViewModel();
            resultScreen.Result = new List<TblBloquedUsers>();

            var resultDB = context.TblBloquedUsers.ToList();
            foreach (var item in resultDB)
            {
                resultScreen.Result.Add(item);
            }
            return View(resultScreen);
        }

        [HttpPost]
        public ActionResult Pesquisar()
        {
            return View();
        }

    }
}