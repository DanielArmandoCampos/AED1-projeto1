class dataCuidador{

  private string Nome;
  private int Idade;
  private string Documento;
  private string Telefone;
  private string Endereco;

  public void setNome(string N){
    Nome = N;
  }

  public string getNome{
    return N;
  }

  public void setIdade(int Age){
    Idade = Age;
  }

  public string getAge{
    return Age;
  }

  public void setDocumento(string DOC){
    Documento = DOC;
  }

  public string getDOC(){
    return DOC; 
  }

  public void setTelefone(string Tel){
    Telefone = Tel;
  }

  public string getTel(){
    return Tel;
  }

  public void setEndereco(string End){
    Endereco = End;
  }

  public string getEnd(){
    return End;
  }

  public dataCuidador (string N, int Age, string DOC, string Tel, string End){
    N = "Nome do cuidador";
    Age = 0;
    DOC = "Número do documento de identificação do Cuidador";
    Tel = "Telefone para Contato";
    End = "Endereço do Cuidador";
  }
}