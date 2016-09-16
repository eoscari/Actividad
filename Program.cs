using System;

namespace EJE7
{
	class Program
	{
			
		public static void Main(string[] args)
		{ 
			int opcion = 0;
			char resp='S';
			
			
			Console.Title= "Trabajando con Ficheros";
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write("INGRESE EL NOMBRE EL FICHERO : ");
			string nombre = Console.ReadLine();
			//aqui le quiero pasar la ruta
			nombre="C:\\"+nombre+".txt";
			CListaArt LA= new CListaArt(nombre,resp);
			//controlar que "resp" este en mayuscula
			if (resp=='S'){
			Console.WriteLine("*********MENU DE ARTICULOS**********");
			Console.WriteLine("1. Añadir ");
			Console.WriteLine("2. Eliminar ");
			Console.WriteLine("3. Modificar ");
			Console.WriteLine("4. Buscar ");
			Console.WriteLine("5. Salir");
			Console.Write("Opcion : ");
			opcion = int.Parse(Console.ReadLine());
			//switch
			}
		 Console.ReadKey(true);
			}
	}
}
/*
 con respecto al ejercicio pensaba que el almacen o donde esten los articulos sea el Main principal o tambien puede ser otra clase  que maneje el fichero
que encapsule un flujo vinculado con unfichero y
 muestre una interfaz que permite al ABM de los productos. La clase objeto Articulo encapsulara codigo, nombre, marca..etc ylas propiedades publicas 
que forman parte de la intefaz de esta clase de objeto.
 */
