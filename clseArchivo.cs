using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezIEvaluativa
{
    //Es una clase llamada clseArchivo con un método público llamado Grabar. La función de esta clase y su método es escribir una línea de texto.

    internal class clseArchivo
    {
        

        public void Grabar(string datosConcatenados)
            {
            //En esta línea, se crea una instancia de la clase StreamWriter llamada AD. Este objeto se utiliza para escribir datos en un archivo. El constructor de StreamWriter recibe dos argumentos: el primero es la ruta del archivo en el que se desea escribir ("../../Resources/Lista.csv" en este caso), y el segundo es un valor booleano (true en este caso) que indica que se desea agregar texto al archivo existente en lugar de sobrescribirlo si ya existe.

            StreamWriter AD = new StreamWriter("../../Resources/Lista.csv", true);


            //Esta línea utiliza el objeto AD para escribir la cadena datosConcatenados en una nueva línea en el archivo.
            AD.WriteLine(datosConcatenados);


            //Esta línea cierra el objeto StreamWriter AD.

            AD.Close();
            }
        
    }
}


