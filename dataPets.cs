class dataPets {

  private string Especie;
  private string Raca;
  private int Idade;
  private string Localidade;
  private string Porte;

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

  public void setIdade(int Age){
    Idade = Age;
  }

  public int getIdade(){
    return Idade;
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


  public dataPets(string Espe, string Race, int age, string Local, string Por){

    Especie = Espe;
    Raca = Race;
    Idade = age;
    Localidade = Local;
    Porte = Por;

  }
}

