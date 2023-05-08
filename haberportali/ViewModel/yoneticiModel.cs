using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace haberportali.ViewModel
{
    public class yoneticiModel
    {
        public int yoneticiId { get; set; }
        public string kullaniciAdi { get; set; }
        public string parola { get; set; }
        public string aciklama { get; set; }
    }
}