class dataUser{

  public string Nome;
  public int Idade;
  public string Telefone;
  public string Localidade;

  public void setNome(string N){
    Nome = N;
  }

  public string getNome(){
    return Nome;
  }

  public void setIdade(int Age){
    Idade = Age;
  }

  public int getAge(){
    return Idade;
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

  public dataUser (string N, int Age, string Tel, string Loc){
    Nome = N;
    Idade = Age;
    Telefone = Tel;
    Localidade = Loc;
  }
}