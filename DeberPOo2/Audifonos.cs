using System;

namespace solucionEconomica
{
    class Audifonos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public Audifonos Clientes { get; set; }

        //Volumen
        public string EstadoVolumen()
        {
            return "Su pulso cardiaco es de: 82 BPM";
        }
        public string Encender(string prNombre)
        {
            return $"Encendiendo{prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando{pNombre}";
        }

        public static implicit operator Audifonos(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}