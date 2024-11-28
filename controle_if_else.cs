using System;

class Program {
  public static void Main (string[] args) {
    int n;

    Console.WriteLine("Informe o número: ");
    n = int.Parse(Console.ReadLine());
    
    if (n > 0){
      Console.WriteLine("O número é positivo.");
    }
    else if (n == 0){
      Console.WriteLine("O número é neutro.");
    }

    else {
      Console.WriteLine("O número é negativo.");
    }
  }
}
