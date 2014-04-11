/*
 * Created by SharpDevelop.
 * User: krlos
 * Date: 04/04/2014
 * Time: 09:52 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace practica_4_productos
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i=0;
			String rutaArchivo = "productos.csv";
			Console.WriteLine("1.-Nuevo producto");
			Console.WriteLine("2.-Ver productos");
			Console.WriteLine("3.-Salir");
			int opc = int.Parse(Console.ReadLine());
			
			if(opc==1){
				             
				Console.WriteLine("Código");
				String codigo=Console.ReadLine();
				
				Console.WriteLine("Nombre");
				String nombre=Console.ReadLine();
				
				Console.WriteLine("Precio");
				String precio=Console.ReadLine();
				
				String registro=codigo+","+nombre+","+precio;
				
				Archivo archivo=new Archivo(rutaArchivo);
				archivo.escribir(registro);
				
			}else if(opc ==2){
				if( System.IO.File.Exists ( rutaArchivo))
					{
						// Se indica el archivo a leer
						StreamReader lector=new StreamReader (rutaArchivo);

						// Lee la primera linea del archivo
						String linea=lector.ReadLine ();
						// Continua leyendo Hasta Que se terminación el archivo
						while (linea != null)
						{
							string[] partes = linea.Split(',');
							// Escribe la linea en la consolación
							Console.WriteLine ( "Codigo: " + partes[0] );
							
							Console.WriteLine ( "Nombre: " + partes[1] );
							
							Console.WriteLine ( "Precio: " + partes[2] );
							Console.WriteLine();
							Console.WriteLine();
							
							// Lee la siguiente linea
							linea= lector .ReadLine ();
							
						}
						Console.ReadLine();
				}else{
					Console.WriteLine("No EXISTE el Archivo");
				}
			}else if(opc==3){
				Console.WriteLine("Salir");
			}
				
			}
			// TODO: Implement Functionality Here
			
		}
	}