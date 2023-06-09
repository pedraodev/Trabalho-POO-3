using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Funcionario
    {
        
        public string Nome { get; set; }

        //Atributo que tem como função retornar o nome do usuário

        public double CPF { get; set; }

        //Atributo que tem como função retornar o CPF do usuário

        public string Endereço { get; set; }

        //Atributo que tem como função retornar o Endereço do usuário

        public string Matricula { get; set; }

        //Atributo que tem como função retornar a matricula do usuário

        public string Cargo { get; set; }

        //Atributo que tem como função retornar o cargo do usuário

        private string Novocargo { get; set; }
        //Atributo que tem como função subir o cargo do funcionário

        public string informacoesbasicas()
        {
            return Nome + Matricula + Cargo;
        }

        //Método que tem como função retornar as informações básicas do Funcionário no demonstrativo simples

        public string infocompleta()
        {
            return Nome + CPF + Endereço + Matricula + Cargo;
        }

        //Método que tem como função retornar as informações completas do Funcionário no demonstrativo completo
        public void Promover() {

            string cargo = Novocargo;
        }
        //Método que tem como função alterar o cargo do funcionário na base de dados
        public void demissao() {

            string demitido = Nome;

        }
        //Método que tem como função demitir o funcionário e excluir da base de dados
        public void atualizardados() {
            string cargo = Cargo;
            string Promocao = Novocargo;
        }
        //Método que tem como função atualizar os dados do funcionário na base de dados
    }
}

    


