using System;
using System.IO;
using System.Text;


namespace Acesso{

  class MainClass {

    public static void Main (string[] args) {

      int Cadastrar;

      dataPets CadPets = new dataPets("ESPECIE","RAÇA","CIDADE","PORTE");
      dataUser CadUser = new dataUser("Nome", "Telefone", "cidade","Email");

      string [,] DBUser = new string [1000,4];

      DBUser[0,0] = CadUser.Nome;
      DBUser [0,1] = CadUser.Telefone;
      DBUser[0,2] = CadUser.Localidade;
      DBUser[0,3] = CadUser.Email;

      string [,] DBPets = new string [1000,4];

      DBPets[0,0] = CadPets.Especie;
      DBPets [0,1] = CadPets.Raca;
      DBPets[0,2] = CadPets.Localidade;
      DBPets[0,3] = CadPets.Porte;

      StreamWriter DataSet;
      StreamReader Auth;
      StreamWriter Doador;
      StreamReader Adotante;

      Console.WriteLine ("Possui Cadastro em nosso sistema? ");
      Console.WriteLine("Digite \n 1 - NÃO \n 2 - SIM");
      Cadastrar = int.Parse(Console.ReadLine());

      switch(Cadastrar){
        case 1:
            DataSet = File.AppendText("usuarios.txt");
            Console.WriteLine("Digite seu Nome: \n");
            CadUser.Nome = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Nome);

            Console.WriteLine("Telefone para contato: \n");
            CadUser.Telefone = Console.ReadLine();
            DataSet.WriteLine(CadUser.Telefone);

            Console.WriteLine("Digite o nome da sua cidade: \n");
            CadUser.Localidade = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Localidade);

            Console.WriteLine("E-mail: \n");
            CadUser.Email = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Email);

            Console.WriteLine("Obrigado por se Cadastrar! ");


            DataSet.Close();
          break;
            
        case 2:
            Auth = File.OpenText("usuarios.txt");
            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            CadUser.Telefone = Console.ReadLine();


            while(Auth.EndOfStream != true){
              string linha = Auth.ReadLine();
              if(linha.Contains(CadUser.Telefone)){
                Console.WriteLine("Dados confirmados! \n Seja bem vindo ao My Pet!");
              }
              
            }
             
              Auth.Close();
          break;  
          }  

      Console.WriteLine("Gostaria de Doar ou Adotar um Pet? ");
      Console.WriteLine("Digite: \n 1 - DOAR \n 2 - ADOTAR");
      Cadastrar = int.Parse(Console.ReadLine());
      switch(Cadastrar){
        case 1:

            Doador = File.AppendText("doador.txt");

            Console.WriteLine("Digite a espécie? GATO ou CACHORRO: ");
            CadPets.Especie = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Especie);

            Console.WriteLine("Qual a raça? ");
            CadPets.Raca = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Raca);

            Console.WriteLine("Cidade do Doador");
            CadPets.Localidade = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Localidade);

            Console.WriteLine("Qual o porte? \n PEQUENO \n MEDIO \n GRANDE");
            CadPets.Porte = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Porte);

            Console.WriteLine("Pet Cadastrado. Daremos o melhor cuidado! ");

            Doador.Close();

          break;

        case 2: 

            Adotante = File.OpenText("doador.txt");

            Console.WriteLine("Prefere GATO ou CACHORRO? - Digite sua escolha");
            CadPets.Especie = Console.ReadLine().ToUpper();

            Console.WriteLine("Raça preferida: ");
            CadPets.Raca = Console.ReadLine().ToUpper();

            Console.WriteLine("Nome da Cidade que procura o Pet: ");
            CadPets.Localidade = Console.ReadLine().ToUpper();

            Console.WriteLine("Porte: PEQUENO - MEDIO - GRANDE ? ");
            CadPets.Porte = Console.ReadLine().ToUpper();

            for(int i = 0;i <DBPets.Length;i++){
              for(int j = 0; j<DBPets.Length;j++){
                if(DBPets[i,j].ToString() == CadPets.Especie && DBPets[i,j].ToString() == CadPets.Raca){
                  Console.WriteLine("Pet Encontrado!");
                  Console.WriteLine("Entraremos em contato para agendar a adoção! ");
                  Console.WriteLine("Parabéns por escolher cuidar!");
                }

              }
            }
            Adotante.Close();
          break;  
            }
            
      }    
    }
  }
  


