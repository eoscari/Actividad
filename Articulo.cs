/*
 * Creado por SharpDevelop.
 * Usuario: casa
 * Fecha: 9/14/2016
 * Hora: 11:31 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace EJE7
{
	
	public class Articulo
		
	{    //ATRIBUTOS
		private String codigo;
		private String Nombre;
		private String marca;	
		private String Nom_Proveedor;
		private Double Precio_Min;
		private Double Precio_May;
		private integer Stock;
		
		//CONSTRUCTOR
		public Articulo(String cod, String nom, String mar, String NP,Double PMin, Double PMay,integer cant)
		{	
			this.codigo = cod;
			this.Nombre = nom;
			this.marca = mar;
			this.Nom_Proveedor = NP;
			this.Precio_Min = PMin;
			this.Precio_May = PMay;
			this.Stock = cant;
		}
		
		//SETTERS Y GETTERS
		public String SGCodigo
		{
			get{return codigo;}
			set{codigo = value;}
		}
		public String SGNombre
		{
			get{return Nombre;}
			set{Nombre=value;}
		}
		public String SGMarca
		{
			get{return marca;}
			set{marca=value;}
		}
		public String SGNom_Provee
		{
			get{return Nom_Proveedor;}
			set{Nom_Proveedor=value;}
		}
		public Double SGMinorista
		{
			get{return Precio_Min;}
			set{Precio_Min=value;}
		}
		public Double SGMayorista
		{
			get{return Precio_May;}
			set{Precio_May=value;}
		}
		public integer SGStock
		{
			get{return Stock;}
			set{Stock=value;}
		}
		
}
}