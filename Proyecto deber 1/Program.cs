using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_deber_1
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiculo carro = new vehiculo();
            vehiculo.motor = "Apagado";
            vehiculo.tanqueGasolina = 5;
            vehiculo.velocidad = 0;
            carro.encender();
            Console.WriteLine(vehiculo.motor);
            carro.aumentar();

            Console.WriteLine(vehiculo.velocidad);
            carro.disminuir();

            Console.WriteLine(vehiculo.velocidad);
            carro.frenar();

            Console.WriteLine(vehiculo.velocidad);
            carro.apagar();

            Console.WriteLine(vehiculo.motor);
            carro.llenar(4);

            Console.WriteLine(vehiculo.tanqueGasolina);
            carro.vaciar();

            Console.WriteLine(vehiculo.tanqueGasolina);
        }
    }
}
