using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _total_bonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _total_bonificacao += funcionario.GetBonificacao();
        }

       /*  public void Registrar(Diretor diretor)
        {
            _total_bonificacao += diretor.GetBonificacao();
        } 

       NÃO PRECISO MAIS REPETIR O CÓDIGO PARA O DIRETOR POIS AGORA ELE É RECONHECIDO COMO UM FUNCIONÁRIO TAMBÉM !
        
        
        */
     

        public double GetTotalBonificacao()
        {
            return _total_bonificacao;

        }
    }
}
