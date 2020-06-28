using System;
using System.Collections.Generic;
using System.Text;

namespace DeberPoo2
{
    class Parlante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public Parlante Propietario { get; set; }


        //Volumen
        public string ProvarVolumen()
        {
            return $"Subir volumen..";
        }
       
        //conectar
        public string Conectar()
        {
            return "Su parlante esta conectado al Blutoo97";
        }
        public string Encender(string prNombre)
        {
            return $"Encendiendo {prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando {pNombre}";
        }
    }
}
