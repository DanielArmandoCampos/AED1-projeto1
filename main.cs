using System;
using System.IO;
using System.Text;

namespace Acesso{

  class MainClass {

    public static void Main (string[] args) {

      int Cadastrar;
      StreamWriter DataSet;
      StreamReader Auth;
      StreamReader GotAPet;
      StreamWriter Doador;
      dataPets CadPets = new dataPets("ESPECIE","RAÇA",0,"CIDADE","PORTE");
      //StreamWriter Adotante = new StreamWriter("adotante.txt", FileMode.Open);
      dataUser CadUser = new dataUser("Nome", "Telefone", "cidade");

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
            Console.WriteLine("Obrigado por se Cadastrar! ");


            DataSet.Close();
          break;
            
        case 2:
            Auth = File.OpenText("usuarios.txt");
            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            CadUser.Telefone = Console.ReadLine();
            //string linha = Auth.ReadLine();

            while(Auth.EndOfStream != true){
              string linha = Auth.ReadLine();
              if(linha.Contains(CadUser.Telefone)){
                Console.WriteLine("Dados confirmados! \n Seja bem vindo ao My Pet!");
              }
              //Console.WriteLine(linha.Contains(CadUser.Telefone));

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
            Console.WriteLine("Idade do Pet: ");
            CadPets.Idade = int.Parse(Console.ReadLine());
            Doador.WriteLine(CadPets.Idade);
            Console.WriteLine("Cidade do Doador");
            CadPets.Localidade = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Localidade);
            Console.WriteLine("Qual o porte? \n PEQUENO \n MEDIO \n GRANDE");
            CadPets.Porte = Console.ReadLine().ToUpper();
            Doador.WriteLine(CadPets.Porte);
            Console.WriteLine("Pet Cadastrado. Daremos o melhor cuidado! ");

            Doador.Close();

          break;

        /*case 2: 

            GotAPet = File.AppendText("doador.txt");
            Console.WriteLine("Quer adotar gato ou cachorro? ");
            string tipoPet = GotAPet.ReadLine().ToUpper();
            while(GotAPet.EndOfStream != true){
              Console.WriteLine(tipoPet.Contains(dataPets.Especie));
            }*/
            
      }    
    }
  }
}  


