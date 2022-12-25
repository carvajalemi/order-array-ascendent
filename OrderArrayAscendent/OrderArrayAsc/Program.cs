using System;

class Program {
static void Main(string[] args)
{
  int[] numeros = { 15, 1, 34, 5, 90, 10, 6 };
  Console.WriteLine("Antes de ordenar");
  foreach (int numero in numeros)
  {
    Console.Write(numero + ",");
  }
  Console.WriteLine("");
  ordenarBurbujaAscendente(numeros);
  Console.WriteLine("Después de ordenar ascendente");
  foreach (int numero in numeros)
  {    
    Console.Write(numero + ",");
  }
  Console.WriteLine();
}
static void ordenarBurbujaAscendente(int[] array)
{
     for (int x = 0; x < array.Length; x++)
     {
        for (int indiceActual = 0; indiceActual < array.Length - x -1;indiceActual++)
        {
          int indiceSiguienteElemento = indiceActual + 1;
          // Si el actual es mayor que el que le sigue a la derecha...
          if (array[indiceActual] > array[indiceSiguienteElemento])
           {
              int temporal = array[indiceActual];
              array[indiceActual] = array[indiceSiguienteElemento];
               array[indiceSiguienteElemento] = temporal;
            }
         }
      }   
}
}