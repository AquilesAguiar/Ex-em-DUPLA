using System;

//Exercicio Feito Por: Caio Machado e Aquiles Aguiar

class MainClass {
  public static void Main () {
    // instanciação
    Aeronave Batwing = new Aeronave("Batwing",16203,10000,10,5000,30000,"Batman","Batcaverna - Gotham City");

    //Execução do método Voar
    Console.WriteLine($"Horas de vôo com a distância de 3000 >> {Batwing.Voar(3000)} KM");

  }
}