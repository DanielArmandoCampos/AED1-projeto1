using System;
using System.IO;
using System.Text;

namespace Acesso{

  class MainClass {

    public static void Main (string[] args) {

      int Cadastrar;
      FileStream DataSet = new FileStream ("usuarios.txt", FileMode.Open);
      //FileStream Doador = new FileStream("doador.txt", FileMode.Open);
      //FileStream Adotante = new FileStream("adotante.txt", FileMode.Open);
      dataUser CadUser = new dataUser("Nome", 0, "Telefone", "cidade");

      Console.WriteLine ("Possui Cadastro em nosso sistema? ");
      Console.WriteLine("Digite \n 1 - Não \n 2 - Sim");
      Cadastrar = int.Parse(Console.ReadLine());

      switch(Cadastrar){
        case 1:
          if(File.Exists("usuarios.txt")){
            Console.WriteLine("Digite seu Nome: \n");
            CadUser.Nome = Console.ReadLine().ToLower();
            string nomeUsuario = CadUser.Nome;
            byte[] info = new UTF8Encoding(true).GetBytes(nomeUsuario);
            DataSet.Write(info);
            Console.WriteLine("Sua idade: \n");
            CadUser.Idade = int.Parse(Console.ReadLine());
            //int idadeUsuario = CadUser.Idade;
            //byte[] info1 = idadeUsuario.ConvertToByte(string);
            //DataSet.Write(info1);
            Console.WriteLine("Telefone para contato: \n");
            CadUser.Telefone = Console.ReadLine();
            string telUsuario = CadUser.Telefone;
            byte[] info2 = new UTF8Encoding(true).GetBytes(telUsuario);
            DataSet.Write(info2);
            Console.WriteLine("Digite o nome da sua cidade: \n");
            CadUser.Localidade = Console.ReadLine().ToLower();
            string locUsuario = CadUser.Localidade;
            byte[] info3 = new UTF8Encoding(true).GetBytes(locUsuario);
            DataSet.Write(info3);
          }
          break;
        case 2:
          if(File.Exists("usarios.txt")){
            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            CadUser.Telefone = Console.ReadLine();
            Stream AuthUser = File.Open("usuarios.txt", FileMode.Open);
            StreamReader Auth = new StreamReader(AuthUser);
            string linha = Auth.ReadLine();
             
            }
          break;  
          }  
      }

    }
  }


