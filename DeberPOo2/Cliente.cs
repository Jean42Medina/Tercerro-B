using System;

namespace DeberPoo2
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        Computadora computadora;
        public Computadora Micomputadora
        {
            get
            {
                return computadora;
            }

            set
            {
                computadora = value;
                computadora.Dueño = this;
            }
        }
        Reloj reloj;
        
        public Reloj Mireloj
        {
            get
            {
                return reloj;
            }

            set
            {
                reloj = value;
            }
        }
        
        Television tv;

        public Television Mitv
        {
            get
            {
                return tv;
            }

            set
            {
                tv = value;
            }
        }

        //saludar
        public string Saludar()
        {
            return "Buenos dia, ¿Te podría ayudar en algo?";
        }

        //Pedir
        public string Pedir(string nombreProducto, string marcaProducto)
        {
            return $"Me voy a lleva el {nombreProducto} {marcaProducto}";
        }
        //pagar
        public string Pagar()
        {
            return "Le entrega el dinero";
        }
        //salir
        public string Salir()
        {
            return "Muy gracias por su compra";
        }
        public string ProductoCompu()
        
        {
            if (computadora != null)
                return $"me compré una computadora {computadora.Nombre} {computadora.Marca}";
            else
                return "no tengo computadora";
        }

        public string ProductoParlante()
        {
            if (parlante != null)
                return $"me compré un televisor {parlante.Nombre} {parlante.Marca}";
            else
                return "no tengo television";
        }
        
        public string ProductoAudifonos()
        {
            if (audifonos != null)
                return $"me compré un reloj {audifonos.Nombre} {audifonos.Marca}";
            else
                return "no tengo reloj";
        }
    }
}