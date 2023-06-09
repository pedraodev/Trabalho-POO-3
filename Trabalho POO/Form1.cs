using System.Windows.Forms;
using System.Globalization;
using System.Xml.Serialization;

namespace Trabalho_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Evento de calculo do salario mensal
            salariomes salariomes = new salariomes();
                        
            double  horas, valor;

            valor = double.Parse(txtvalor.Text);
            horas = double.Parse(txthora.Text);

            salariomes.valorhora = valor;
            salariomes.horastrabalhadas = horas;

            double salariomensal = salariomes.valorsalario();
            double Desconto = salariomes.DescontoINSS();
            double salarioLiquido = salariomes.salarioliquido();
            double resultado;
            double liquido;

            resultado = salariomensal - Desconto;
            liquido = salariomensal - resultado;

            txtresultado.Text = liquido.ToString("C");
        }
        
        private void btndecimo_Click(object sender, EventArgs e)
        {
            //Evento para calcular o decimo terceiro do funcionario
            decimoterceiro decimo = new decimoterceiro();
            salariomes rsalario = new salariomes();

            double valorhora = double.Parse(txtvalor.Text);
            double horastrabalhadas = double.Parse(txthora.Text);

            rsalario.valorhora = valorhora;
            rsalario.horastrabalhadas = horastrabalhadas;

            double salariol = rsalario.valorsalario();
            double dterceiro = double.Parse(txtmeses.Text);

            decimo.salarioliquido = salariol;
            decimo.mesestrabalhados = dterceiro;

            double resultdecimo = decimo.calculodecimo();

            lblrdecimo.Text = resultdecimo.ToString("C");
        }
        private void btnferias_Click(object sender, EventArgs e)
        {
            //evento para calcular o décimo terceiro do funcionário
            salariomes saldosalario = new salariomes();
            Ferias saldoferias = new Ferias();

            double vhora = double.Parse(txtvalor.Text);
            double horast = double.Parse(txtvalor.Text);

            saldoferias.valorhora = vhora;
            saldoferias.horastrabalhadas = horast;
            

            double liquido = saldoferias.liquidosalario();
            double diasferias = double.Parse(txtferias.Text);

            double valorferias = liquido * diasferias / 3;

            lblrferias.Text = valorferias.ToString("C");

        }
        private void btncompleto_Click(object sender, EventArgs e)
        {
             
             
            Funcionario funcionario = new Funcionario();
            salariomes rsalario = new salariomes();
            decimoterceiro rdecimo = new decimoterceiro();
            Ferias rferias = new Ferias();
            lucroBI rlucro = new lucroBI();

            string nome, matricula, cargo;
            double salario;

            funcionario.Nome = txtnome.Text;
            funcionario.Matricula = txtmatricula.Text;
            funcionario.Cargo = txtcargo.Text;

            double hora = double.Parse(txthora.Text);
            double valor = double.Parse(txtvalor.Text);
            double decimoterceiro = double.Parse(txtmeses.Text);
            double feriastotal = double.Parse(txtferias.Text);
            double lucrototal = double.Parse(txtlucro.Text);

            salario = hora * valor;

            nome = txtnome.Text;
            matricula = txtmatricula.Text;
            cargo = txtcargo.Text;

           

            txtcompleto.Text = "Funcionário: " + nome + ", Matrícula: " + matricula + ", com o cargo: " + cargo com o ;
            
        }
    
        #region MyRegion


        private void txtferias_TextChanged(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresultado_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblrferias_Click(object sender, EventArgs e)
        {

        }

        #endregion
   
        private void btnlucro_Click(object sender, EventArgs e)
        {
            // Obter o valor do salário a partir do TextBox txtResultado 
            if (double.TryParse(txtresultado.Text, out double salario))
            {
                // Definir o valor do salário na instância de LucroBI
                lucroBI.salario = salario;

                // Calcular o lucro com base no salário
                string resultado = lucroBI.calcularlucro();

                // Exibir o resultado no Label lblLucro
                lbllucro.Text = resultado;

                // Verificar se o salário é válido
                if (salario <= 0)
                {
                    lbllucro.Text = "Valor inválido. Por favor, digite um número.";
       
                } else if (salario <= 2000){
                    lbllucro.Text = "Funcionário está ganhando conforme o limite excedido pela empresa.";
                }
            }
            else
            {
               lbllucro.Text = "Funcionário está ganhando mais do que o limite liberado pela empresa.";
            }

        }
    }
}
        
       
    

    
