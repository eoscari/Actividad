/*
 * Creado por SharpDevelop.
 * Quispe Alejandra 
 * Fecha: 9/15/2016
 * Hora: 10:26 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace EJE7
{
	public class CListaArt
	{//ATRIBUTOS
    	private FileStream fs;  
//		private StreamReader sr;
		private StreamWriter sw;
//		private BinaryReader br;
//		private BinaryWriter bw;
		private int nregs;
//		private bool regsEliminado=false;
//		private bool regsModificado=false;
		
		//CONSTRUCTOR
		public CListaArt(string fichero, char respuesta)
		{  
		    respuesta ='S';
			if (File.Exists(fichero))
			{
				Console.Write("El fichero Existe desea trabajar en el ? (S/N): ");
				respuesta=char.Parse(Console.ReadLine());}
		 	else {fs= new FileStream(fichero, FileMode.CreateNew, FileAccess.ReadWrite);}
		}
		
		public void Alta(string fi) {
			string cadena;
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("Codigo:");
			String cod=Console.ReadLine();
			Console.Write("Nombre: ");
			String nom=Console.ReadLine();
			Console.Write("Marca: ");
			String mar=Console.ReadLine();
			Console.Write("Nombre del Proveedor :");
			String Nom_Prov=Console.ReadLine();
			Console.Write("Precio Minimo del Art.: ");
			String PreMin=Console.ReadLine();
			Console.Write("Precio Maximo del Art.: ");
			String PreMay=Console.ReadLine();
			Console.Write("Stock: ");
			String sto=Console.ReadLine();
			cadena=cod+"-"+nom+"-"+mar+"-"+Nom_Prov+"-"+PreMin+"-"+PreMay+"-"+sto;
			Console.Write("Esto guarda en el fichero "+cadena);
			sw = new StreamWriter(new FileStream(fi,FileMode.Append,FileAccess.Write));
			sw.WriteLine(cadena);
			nregs++;
			if (sw!=null)sw.Close();
		}
	}
}
