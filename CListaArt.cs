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
//		private StreamWriter sw;
//		private BinaryReader br;
//		private BinaryWriter bw;
//		private int nregs;
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
		
		public void Alta() {
		   
		}
	}
}
