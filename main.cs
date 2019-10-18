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
                Console.WriteLine("Dados confirmados! \n Seja bem vindo ao My Pet");
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
            Console.WriteLine("Digite a espécie? GATO \n CACHORRO: ");
            dataPets.Especie = Console.ReadLine().ToUpper();
            Console.WriteLine("Qual a raça? ");
            dataPets.Raca = Console.ReadLine().ToUpper();
            Console.WriteLine("Idade do Pet: ");
            dataPets.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Cidade do Doador");
            dataPets.Localidade = Console.ReadLine().ToUpper();
            Console.WriteLine("Qual o porte? \n PEQUENO \n MEDIO \n GRANDE");
            dataPets.Porte = Console.ReadLine().ToUpper;


            Doador.Close();

          break;

        case 2: 

            GotAPet = File.AppendText("doador.txt");
            Console.WriteLine("Quer adotar gato ou cachorro? ");
            string tipoPet = GotAPet.ReadLine().ToUpper();
            while(GotAPet.EndOfStream != true){
              Console.WriteLine(tipoPet.Contains(dataPets.Especie));
            }
            
      }    
    }
  }
}  


