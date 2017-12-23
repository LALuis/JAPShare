

En esta carpeta se pueden incluir funciones auxiliares que podremos llamar tanto desde la Capa Presentacion
La idea es declararlas TODAS como Static, para de esta forma, no tener necesidad de instanciar y simplemente accedemos
digitando el nombre de la clase + "." + la funcion correspondiente. 

como desde la capa logica.

FIJENSE que NO se podran incluir funciones que manipulen modelos, ya que la capa logica no sabe lo que es
por ejemplo: un UsuarioModel

Un ejemplo de las funciones que podriamos agregar es

public static bool ContrasenaSegura(string contrasena)
{
	/*Esta funcion recibe una contraseña y analiza con por ejemplo funciones regulares
	si cumple con las condiciones de seguridad que deseamos*/
}