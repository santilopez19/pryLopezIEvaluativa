using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezIEvaluativa
{
    internal class clseArchivo
    {
            public void Grabar(string datosConcatenados)
            {
                StreamWriter AD = new StreamWriter("../../Resources", true);
                AD.WriteLine(datosConcatenados); 
                AD.Close();
            }
        
    }
}
