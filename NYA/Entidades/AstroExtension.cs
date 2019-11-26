using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;

namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("planeta.txt"))
                {
                    sw.WriteLine(plan.ToString());
                }
                
            }
            catch (Exception e)
            {

                throw new Exception("Error al guardar .txt",e);
            }
            return true;
        }

        public static bool GuardarXML(this Satelite sat)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Satelite));
                XmlTextWriter xw = new XmlTextWriter("Satelite.xml", Encoding.UTF8);

                xw.Formatting = Formatting.Indented;
                ser.Serialize(xw, sat);

                xw.Close();

            }
            catch (Exception e)
            {

                throw new Exception("Error al guardar .xml", e);
            }
            return true;
        }
    }
}
