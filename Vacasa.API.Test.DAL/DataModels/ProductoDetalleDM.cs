using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacasa.API.Test.DAL.DataModels
{
    public class ProductoDetalleDM
    {
        public string text { get; set; }
        public string plain_text { get; set; }
        public string last_updated { get; set; }
        public string date_created { get; set; }
        public SnapshotDM snapshot { get; set; }
    }

    public class SnapshotDM
    {
        public string url { get; set; }
        public string width { get; set; }
        public string price { get; set; }
        public string height { get; set; }
        public string status { get; set; }
    }
}
