using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebApiEmpty.Models
{
    public class Song
    {
        public int SongId { get; set; }

        public string Name { get; set; }

        public int PlayCount { get; set; }

        public DateTime LastPlayed { get; set; }
    }
}