using ByteBank.Funcionarios;
using ByteBank.Funcionarios.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            // CalcularBonificacao();


            UsarSistema();
            Console.ReadLine();
        }


        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");

            sistemaInterno.Logar(camila, "abc");




        }

        public static void CalcularBonificacao()
        {

        
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();



            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta =  new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-39");
            igor.Nome = "Pedro";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

// ESTUDO


/*  GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

  Funcionario carlos = new Funcionario(2000, "455.654.123-74");

  carlos.Nome = "Carlos";

  carlos.AumentarSalario(); // aqui eu estou aumentando o salario do Carlos de 2000 para 2200

  Console.WriteLine("O total de funcionários com o Carlos é: "  + Funcionario.TotalDeFuncionarios);
  Console.WriteLine("Novo salário do carlos : " + carlos.Salario);


  gerenciador.Registrar(carlos);

  // Funcionario Pedro = new Diretor();       AGORA POSSO CRIAR UM NOVO FUNCIONARIO MAS PASSANDO COMO DIRETOR POIS O DIRETOR É UM FUNCIONARIO 


  Diretor roberta = new Diretor("788.777.456-78");
  roberta.Nome = "Roberta";



 Funcionario robertaTeste = roberta;
  roberta.AumentarSalario();
  Console.WriteLine("O total de funcionários com a roberta agora é: " + Funcionario.TotalDeFuncionarios);

  Console.WriteLine("O novo salário de Roberta é : " + roberta.Salario);

  Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());

  Console.WriteLine("Bonificação de uma referência de diretor: " + roberta.GetBonificacao());
  Console.WriteLine("O salário de Roberta é: " + roberta.Salario);



  gerenciador.Registrar(roberta);

 Console.WriteLine(carlos.Nome);
  Console.WriteLine(carlos.CPF);
  Console.WriteLine(carlos.Salario);

  Console.WriteLine("O nome do carlos é: " + carlos.Nome);
  Console.WriteLine("A bonificação de carlos é: " + carlos.GetBonificacao());

  Console.WriteLine("O nome de Roberta é: " + roberta.Nome);
  Console.WriteLine("A bonificação de Roberta é: " + roberta.GetBonificacao());

  Console.WriteLine("O Total de Bonificações: " + gerenciador.GetTotalBonificacao());

  */
