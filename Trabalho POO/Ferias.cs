using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO;

namespace Trabalho_POO
{
    internal class Ferias
    {
        public double valorhora { get; set; }
        //Atributo que tem como função adicionar e retornar o valor da hora do funcionário
        public double horastrabalhadas { get; set; }
        //Atributo que tem como função adicionar e retornar as horas trabalhadas mensais pelo funcionário
        public string analise_das_ferias { set; get; }
        //Atributo que tem como função adicionar e retornar analise das férias pelo RH
        public string solicitarferias { get; set; }
        //Atributo que tem como função solicitar as férias do funcionário pelo RH
        public double Tirar_Ferias { get; set; }
        //Atributo que tem como função retornar se o funcionário pode tirar férias ou não
        public double duracao { get; set; }
        //Atributo que tem como função adicionar e retornar os dias de férias do funcionário
        public double meses { get; set; }
        //Atributo que tem como funcão adicionar e retornar os meses trabalhados pelos funcionario
        public double liquidosalario()
        {

            double liquido = valorhora * horastrabalhadas;

            return liquido;
        }
        //Método que tem como função retornar o calculo do salario liquido do funcionário
        public double calcularduracao()
        {

            double calculo = liquidosalario();

            return calculo / 3;
        }
        //Método que tem como função realizar o calculo da duração de férias liquidas do funcionário        
        public string verificarferias()
        {
            if (meses >= 12)
            {
                string console = "Funcionario esta apto a tirar ferias";
                return console;
            }
            else
            {
                string console = "Funcionario nao esta apto a tirar ferias";
                return console;
            }
            //Método que tem como função verificar se o funcionário tem direito as férias
        }
        public double valorferias()
        {
            double duracao = calcularduracao();
            double salario = liquidosalario();
            double total = duracao * salario;
            return total;
        }
        //Método que tem como função retornar o valor das ferias do Funcionario
        public string informacoesferias()
        {
            double duracao = calcularduracao();
            double valor = valorferias();

            return "Valor das Ferias: " + valor + "Duracao das Ferias: " + duracao;
        }
        //Método que tem como função retornar as informacoes das ferias do Funcionario
    }
}