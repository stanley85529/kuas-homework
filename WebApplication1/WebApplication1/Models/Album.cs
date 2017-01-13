using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Album
    {
        public string ID { get; set; }
        public string 名稱 { get; set; }
        public string 記事者 { get; set; }
        public decimal 金錢花費 { get; set; }
        public string ImageUrl { get; set; }
    }
    public class Albums
    {
        public int AlbumID { get; set; }
        public int 名稱Id { get; set; }
        public string 記事者 { get; set; }
        public decimal 金錢花費 { get; set; }
        public string AlbumArtUrl { get; set; }
    }
}