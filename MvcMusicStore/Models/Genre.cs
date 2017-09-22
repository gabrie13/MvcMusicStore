using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public virtual int         GenreId     { get; set; }

        [Display(Name = "Genre")]
        public virtual string      Name        { get; set; }
        public virtual string      Description { get; set; }
        public virtual List<Album> Album       { get; set; }
    }
}