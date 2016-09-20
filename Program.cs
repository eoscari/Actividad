using System;
using System.IO;
using System.Text;

namespace EJE7
{
	class Program
	{
				
		public static void Main(string[] args)	
		{ 
			Console.Title= "Trabajando con Ficheros";
			CListaArt archivo = new CListaArt();
			Console.ForegroundColor = ConsoleColor.Green;
			byte opcion;
			opcion = 0;
			do{
				try{
					Console.WriteLine("Menú de opciones");
					Console.WriteLine("1. Altas");
					Console.WriteLine("2. Bajas");
					Console.WriteLine("3. Modificación");
					Console.WriteLine("4. Consultas");
					Console.WriteLine("5. Ver todos los registros");
					Console.WriteLine("6. Salir");
					Console.Write("Qué deseas hacer?...");
					opcion = Convert.ToByte(Console.ReadLine());
					switch(opcion){
						case 1:
							archivo.altas();
							break;
						case 2:
							archivo.bajas();
							break;
						case 3:
							archivo.modificar();
							break;
						case 4:
							archivo.consultar();
							break;
						case 5:
							archivo.consultagral();
							break;
						case 6:
							Console.WriteLine("****************************");
							Console.WriteLine("*** Saliendo del sistema ***");
							Console.WriteLine("****************************");
							break;
						default:
							Console.WriteLine("*************************");
							Console.WriteLine("*** Opción incorrecta ***");
							Console.WriteLine("*************************");
							break;
				}
				}catch(FormatException fe){
					Console.WriteLine("*************************");
					Console.WriteLine("Error!! " + fe.Message);
					Console.WriteLine("*************************");
				} catch(Exception e){
					Console.WriteLine("*************************");
					Console.WriteLine("Error!! " + e.Message);
					Console.WriteLine("*************************");
				}
			}while(opcion!=6);
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
