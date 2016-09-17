using System;
using System.IO;
using System.Text;


namespace EJE7
{
	class Program
	{
		
		
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
		}
	}
}
/*
 con respecto al ejercicio pensaba que el almacen o donde esten los articulos sea el Main principal o tambien puede ser otra clase  que maneje el fichero
que encapsule un flujo vinculado con unfichero y
 muestre una interfaz que permite al ABM de los productos. La clase objeto Articulo encapsulara codigo, nombre, marca..etc ylas propiedades publicas 
que forman parte de la intefaz de esta clase de objeto.
 */
