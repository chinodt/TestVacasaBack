using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Vacasa.API.Test.DAL.DataModels
{
    public class ProductoDM
    {
        public string id { get; set; }
        public string thumbnail { get; set; }
        public string title { get; set; }
        public string price { get; set; }
    }
}
