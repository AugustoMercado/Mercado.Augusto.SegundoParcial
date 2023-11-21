﻿using PrimerParcial;



/// <summary>
/// Dlegado para mostrar mensaje.
/// </summary>
/// <param name="mensaje">mensaje que se va a mostrar</param>
public delegate void Mensaje(string mensaje);


/// <summary>
/// Delegado para llamar a los metodos de las clases hijas.
/// </summary>
/// <param name="cadena">conexion a la base</param>
/// <param name="lista">donde se van a guardar los personajes</param>
/// <returns>retorna una lista con los personajes</returns>
public delegate Ejercito Datos(string cadena, Ejercito lista);

/// <summary>
/// Delegado para llamar a Datos.
/// </summary>
public delegate void ObtenerDatos();