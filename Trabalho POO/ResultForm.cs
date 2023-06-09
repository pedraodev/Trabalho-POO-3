using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    public class SeuForm : Form
    {
        public TextBox txtResultado;
        public Button btnLucro;
        public Label lblLucro;

        public lucroBI lucroBI;

        public SeuForm()
        {
            // Inicializar os componentes do formulário
            InitializeComponent();

            // Criar uma instância de LucroBI
            lucroBI = new lucroBI();
        }

        public void InitializeComponent()
        {
            // Código para inicializar os componentes do formulário

            btnLucro.Click += BtnLucro_Click;

            // Configurar o evento de clique para o botão btnLucro

        }
        
        private void BtnLucro_Click(object? sender, EventArgs e)
        //adicionar código para calcular o lucro com base do salário txtresultado e exibir o resultado no lbllucro
        //e atualizar a propiredade lbllucro.Text com o resultado
        {
            throw new NotImplementedException();
        }
    }
}

    

