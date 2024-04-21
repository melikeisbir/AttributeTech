using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTech
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    //bu tanım ile ilgili attribute sadece fieldlarda(değişkenlerde) geçerli olacak
    public class ZorunluAlanAttribute : Attribute
    {
    }
}
