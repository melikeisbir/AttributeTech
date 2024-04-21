using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTech
{
    public class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakClass)
        {
            Type dogrulanacakTur = dogrulanacakClass.GetType();
            FieldInfo[] dogrulanacakTurunAlanları = dogrulanacakTur.GetFields(BindingFlags.Public | BindingFlags.Instance); //gelen attribute public mi yoksa yeni nesnesi oluşturulan bir yapı mı
            foreach(FieldInfo dogrulanacakTurAlani in dogrulanacakTurunAlanları)
            {
                object[] zorunluAlanNitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true); //ozel olarak tanımlanan attributelar var  mı
                if(zorunluAlanNitelikleri.Length != 0 )
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakClass) as string;
                    if(string.IsNullOrEmpty(alanDegeri) ) //zorunlu alanlar boş geçilmemeli geçilirse burası
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
