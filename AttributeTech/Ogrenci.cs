using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTech
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string adi;

        [ZorunluAlan]
        public string bolum;

        //[Security]
        //[Log]
        //[Cache]
        //[Exception]
        //public List<Ogrenci> ogrenciListesiGetir()
        //{
            //verileri getir
        //    return null;
        //}
    }
}
