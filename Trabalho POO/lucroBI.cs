using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO
{
    public class lucroBI
    {

        // Atributo valor do salario do funcionario
        public static double salario;
        //verificar a matricula do funcionario
        public string matriculo { set; get; }
        // armazena o valor roral dos custos incorridos
        public double custototal { set; get; }
        //Método que tem como função retornar o custo total com  funcionário

        public double registrarcusto()
        {
            
            return custototal;
        }
        //Método que tem como função registrar o custo total com  funcionário

        public static double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        // Método que tem como função retornar o salario
        public static string calcularlucro()
        {
            if (salario >= 2100)
                return "Funcionário está ganhando mais do que o limite liberado pela empresa.";
            else if (salario <= 2000)
                return "Funcionário está ganhando conforme o limite excedido pela empresa.";
            else
                return "Valor inválido. Por favor, digite um número.";
        }// Método que tem como função calcular o lucro sobre o funcionário
    }
    }

