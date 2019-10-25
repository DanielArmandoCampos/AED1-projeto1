using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Acesso{

  class MainClass {



    public static bool verifTel(string telefone){
      StreamReader Auth;
      Auth = File.OpenText("usuarios.txt");

      string linha;

      while(Auth.EndOfStream != true){
        linha = Auth.ReadLine();
        if(linha.Contains(telefone)){
          return true;

        }

      }

      Auth.Close();

      return false;
    }

    public static void Main (string[] args) {

      int Cadastrar;

      StreamWriter DataSet;
      StreamWriter Doador;
      StreamWriter Adotante;

      List<string> contaAdocao = new List<string>();
      List<string> contaDoacao = new List<string>();

      dataPets CadPets = new dataPets("ESPECIE","RAÇA","CIDADE","PORTE");
      dataUser CadUser = new dataUser("Nome", "Telefone", "cidade","Email");


      Console.WriteLine("Olá! Seja bem vindo ao MyPet! \n");

      Console.WriteLine ("Já possui cadastro? ");
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
            string x;

            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            x = Console.ReadLine();

            if(verifTel(x)) {
              
              Console.WriteLine("Telefone encontrado");

            } 
            else{

              Console.WriteLine("Telefone não encontrado");
              while(verifTel(x)== false){
                Console.WriteLine("Digite novamente: ");
                x = Console.ReadLine();
              }
            }

          break;

          }

      
      int s;

      Console.WriteLine("Gostaria de Adotar ou Doar um Pet? \n Digite: 1 - DOAR  2 - ADOTAR");
      s = int.Parse(Console.ReadLine());

      switch(s){

        case 1:

            Doador = File.AppendText("doador.txt");

            Console.WriteLine("Digite a espécie? GATO ou CACHORRO: ");
            CadPets.Especie = Console.ReadLine().ToUpper();
            contaDoacao.Add(CadPets.Especie);
            Doador.WriteLine(CadPets.Especie);

            Console.WriteLine("Qual a raça? ");
            CadPets.Raca = Console.ReadLine().ToUpper();
            contaDoacao.Add(CadPets.Raca);
            Doador.WriteLine(CadPets.Raca);

            Console.WriteLine("Cidade do Doador");
            CadPets.Localidade = Console.ReadLine().ToUpper();
            contaDoacao.Add(CadPets.Localidade);
            Doador.WriteLine(CadPets.Localidade);

            Console.WriteLine("Qual o porte? \n PEQUENO \n MEDIO \n GRANDE");
            CadPets.Porte = Console.ReadLine().ToUpper();
            contaDoacao.Add(CadPets.Porte);
            Doador.WriteLine(CadPets.Porte);
            
            Console.WriteLine("Pet Cadastrado. Daremos ao PET o melhor cuidador! ");

            Doador.Close();

          break;

        case 2: 

            Adotante = File.AppendText("adotante.txt");

            Console.WriteLine("Prefere GATO ou CACHORRO? - Digite sua escolha");
            CadPets.Especie = Console.ReadLine().ToUpper();
            contaAdocao.Add(CadPets.Especie);
            Adotante.WriteLine(CadPets.Especie);

            Console.WriteLine("Raça preferida: ");
            CadPets.Raca = Console.ReadLine().ToUpper();
            Adotante.WriteLine(CadPets.Raca);
            contaAdocao.Add(CadPets.Raca);

            Console.WriteLine("Nome da Cidade que procura o Pet: ");
            CadPets.Localidade = Console.ReadLine().ToUpper();
            Adotante.WriteLine(CadPets.Localidade);
            contaAdocao.Add(CadPets.Localidade);

            Console.WriteLine("Porte: PEQUENO - MEDIO - GRANDE ? ");
            CadPets.Porte = Console.ReadLine().ToUpper();
            Adotante.WriteLine(CadPets.Porte);
            contaAdocao.Add(CadPets.Porte);

            Console.WriteLine("Obrigado por Adotar! Cuide bem do seu Pet");           

            Adotante.Close();
          break;  
        }

      if(CadUser.Telefone == "27999959595"){
        int opcao;

        Console.WriteLine("Deseja acessar o banco de dados? ");
        Console.WriteLine("1 - SIM \n 2 - NÃO");

        opcao = int.Parse(Console.ReadLine());
      
        switch(opcao){
          case 1:

            int filter;

            Console.WriteLine("Abrir:  1 - LISTA DE ADOÇÃO \n 2 - DOAÇÃO ");
            filter = int.Parse(Console.ReadLine());

            if(filter == 1){
              
              int Count = 0;

              foreach(var i in contaAdocao){

                Console.WriteLine("Filtrar qtd por espécie: 1 - GATO 2 - CACHORRO");
                CadPets.Especie = Console.ReadLine().ToUpper();
                  if(i == CadPets.Especie){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");  
                
                Console.WriteLine("Filtrar qtd por Raça: ");
                CadPets.Raca = Console.ReadLine().ToUpper();
                  if(i == CadPets.Raca){
                    Count++;
                  }

                 Console.WriteLine(Count + " encontrados");  

                Console.WriteLine("Filtrar qtd por Cidade: ");
                CadPets.Localidade = Console.ReadLine().ToUpper();
                  if(i == CadPets.Localidade){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");  



                Console.WriteLine("Filtrar qtd por Porte: ");
                CadPets.Porte = Console.ReadLine().ToUpper();
                  if(i == CadPets.Localidade){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");

              }
              

            }
          break;  

            if(filter == 2){
              int Count = 0;

              foreach(var i in contaAdocao){
                Console.WriteLine("Filtrar qtd por espécie: 1 - GATO 2 - CACHORRO");
                CadPets.Especie = Console.ReadLine().ToUpper();
                  if(i == CadPets.Especie){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");  
                
                Console.WriteLine("Filtrar qtd por Raça: ");
                CadPets.Raca = Console.ReadLine().ToUpper();
                  if(i == CadPets.Raca){
                    Count++;
                  }

                 Console.WriteLine(Count + " encontrados");  

                Console.WriteLine("Filtrar qtd por Cidade: ");
                CadPets.Localidade = Console.ReadLine().ToUpper();
                  if(i == CadPets.Localidade){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");  



                Console.WriteLine("Filtrar qtd por Porte: ");
                CadPets.Porte = Console.ReadLine().ToUpper();
                  if(i == CadPets.Localidade){
                    Count++;
                  }

                Console.WriteLine(Count + " encontrados");

              }
              

            }
          break; 


          case 2:
            Console.Clear();

            Console.WriteLine("Obrigado por usar nosso sistema!");
            Console.WriteLine("Até logo! ");
            
          break;

            }

          
        }

          
      }
            
      }    
    }
  
  


