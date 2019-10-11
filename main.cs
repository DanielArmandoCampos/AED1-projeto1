using System;
using static System.IO.FileStream;

namespace Acesso{

  class MainClass {

    public static void Main (string[] args) {

      FileStream data_set = new FileStream ("dados.txt", FileMode.Open,FileAccess.Read);
      StreamReader data_read = new StreamReader(data_set, Encoding.UTF8);
      dataUser CadDoador = new dataUser("Nome", 0, "Telefone", "cidade");

      Console.WriteLine ("Possui Cadastro em nosso sistema? ");
      Console.WriteLine("Digite \n 1 - Não e 2 - Sim");

      switch(cadastrar){
        case 1:
          Console.WriteLine("Digite seu Nome");
          CadDoador.Nome = Console.ReadLine().ToLower();
          StreamWriter(data_set) = CadDoador.Nome;
          Console.WriteLine("Sua idade: ");
          CadDoador.Idade = int.Parse(Console.ReadLine());
          StreamWriter(data_set) = CadDoador.Idade;
          Console.WriteLine("Telefone para contato: ");
          CadDoador.Telefone = Console.ReadLine();
          StreamWriter(data_set) = CadDoador.Telefone;
          Console.WriteLine("Digite o nome da sua cidade: ");
          CadDoador.Localidade = Console.ReadLine().ToLower();
          StreamWriter(data_set) = CadDoador.Localidade; 

      }

    }
  }
}

