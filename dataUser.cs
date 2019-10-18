class dataUser{

  public string Nome;
  public string Telefone;
  public string Localidade;

  public void setNome(string N){
    Nome = N;
  }

  public string getNome(){
    return Nome;
  }

  public void setTelefone(string Tel){
    Telefone = Tel;
  }

  public string getTel(){
    return Telefone;
  }

  public void setLocalidade(string Loc){
    Localidade = Loc;
  }

  public string getLocalidade(){
    return Localidade;
  }

  public dataUser (string N, string Tel, string Loc){
    Nome = N;
    Telefone = Tel;
    Localidade = Loc;
  }
}