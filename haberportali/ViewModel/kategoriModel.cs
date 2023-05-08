using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace haberportali.ViewModel
{
    public class kategoriModel
    {
        public int kategoriId { get; set; }
        public string kategoriAdi { get; set; }
        public List<haberModel> haberler { get; set; }
    }
}