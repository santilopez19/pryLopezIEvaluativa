using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezIEvaluativa
{
    //Este código representa una clase llamada clseArchivo con un método público llamado Grabar. La función de esta clase y su método es escribir una línea de texto en un archivo CSV. Aquí te explico lo que hace cada una de las líneas de código:

    //internal class clseArchivo  Esta línea define una clase llamada clseArchivo.La palabra clave internal indica que la clase es accesible solo dentro del ensamblado actual (es decir, solo dentro del proyecto en el que se encuentra esta clase).

    internal class clseArchivo
    {
        //public void Grabar(string datosConcatenados) Esto define un método público llamado Grabar. Este método acepta un parámetro de tipo string llamado datosConcatenados, que representa la línea de texto que se va a escribir en el archivo CSV.

        public void Grabar(string datosConcatenados)
            {
            //StreamWriter AD = new StreamWriter("../../Resources/Lista.csv", true); En esta línea, se crea una instancia de la clase StreamWriter llamada AD. Este objeto se utiliza para escribir datos en un archivo. El constructor de StreamWriter recibe dos argumentos: el primero es la ruta del archivo en el que se desea escribir ("../../Resources/Lista.csv" en este caso), y el segundo es un valor booleano (true en este caso) que indica que se desea agregar texto al archivo existente en lugar de sobrescribirlo si ya existe.

            StreamWriter AD = new StreamWriter("../../Resources/Lista.csv", true);


            //AD.WriteLine(datosConcatenados); Esta línea utiliza el objeto AD para escribir la cadena datosConcatenados en una nueva línea en el archivo. Esto significa que la línea de texto pasada como argumento al método Grabar se agregará al final del archivo CSV.
            AD.WriteLine(datosConcatenados);


            //AD.Close(); Esta línea cierra el objeto StreamWriter AD. Es importante cerrar el objeto después de usarlo para liberar los recursos asociados y garantizar que todos los datos pendientes se escriban en el archivo.

            AD.Close();
            }
        
    }
}

//Este código representa una clase que se utiliza para escribir líneas de texto en un archivo CSV. El método Grabar acepta una cadena de texto como entrada y la agrega al final del archivo CSV especificado en la ruta "../../Resources/Lista.csv".


