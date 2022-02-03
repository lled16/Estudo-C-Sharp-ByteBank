using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class  Funcionario
    {
        
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string  CPF {get; private set; }
        public double Salario { get;  protected set; } // a palavra reservada PROTECTED informa que o Salario esta protegido, mas que ele pode ser acessado por classes derivadas, nesse caso a classe DIRETOR, mas protege para que não tenha como inserir um salário inicial manualmente na classe PROGRAM, ao criar um usuário
        

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando um funcionário...");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario(); 
       

        public abstract double GetBonificacao();  
       
    }
}
// o VIRTUAL diz ao C# que esse método PODE ser sobreescrito, permitindo que o calculo do diretor seja executado

// a palavra ABSTRACT permite que eu chame este método em outra classe e nela eu insira os valores necessários daquela classe,
// nesse caso eu vou poder definir em para cada funcionário qual sera o aumento de salário e qual a bonificação 
// e se não passado o valor, o compilador não permite o código rodar