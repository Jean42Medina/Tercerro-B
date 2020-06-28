using System;

namespace DeberPoo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Id = new Random();

            //Instancias de clientes
            Computadora computadora = new Computadora
            {
                Id = Id.Next(),
                Nombre = "Geimer",
                Marca = "HP",
                Almacenamiento="2TB",
                Generacion="Intel Corei7 ",
                Costo=499
            };
            Cliente cliente1 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Jean",
                Apellido = "Pierre",
                Micomputadora = computadora
            };

            Parlante par = new Parlante
            {
                Id = Id.Next(),
                Nombre = "Secuiryti 20",
                Marca = "Samsung",
                Costo=50
            };
            Cliente cliente2 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Lauren",
                Apellido = "Jauregui",
                Mitv=tele
            };
            
            Audifono audi = new Audifono
            {
                Id = Id.Next(),
                Nombre = "SmartWatch 4",
                Marca = "Sony",
                Costo = 24
            };
            Cliente cliente3 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Daniela",
                Apellido = "Savedra",
                Mireloj = relojito
            };
            Empleado trabajador1 = new Empleado
            {
                Id = 1,
                Nombre = "Jhonatan"
            };
            Empleado trabajador2 = new Empleado
            {
                Id = 2,
                Nombre = "Sara"
            };

            Almacen empresaTrab1 = new Almacen
            {
                Id = Id.Next(),
                Nombre = "Point ",
                Direccion = "Simon Bolivar y Aldas",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo=trabajador1
            };
            Almacen empresaTrab2 = new Almacen
            {
                Id = Id.Next(),
                Nombre = "Point ",
                Direccion = "AV.Mariscal Sucre",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo = trabajador2
            };


            string proCpu = cliente1.ProductoCpu();
            string proParlante = cliente2.ProductoParlante();
            string proAudino = cliente3.ProductoAudifono();
            string miTrabajo1 = empresaTrab1.PlazaTrabajo();
            string miTrabajo2 = empresaTrab2.PlazaTrabajo();
            string saludoCli1 = cliente1.Saludar();
            string saludoCli2 = cliente1.Saludar();
            string saludoCli3 = cliente1.Saludar();

            string empleadoAtenderCpu = trabajador1.Atender();
            string empleadoAtenderParlante = trabajador1.Atender();
            string empleadoAtenderAudifono = trabajador1.Atender();

            string empleadoRegistrarCpu = trabajador1.Registrar(computadora.Nombre);
            string empleadoRegistrarParlante = trabajador1.Registrar(par.Nombre);
            string empleadoRegistrarAudifono = trabajador1.Registrar(audi.Nombre);


            string empleadoCobrarCpu = trabajador1.Cobrar(computadora.Costo);
            string empleadoCobrarParlante = trabajador1.Cobrar(par.Costo);
            string empleadoCobrarAudifono = trabajador1.Cobrar(audi.Costo);

            string empleadoEntregarFactCpu = trabajador1.EntregarFactura();
            string empleadoEntregarFactParlante = trabajador1.EntregarFactura();
            string empleadoEntregarFactAudifono = trabajador1.EntregarFactura();

            string computadoraEnceder = computadora.Encender(computadora.Nombre);
            string computadoraApagar = computadora.Apagar(computadora.Nombre);
            string computadoraDescargar = computadora.DescargarArchivos();
            string computadoraVideo = computadora.VideoLlamada();




            string parEnceder = par.Encender(par.Nombre);
            string parApagar = par.Apagar(par.Nombre);
            string parCanal = par.EstadoVolumen();
         

            string audifonoEnceder = audi.Encender(audi.Nombre);
            string audifonoApagar = audi.Apagar(audi.Nombre);
           

            string pedirCli1 = cliente1.Pedir(computadora.Nombre, computadora.Marca);
            string pedirCli2 = cliente2.Pedir(par.Nombre, par.Marca);
            string pedirCli3 = cliente3.Pedir(audi.Nombre, audi.Marca);
            string pagarCli1 = cliente1.Pagar();
            string pagarCli2 = cliente2.Pagar();
            string pagarCli3 = cliente3.Pagar();
            string salirCli1 = cliente1.Salir();
            string salirCli2 = cliente2.Salir();
            string salirCli3 = cliente3.Salir();

            Console.WriteLine($"\tSimulación de venta de aparatos {empresaTrab1.TipoDeEquipos}");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UNA COMPUTADORA");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-Mi nombre es {trabajador2.Nombre} y hoy la antenderé yo ({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente1.Nombre}(cliente 1),busco una computadora de 1TB y Corei7");
            Console.WriteLine($"-En este momento, tenemos esta {computadora.Nombre} {computadora.Marca} {computadora.Almacenamiento} {computadora.Generacion}");
            Console.WriteLine($"-¿Se puede probar las funciones?");
            Console.WriteLine($"-Por supuesto!/ {computadoraEnceder}");
            Console.WriteLine($"-Se puede realizar videollamadas desde esta aplicación y listo/.{computadoraVideo}");
            Console.WriteLine($"Se descargan rápidamente los archivos!/.. {computadoraDescargar}");
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones/ ({miTrabajo2}).. {computadoraApagar}");
            Console.WriteLine($"-¡Me gusta mucho, me la llevo!");
            Console.WriteLine($"-Por supuesto pase a Caja");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli1}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderCompu} ");
            Console.WriteLine($"-{pedirCli1} {computadora.Almacenamiento} {computadora.Generacion}");
            Console.WriteLine($"-{empleadoRegistrarCompu}");
            Console.WriteLine($"-{empleadoCobrarCompu}");
            Console.WriteLine($"-{pagarCli1}");
            Console.WriteLine($"-{empleadoEntregarFactCompu}");
            Console.WriteLine($"-{salirCli1}");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UNA Parlante");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-¿Que tal?, mi nombre es {trabajador2.Nombre} y te antenderé ({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente2.Nombre}(cliente 2),busco un televisor smart");
            Console.WriteLine($"-Nos acaba de llegar, esta Parlante {tele.Nombre} {tele.Marca}");
            Console.WriteLine($"-¿Puedo encenderla?");
            Console.WriteLine($"-Por supuesto y probarla!/ {teleEnceder}");
            
            
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones/ ({miTrabajo2}).. {teleApagar}");
            Console.WriteLine($"-¡Me gusta mucho, esta TV!");
            Console.WriteLine($"-Y no es tan costosa!");
            Console.WriteLine($"-Entonces me la llevo!");
            Console.WriteLine($"-Con mucho gusto, pase a Caja por favor");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli2}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderTv} ");
            Console.WriteLine($"-{pedirCli2}");
            Console.WriteLine($"-{empleadoRegistrarTv} {tele.Marca}");
            Console.WriteLine($"-{empleadoCobrarTv}");
            Console.WriteLine($"-{pagarCli2}");
            Console.WriteLine($"-{empleadoEntregarFactTv}");
            Console.WriteLine($"-{salirCli2}");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UN Audifono");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-Mucho gust, le saluda {trabajador2.Nombre} y estaré atendiendola({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente3.Nombre}(cliente 3),busco un audifono");
            Console.WriteLine($"-Por el momento tenemos este audifono {audi.Nombre} {audi.Marca}");
           
         
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones más/ ({miTrabajo2}).. {audifonoApagar}");
            Console.WriteLine($"-¡Es lo que estaba buscando, me lo llevo!");
            Console.WriteLine($"-Pase a Caja, allí le pueden ayudar");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli3}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderAudifono} ");
            Console.WriteLine($"-{pedirCli3}");
            Console.WriteLine($"-{empleadoRegistrarAudifono}");
            Console.WriteLine($"-{empleadoCobrarAudifono}");
            Console.WriteLine($"-{pagarCli3}");
            Console.WriteLine($"-{empleadoEntregarFactaAudifono}");
            Console.WriteLine($"-{salirCli3}, que gentil");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-Clientes satisfechos");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"Mi nombre es {cliente1.Nombre} y {proCpu} en {empresaTrab1.Nombre} justo {empresaTrab1.Direccion}.");
            Console.WriteLine($"Mi nombre es {cliente2.Nombre} y también {propar} en {empresaTrab1.Nombre}, no estaba nada mal su precio.");
            Console.WriteLine($"Mi nombre es {cliente3.Nombre} y {proAudifono} en {empresaTrab1.Nombre}, es una maravilla este audifono.");
      
            Console.ReadKey();





        }
    }
}
