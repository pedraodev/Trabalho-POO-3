using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class salariomes
    {
        
        public double valorhora { get; set; }
        //Atributo que tem como função adicionar e retornar o valor da hora do funcionário
        public double horastrabalhadas { get; set; }
        //Atributo que tem como função adicionar e retornar a quantidade de horas trabalhadas do funcionário
        public double salariofuncionario { get; set; }
        //Atributo que tem como função adicionar e retornar o salario do funcionário com base em seu registro
        public double salariobruto()
        {
            double salario = salariofuncionario;
            
            return salario;
        }
        //Método que tem como função retornar o salario bruto do funcionario
        public double valorsalario()
        {
            double totalsalario = valorhora * horastrabalhadas;
            return totalsalario;
        }
        //Método que tem como função retornar o salario bruto do funcionário
        public double DescontoINSS()
        {
            double salario = valorsalario();
            double descontoINSS;

            if (salario <= 1320)
            {
                descontoINSS = 0;
            }
            else if (salario < 2571.29)
            {
                descontoINSS = salario - 15.67;
            }
            else if (salario < 3856.95)
            {
                descontoINSS = salario * 0.12;
            }
            else
            {
                descontoINSS = salario * 0.14;
            }
                        
            return descontoINSS;
        }
        //Método que tem como função calcular o desconto do INSS
        public double salarioliquido()
        {
            double salario = valorsalario();
            double descontoINSS = DescontoINSS();
            double salarioLLL = salario - descontoINSS;

            return salarioLLL;


        }
        //Método que tem como função calcular o salarioliquido com o desconto do INSS
        public double salarioanual()
        {
            double salario = valorsalario();
            double anual = salario * 12;
            return anual;
        }
        //Método que tem como função retornar o gasto com salario anual desse funcionário
    }

}
