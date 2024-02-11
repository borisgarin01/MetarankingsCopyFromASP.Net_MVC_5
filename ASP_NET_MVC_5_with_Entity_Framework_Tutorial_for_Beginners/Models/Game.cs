using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_5_with_Entity_Framework_Tutorial_for_Beginners.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        [DisplayName("Усредненная оценка")]
        public float MiddleScore { get; set; }
        [DisplayName("Разработчик")]
        public string[] Developers { get; set; }
        [DisplayName("Издатель")]
        public string Publisher { get; set; }
        [DisplayName("Платформы")]
        public string[] Platforms { get; set; }
        [DisplayName("Жанры")]
        public string[] Genre { get; set; }
        [DisplayName("Локализация")]
        public string Localization { get; set; }
        [DisplayName("Дата выхода")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}