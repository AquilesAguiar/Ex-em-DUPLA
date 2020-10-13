using System;

class Aeronave {
  //Atributos
  string NomeAeronave;
  int CapacidadeTanqueCombustivel;
  int NivelCombustivelAtual;
  int QtdPassageiros;
  int AutonomiaAeronave;
  int HorasDeVoo;
  string NomePiloto;
  string AeroportoAtual;


  //Verifica o Abastecimento da Aeronave
  public int AbastecerAeronave(){
    if (NivelCombustivelAtual < CapacidadeTanqueCombustivel){
      return CapacidadeTanqueCombustivel-NivelCombustivelAtual;
    }
    else{
      return CapacidadeTanqueCombustivel;
    }
  }
  
  //Calcula o Vôo da aeronave
  public int Voar(int distancia) {
    if (distancia <= AutonomiaAeronave) {
      HorasDeVoo += distancia;
    }
    return HorasDeVoo;
  }

  //GET's / SET's
  public void SetNomePiloto (string NovoNome) {
    NomePiloto = NovoNome;
  }
  
  public string GetNomePiloto () {
    return NomePiloto;
  }

  public void SetAeroportoAtual (string NovoAeroporto) {
    AeroportoAtual = NovoAeroporto;
  }

  public string GetAeroportoAtual () {
    return AeroportoAtual;
  }


  //Construtores

  //Construtor Vazio
  public Aeronave(){
    NomeAeronave = "Airbus A380";
    CapacidadeTanqueCombustivel = 16383;
    NivelCombustivelAtual = 10000;
    QtdPassageiros = 112;
    AutonomiaAeronave = 1200;
    HorasDeVoo = 30000;
    NomePiloto = "Edinaldo Perereira";
    AeroportoAtual ="Guarulhos";
    
  }

  //Construtor Completo
  public Aeronave (string NomeAero, int CapCombusti, int NivelcomblAtual, int QtdPs, int AutoAero, int HorasVoo, string NomePilot, string AeroAtual) {
    
    NomeAeronave = NomeAero;
    CapacidadeTanqueCombustivel = CapCombusti;
    NivelCombustivelAtual = NivelcomblAtual;
    QtdPassageiros = QtdPs;
    AutonomiaAeronave = AutoAero;
    HorasDeVoo = HorasVoo;
    NomePiloto = NomePilot;
    AeroportoAtual = AeroAtual;
    
  }
}