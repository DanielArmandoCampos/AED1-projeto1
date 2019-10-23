class dataPets {

  public string Especie;
  public string Raca;
  public string Localidade;
  public string Porte;

  public void setEspecie(string Esp){
    Especie = Esp;
  }

  public string getEspecie(){
    return Especie;
  }

  public void setRaca(string Rac){
    Raca = Rac;
  }

  public string getRaca(){
    return Raca;
  }

  public void setLocalidade(string Loc){
    Localidade = Loc;
  }

  public string getLocalidade(){
    return Localidade;
  }

  public void setPorte(string Pt){
    Porte = Pt;
  }

  public string getPorte(){
    return Porte;
  }


  public dataPets(string Espe, string Race, string Local, string Por){

    Especie = Espe;
    Raca = Race;
    Localidade = Local;
    Porte = Por;

  }
}

