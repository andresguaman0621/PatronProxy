namespace PatronProxy
{
    class Program
    {
        static void Main(string[] args) 
        {
            //creacion del proxy a la pagina de descarga
            Servidor servidor = new ProxyMiServidor(20, "https://www.laylita.com/recetas/mejores-blogs-de-cocina/");

            //Descargar un archvo permitido
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(servidor.descargar("descargaPermitida"));
            Console.ReadLine();

            //Intento con una descarga restringida
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(servidor.descargar("descargaDegenada"));
            Console.ReadLine();
        }
    }

   
}