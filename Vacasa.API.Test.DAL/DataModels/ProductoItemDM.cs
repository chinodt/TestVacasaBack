using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacasa.API.Test.DAL.DataModels
{
    public class ProductoItemDM
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public PicturesDM[] pictures { get; set; }
    }

    public class PicturesDM
    {
        public string id { get; set; }
        public string url { get; set; }
        public string secure_url { get; set; }
        public string size { get; set; }
        public string max_size { get; set; }
    }
}
