using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ProjectAurora.Models;

namespace ProjectAurora.Models
{
    public class CatalogEntryModel
    {
        public TextBox DescriptionTextBox { get; set; }
        public string GameImagePath { get; set; }
        public string IgnReviewUrl { get; set; }
        public string GamespotReviewUrl { get; set; }
        public string PcgamerReviewUrl { get; set; }
        public string EurogamerReviewUrl { get; set; }
        public string Trailer1Url { get; set; }
        public string Trailer2Url { get; set; }
        public string Trailer3Url { get; set; }
        public string Trailer4Url { get; set; }
        public string Screenshot1Url { get; set; }
        public string Screenshot2Url { get; set; }
        public string Screenshot3Url { get; set; }
    }


    public class CatalogEntryDbContext : DbContext
        {
            public DbSet<CatalogEntryModel> CatalogEntryModels { get; set; }
        }
}