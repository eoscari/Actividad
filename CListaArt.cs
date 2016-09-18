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
		private StreamReader lectura;
		private StreamWriter sw, escritura, temporal;
//		private BinaryReader br;
//		private BinaryWriter bw;
		private int nregs;
		bool encontrado;
		private string respuesta, codigo, cadena;
		static string[] campos = new string[7];
//		private bool regsEliminado=false;
//		private bool regsModificado=false;
		//Articulo articulo;
		//StreamWriter archivo;
		
		//CONSTRUCTOR
		public CListaArt()
<<<<<<< HEAD
=======
		{
			
		}
		
		public CListaArt(string fichero, char respuesta)
>>>>>>> origin/master
		{  
			escritura = File.AppendText(@"articulos.txt");
			escritura.Close();
		}
		
	//	public String execute() 
	//	{
	//		//openFile();
	//		return "success";
	//	}
		
		//public void CreaArchivo(string r) 
		//{
		//	archivo=new StreamWriter(r+".txt");
		//}
		
		//public void AbreAchivo(string n)
		//{
		//	archivo=File.AppendText(n+".txt");
		//}
		//public StreamWriter getArchivo()
		//{
		//	return archivo;
		//}
		
		
		public void Alta(string fi) {
			string cadena;
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("Codigo:");
			int cod=int.Parse(Console.ReadLine());
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
		
<<<<<<< HEAD
		public void crearArchivo(){
			escritura = File.AppendText("articulos.txt");
			escritura.Close();
		}
		
		public void altas(){
			encontrado = false;
			try{
				lectura = File.OpenText("articulos.txt");
				Console.Write("Ingrese el número de código del artículo: ");
				codigo = Console.ReadLine();
				cadena = lectura.ReadLine();
				//Buscamos para ver si no existe un código igual
				while(cadena != null){
					campos = cadena.Split('-');
					if(campos[0].Trim().Equals(codigo)){
					   	encontrado = true;
					   	break;
					}
					cadena = lectura.ReadLine();
				}
				lectura.Close();
				escritura = File.AppendText("Articulos.txt");
				if(encontrado == false){
					Console.Write("Nombre: ");
					String nom=Console.ReadLine();
					nom = nom.ToUpper();
					Console.Write("Marca: ");
					String mar=Console.ReadLine();
					mar = mar.ToUpper();
					Console.Write("Nombre del Proveedor :");
					String Nom_Prov=Console.ReadLine();
					Nom_Prov = Nom_Prov.ToUpper();
					Console.Write("Precio Minimo del Art.: ");
					double PreMin= Convert.ToDouble(Console.ReadLine());
					Console.Write("Precio Maximo del Art.: ");
					double PreMay=Convert.ToDouble(Console.ReadLine());					
					Console.Write("Stock: ");
					int sto=int.Parse(Console.ReadLine());					
					//Escribiendo los datos en el archivo
					escritura.WriteLine(codigo +"- " +nom +"- "+ mar +"- "+ Nom_Prov +"- "+ PreMin + "- " + PreMay +"- " + sto);
					Console.WriteLine("*******************************");
					Console.WriteLine("Registro agregado correctamente");
					Console.WriteLine("*******************************");	
				}else{
					Console.WriteLine("*************************************");
					Console.WriteLine("Ya existe un artículo con ese código " + codigo);
					Console.WriteLine("*************************************");
				}
				escritura.Close();
			}catch(FileNotFoundException fn){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + fn.Message);
				Console.WriteLine("*************************");
			}catch(Exception e){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + e.Message);
				Console.WriteLine("*************************");
			}finally{
				lectura.Close();
				escritura.Close();				
			}
		}
		
		//Creando el método bajas
		public void bajas(){
			encontrado = false;
			try{
				lectura = File.OpenText("articulos.txt");
				temporal = File.CreateText("tmp.txt");
				Console.WriteLine("Ingrese el número de código del artículo: ");
				codigo = Console.ReadLine();
				codigo = codigo.ToUpper();
				string cadena = lectura.ReadLine();
				while(cadena != null){
					campos = cadena.Split('-');
					if(campos[0].Trim().Equals(codigo)){
						encontrado = true;
						Console.WriteLine("******************************");
						Console.WriteLine("Codigo : " + campos[0]);
						Console.WriteLine("Nombre : " + campos[1]);
						Console.WriteLine("Marca : " + campos[2]);
						Console.WriteLine("Proveedor : " + campos[3]);
						Console.WriteLine("Precio Mínimo : " + campos[4]);
						Console.WriteLine("Precio Máximo : " + campos[5]);
						Console.WriteLine("Stock : " + campos[6]);
						Console.WriteLine("******************************");
						Console.WriteLine("Realmente deseas eliminarlo (SI/NO)?...");
						respuesta = Console.ReadLine();
						respuesta = respuesta.ToUpper();
						if(!respuesta.Equals("SI")){
						   	temporal.WriteLine(cadena);
						}					
					}else{
							temporal.WriteLine(cadena);
						}
					cadena = lectura.ReadLine();
				}
				if(encontrado == false){
					Console.WriteLine("*************************");
					Console.WriteLine("El artículo con el código "+codigo+" no se encuentra en la BD");
					Console.WriteLine("*************************");	
				}else if(respuesta.Equals("SI")){
					Console.WriteLine("**************************");
					Console.WriteLine("*** Artículo eliminado ***");
					Console.WriteLine("**************************");
				}else{
					Console.WriteLine("******************************************");
					Console.WriteLine("*** Operación de eliminación cancelada ***");
					Console.WriteLine("******************************************");
				}
				lectura.Close();
				temporal.Close();
				File.Delete("articulos.txt");
				File.Move("tmp.txt","articulos.txt");
			}catch(FileNotFoundException fn){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + fn.Message);
				Console.WriteLine("*************************");
			}catch(Exception e){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + e.Message);
				Console.WriteLine("*************************");
			}finally{
				lectura.Close();
				escritura.Close();				
			}
		}
		
		//Creando consultas
		public void consultar(){
			encontrado = false;
			try{
				lectura = File.OpenText("articulos.txt");
				Console.Write("Ingrese el código del artículo: ");
				codigo = Console.ReadLine();
				codigo.ToUpper();
				cadena = lectura.ReadLine();
				while(cadena != null){
					campos = cadena.Split('-');
					if(campos[0].Trim().Equals(codigo)){
						encontrado = true;
						Console.WriteLine("******************************");
						Console.WriteLine("*****Datos encontrados *****");
						Console.WriteLine();
						Console.WriteLine("Codigo : " + campos[0]);
						Console.WriteLine("Nombre : " + campos[1]);
						Console.WriteLine("Marca : " + campos[2]);
						Console.WriteLine("Proveedor : " + campos[3]);
						Console.WriteLine("Precio Mínimo : " + campos[4]);
						Console.WriteLine("Precio Máximo : " + campos[5]);
						Console.WriteLine("Stock : " + campos[6]);
						Console.WriteLine();
						Console.WriteLine("******************************");
					}
					cadena = lectura.ReadLine();						
				}
				if(encontrado == false){
						Console.WriteLine("******************************************");
						Console.WriteLine("*** No hay artículos con ese código "+codigo+" ***");
						Console.WriteLine("******************************************");
					}
				lectura.Close();
			}catch(FileNotFoundException fn){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + fn.Message);
				Console.WriteLine("*************************");
			}catch(Exception e){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + e.Message);
				Console.WriteLine("*************************");
			}finally{
				lectura.Close();				
			}
		}
		
		//Creando el método modificaciones
		public void modificar(){
			encontrado = false;
			byte opcionm;
			opcionm=0;
			string nuevoNombre, nuevaMarca, nuevoProv;
			double nuevoPremin, nuevoPremax;
			int nuevoStok;
			try{
				lectura = File.OpenText("articulos.txt");
				temporal = File.CreateText("tmp.txt");
				Console.Write("Ingrese el código del artículo: ");
				codigo = Console.ReadLine();
				codigo.ToUpper();
				cadena = lectura.ReadLine();
				while(cadena != null){
					campos = cadena.Split('-');
					if(campos[0].Trim().Equals(codigo)){
						encontrado = true;
						Console.WriteLine("******************************");
						Console.WriteLine("*****Datos encontrados *****");
						Console.WriteLine();
						Console.WriteLine("Codigo : " + campos[0].Trim());
						Console.WriteLine("Nombre : " + campos[1].Trim());
						Console.WriteLine("Marca : " + campos[2].Trim());
						Console.WriteLine("Proveedor : " + campos[3].Trim());
						Console.WriteLine("Precio Mínimo : " + campos[4].Trim());
						Console.WriteLine("Precio Máximo : " + campos[5].Trim());
						Console.WriteLine("Stock : " + campos[6].Trim());
						Console.WriteLine();
						Console.WriteLine("******************************");
						Console.Write("Es el registro que buscabas (SI/NO): ");
						respuesta = Console.ReadLine();
						respuesta = respuesta.ToUpper();
						Console.WriteLine("respuesta "+respuesta);
						if(respuesta.Equals("SI")){
							Console.WriteLine("Menú de opciones para modificar");
							Console.WriteLine("*******************************");
							Console.WriteLine("1. Nombre");
							Console.WriteLine("2. Marca");
							Console.WriteLine("3. Proveedor");
							Console.WriteLine("4. Precio Mínimo");
							Console.WriteLine("5. Precio Máximo");
							Console.WriteLine("6. Stock");
							Console.Write("Ingrese una respuesta: ");
							opcionm = Convert.ToByte(Console.ReadLine());
							switch(opcionm){
								case 1:
									Console.Write("Ingrese nuevo nombre: ");
									nuevoNombre = Console.ReadLine();
									nuevoNombre= nuevoNombre.ToUpper();
									temporal.WriteLine(campos[0] + "- "+nuevoNombre+ "-"+campos[2]+"-"+campos[3]+"-"+campos[4]+"-"+campos[5]+"-"+campos[6]);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								case 2:
									Console.Write("Ingrese la nueva marca: ");
									nuevaMarca = Console.ReadLine();
									nuevaMarca= nuevaMarca.ToUpper();
									temporal.WriteLine(campos[0] + "- "+campos[1]+ "-"+nuevaMarca+"-"+campos[3]+"-"+campos[4]+"-"+campos[5]+"-"+campos[6]);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								case 3:
									Console.Write("Ingrese nuevo proveedor: ");
									nuevoProv = Console.ReadLine();
									nuevoProv= nuevoProv.ToUpper();
									temporal.WriteLine(campos[0] + "- "+campos[1]+ "-"+campos[2]+"-"+nuevoProv+"-"+campos[4]+"-"+campos[5]+"-"+campos[6]);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								case 4:
									Console.Write("Ingrese nuevo precio mínimo: ");
									nuevoPremin = Convert.ToDouble(Console.ReadLine());									
									temporal.WriteLine(campos[0] + "- "+campos[1]+ "-"+campos[2]+"-"+campos[3]+"-"+nuevoPremin+"-"+campos[5]+"-"+campos[6]);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								case 5:
									Console.Write("Ingrese nuevo precio máximo: ");
									nuevoPremax = Convert.ToDouble(Console.ReadLine());									
									temporal.WriteLine(campos[0] + "- "+campos[1]+ "-"+campos[2]+"-"+campos[3]+"-"+campos[4]+"-"+nuevoPremax+"-"+campos[6]);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								case 6:
									Console.Write("Ingrese nuevo stock: ");
									nuevoStok = int.Parse(Console.ReadLine());									
									temporal.WriteLine(campos[0] + "- "+campos[1]+ "-"+campos[2]+"-"+campos[3]+"-"+campos[4]+"-"+campos[5]+"-"+nuevoStok);
									Console.WriteLine("*****************************************");
									Console.WriteLine("*** Registro modificado correctamente ***");
									Console.WriteLine("*****************************************");
									break;
								default:
									Console.WriteLine("*************************");
									Console.WriteLine("*** Opción incorrecta ***");
									Console.WriteLine("*************************");
									break;
							}
						}else{
							temporal.WriteLine(cadena);
						}
					}else{
						temporal.WriteLine(cadena);
					}
					cadena = lectura.ReadLine();						
				}
				if(encontrado == false){
					Console.WriteLine("*******************************************************");
					Console.WriteLine("*** El código ingresado no está en la base de datos ***");
					Console.WriteLine("*******************************************************");
				}
				lectura.Close();
				temporal.Close();
				File.Delete("articulos.txt");
				File.Move("tmp.txt","articulos.txt");
			}catch(FileNotFoundException fn){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + fn.Message);
				Console.WriteLine("*************************");
			}catch(Exception e){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + e.Message);
				Console.WriteLine("*************************");
			}finally{
				lectura.Close();
				temporal.Close();
			}
		}
		
		//Creando el método consulta general
		public void consultagral(){
			encontrado = false;
			try{
				lectura = File.OpenText("articulos.txt");
				cadena = lectura.ReadLine();				
				while(cadena != null){
					encontrado=true;
					campos = cadena.Split('-');
					Console.WriteLine("******************************");
					Console.WriteLine("*****Datos encontrados *****");
					Console.WriteLine();
					Console.WriteLine("Codigo : " + campos[0].Trim());
					Console.WriteLine("Nombre : " + campos[1].Trim());
					Console.WriteLine("Marca : " + campos[2].Trim());
					Console.WriteLine("Proveedor : " + campos[3].Trim());
					Console.WriteLine("Precio Mínimo : " + campos[4].Trim());
					Console.WriteLine("Precio Máximo : " + campos[5].Trim());
					Console.WriteLine("Stock : " + campos[6].Trim());
					Console.WriteLine();
					Console.WriteLine("******************************");
					cadena = lectura.ReadLine();
				}
				if(encontrado == false){
					Console.WriteLine("********************************");
					Console.WriteLine("No artículos en la base de datos");
					Console.WriteLine("********************************");	
				}
				lectura.Close();
			}catch(FileNotFoundException fn){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + fn.Message);
				Console.WriteLine("*************************");
			}catch(Exception e){
				Console.WriteLine("*************************");
				Console.WriteLine("Error!! " + e.Message);
				Console.WriteLine("*************************");
			}finally{
				lectura.Close();		
			}
		}
=======
		public String PasarLinea(Articulo arti)
		{
			String l = "";
			l=l+arti.SGCodigo+"-"+arti.SGNombre+"-"+arti.SGMarca+"-"+arti.SGNom_Provee+"-";
			l=l+arti.SGMinorista+"-"+arti.SGMayorista+"-"+arti.SGStock;
			return l;
		}
	
>>>>>>> origin/master
	}
}
