using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class decimoterceiro
    {
        public double salarioliquido { get; set; }
        //Atributo que tem como função adicionar e  retornar o salario liquido do funcionário

        public double mesestrabalhados { get; set; }
        //Atributo que tem como função adicionar e  retornar os meses trabalhados do funcionário
        public double calculodecimo()
        {
            return salarioliquido * mesestrabalhados / 12;
        }
        // Método que tem como função retornar o calculo do decimo terceiro

        public double decimoproporcional()
        {
            return salarioliquido * mesestrabalhados / 12;

        }
        //Método que tem como função retornar o proporcional ao decimo terceiro do Funcionario


    }
}
