using System;
using System.IO;
using System.Text;

namespace Acesso{

  class MainClass {

    public static void Main (string[] args) {

      int Cadastrar;
      StreamWriter DataSet;
      StreamReader Auth;
      //StreamWriter Doador = new StreamWriter("doador.txt", FileMode.Open);
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
              Console.WriteLine(linha);

            }
             
              Auth.Close();
          break;  
          }  
      }

    }
  }


