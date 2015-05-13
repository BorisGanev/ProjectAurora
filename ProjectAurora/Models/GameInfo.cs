using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjectAurora.Models
{
    public class GameInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Platforms { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Display(Name = "Metacritic Score")]
        public int MetaCriticScore { get; set; }
    }

    public class GameInfoDbContext : DbContext
    {
        public DbSet<GameInfo> GamesInfos { get; set; }
    }
}