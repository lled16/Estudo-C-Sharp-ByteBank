using ByteBank.Funcionarios.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor :FuncionarioAutenticavel  // QUANDO COLOCAMOS O ":" ELE ENTENDE QUE O DIRETOR TAMBÉM É UM FUNCIONÁRIO
    {


        
        public Diretor(string cpf) : base(5000, cpf)

        /*  public Diretor(string cpf) : base(cpf)  = essa linha informa que o diretor receberá um cpf, asim como um funcionario qualquer, fazendo funcionar a inserção de CPF no arquivo PROGRAM   */


        /*como DIRETOR é uma derivada da classo base FUNCIONARIO, ele recebe a função de incrementar + 1 funcionario sempre que criado um novo, 
         por isso já fica subentendido que será adicionado um novo FUNCIONARIO quando criado um novo diretor, não sendo necessário criar uma incrementação aqui !*/
        {
            Console.WriteLine("Criando um diretor ...");

        }

     

        public override void AumentarSalario()  // aqui eu estou modificando o método criado na classe funcionário, que aumenta o salário, só que aumenta em 15% o do diretor
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao() //OVERRIDE  informe para o C# que eu estou sobreescrevendo o método do funcionário
        {



            return Salario * 0.5;  
        }
    }
}
