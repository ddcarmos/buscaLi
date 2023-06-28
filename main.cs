using System;

class Program {
  public static void Main (string[] args) {
    int[] elementos = new int[] {2, 3, 3, 4, 6, 8, 7, 9};
    
    int pow = buscar(elementos, 14);
    Console.WriteLine ("Retorna posição " + pow);
  }
  
  public static int buscar (int[] elementos, int valor){
    for(int i =0;i <elementos.Length;i++){
        if(elementos[i] == valor)
           return i;
    }
     return -1;
  }
}