using ASP_NET_MVC_5_with_Entity_Framework_Tutorial_for_Beginners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_5_with_Entity_Framework_Tutorial_for_Beginners.Controllers
{
    public class GamesController : Controller
    {
        public ActionResult Index()
        {
            Game game = new Game { GameId = 1, GameName = "Anno 2205", Description = "Anno 2025 — это экономическая игра в реальном времени от компании Ubisoft, действие которой разворачивается в далеком будущем, когда человечество начало покорять луну. Основная цель – постройка космопорта и создание процветающей лунной колонии, для борьбы за ресурсы и влияние. Как и в предыдущих частях этой стратегической серии, в Anno 2025 вы также должны развивать свои города и поселения, строить промышленные и развлекательные зоны…", Developers = new string[] { "Ubisoft Entertainment" }, Genre = new string[] { "Стратегия" }, Localization = "Субтитры на русском языке", ReleaseDate = new DateTime(2015, 11, 3), MiddleScore = 7.1f, Platforms = new string[] { "PC" }, Publisher = "Ubisoft Entertainment", ImageUrl = "https://metarankings.ru/images/uploads/Anno-2205-boxart-cover.jpg" };
            ViewBag.Title = $"{game.GameName} - отзывы игроков, обзоры критиков, оценки, рейтинг";
            return View(game);
        }
    }
}