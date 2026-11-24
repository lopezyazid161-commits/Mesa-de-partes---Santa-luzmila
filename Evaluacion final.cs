using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace evaluacion_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GestorExpedientes sistema = new GestorExpedientes();
            sistema.Ejecutar();

        }

     
    }
}
