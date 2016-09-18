using System;
using System.IO;
<<<<<<< HEAD
=======
using System.Text;

>>>>>>> origin/master

namespace EJE7
{
	class Program
	{
<<<<<<< HEAD
				
		public static void Main(string[] args)
		{ 
			CListaArt archivo = new CListaArt();
			Console.ForegroundColor = ConsoleColor.Red;
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
							//archivo = new CListaArt();
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
=======
		
		
		public static void Main(string[] args)
		{ 
			StreamWriter archivo;
			CListaArt ListaArt;
			
			int opcion;
			//char resp='S';
			
			
			//ListaArt.CreaArchivo(nombre);
			
			//StreamWriterescritura=finally File.CreateText("")
			
			//Console.Title= "Trabajando con Ficheros";
			//Console.ForegroundColor = ConsoleColor.DarkGreen;
			//Console.Write("INGRESE EL NOMBRE EL FICHERO : ");
			//string nombre = Console.ReadLine();
			//aqui le quiero pasar la ruta
			///nombre=@"..\..\"+nombre+".txt";
			//nombre="A:\\"+nombre+".txt";
			//CListaArt LA= new CListaArt(nombre,resp);
			//controlar que "resp" este en mayuscula
			//if (resp=='S')
			do
			{
				Console.WriteLine("*********MENU DE ARTICULOS**********");
				Console.WriteLine("1. Añadir ");
				Console.WriteLine("2. Eliminar ");
				Console.WriteLine("3. Modificar ");
				Console.WriteLine("4. Buscar ");
				Console.WriteLine("5. Salir");
				Console.Write("Opcion : ");
				opcion = Int32.Parse(Console.ReadLine());
				switch (opcion)
				{
					case 1:
					{
						Articulo art;
						ListaArt= new CListaArt();
						string resp;
													
						Console.Write("INGRESE EL NOMBRE EL Archivo : ");
						string nombre = Console.ReadLine();
						//archivo= new StreamWriter(nombre+".txt");//CREA AL ARCHIVO DE TEXTO
						archivo=File.AppendText(nombre+".txt");//ABRIR EL ARCHIVO
						do
						{
							Console.WriteLine("----------Ingrese datos de articulos----------");
							Console.Write("Ingrese Codigo del articulo: ");
							String c =(Console.ReadLine());
							Console.Write("Ingrese Nombre del articulo: ");
							String nom_a =(Console.ReadLine());
							Console.Write("Ingrese la marca: ");
							String m=(Console.ReadLine());
							Console.Write("Ingrese Nombre del proveedor: ");
							String nom_p=(Console.ReadLine());
							Console.Write("Ingrese el precio Minorista: ");
							double p_min= double.Parse(Console.ReadLine());
							Console.Write("Ingrese el precio Mayorista: ");
							double p_may= double.Parse(Console.ReadLine());
							Console.Write("Ingrese el Stock: ");
							int s= Int32.Parse(Console.ReadLine());
							Console.WriteLine();
							//Instancia Un ARTICULO CON TODOS SUS DATOS
							art = new Articulo(c,nom_a,m,nom_p,p_min,p_may,s);
							String Linea=ListaArt.PasarLinea(art);//
							archivo.WriteLine(Linea);//GUARDA DATOS EN EL ARCHIVO
							Console.Write("Desea seguir agregando otro Articulo (SI/NO)?...");
							resp=Console.ReadLine();
							resp=resp.ToUpper();
						}while (resp.Equals("SI"));
						archivo.Close();
						break;
					}
					case 2:
					{
						break;
					}
					case 3:
					{
						Console.Write("INGRESE EL NOMBRE EL Archivo que desee modificar : ");
						string nombre = Console.ReadLine();
						archivo=File.AppendText(nombre+".txt");
						//Falta lo demas...
						archivo.Close();
						break;						
					}
					default: 
					{
						Console.Write("La opcion elejida no es valida");
						break;
					}
				}
			}while (opcion != 5);
		 //Console.ReadKey(true);
>>>>>>> origin/master
		}
	}
}
/*
 con respecto al ejercicio pensaba que el almacen o donde esten los articulos sea el Main principal o tambien puede ser otra clase  que maneje el fichero
que encapsule un flujo vinculado con unfichero y
 muestre una interfaz que permite al ABM de los productos. La clase objeto Articulo encapsulara codigo, nombre, marca..etc ylas propiedades publicas 
que forman parte de la intefaz de esta clase de objeto.
 */
