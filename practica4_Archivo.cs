/*
 * Created by SharpDevelop.
 * User: krlos
 * Date: 04/04/2014
 * Time: 12:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace practica_4_productos
{
	/// <summary>
	/// Description of Archivo.
	/// </summary>
	public class Archivo
	{
		private string path;

		public Archivo (String path)
		{
			this.path = path;
		}

		public void setPath(String path){
			this.path = path;
		}

		public void leer(){
			String linea;
			try 
				{
					if(System.IO.File.Exists(this.path))
					{
						//Se indica el archivo a leer
						StreamReader lector = new StreamReader(this.path);

						//Lee la primera linea del archivo
						linea = lector.ReadLine();

						//Continua leyendo hasta que se termina el archivo
						while (linea != null) 
						{
							//Escribe la linea en la consola
							Console.WriteLine(linea);
							//Lee la siguiente linea
							linea = lector.ReadLine();
						}

						//cierra el lector
						lector.Close();
						Console.ReadLine();
					}
					else
					{
						Console.WriteLine("No existe el archivo.");
					}
				}
				catch(Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			   	finally 
				{
					Console.WriteLine("Cerrando la lectura.");
				}
		}

		public void escribir(String contenido){
			try 
			{

				//Se indica el archivo a escribir
				StreamWriter escritor = new StreamWriter(this.path, true);
				escritor.WriteLine(contenido);
				
				//Cierra escritor
				escritor.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Cerrando la escritura.");
			}
		}
	}
}
