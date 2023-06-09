namespace Trabalho_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtferias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.lblferias = new System.Windows.Forms.Label();
            this.lbldecimo = new System.Windows.Forms.Label();
            this.btnferias = new System.Windows.Forms.Button();
            this.btndecimo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblrferias = new System.Windows.Forms.Label();
            this.lblrdecimo = new System.Windows.Forms.Label();
            this.lblinformacoes = new System.Windows.Forms.Label();
            this.txtcompleto = new System.Windows.Forms.TextBox();
            this.btncompleto = new System.Windows.Forms.Button();
            this.btnlucro = new System.Windows.Forms.Button();
            this.txtlucro = new System.Windows.Forms.TextBox();
            this.lbllucro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folha de pagamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(581, 242);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(116, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular Salário";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas Trabalhadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(266, 239);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(46, 23);
            this.txtvalor.TabIndex = 6;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(482, 239);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(45, 23);
            this.txthora.TabIndex = 7;
            // 
            // txtresultado
            // 
            this.txtresultado.AutoSize = true;
            this.txtresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))), ((int)(((byte)(199)))));
            this.txtresultado.Location = new System.Drawing.Point(734, 246);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(59, 15);
            this.txtresultado.TabIndex = 23;
            this.txtresultado.Tag = "";
            this.txtresultado.Text = "Resultado";
            this.txtresultado.Click += new System.EventHandler(this.txtresultado_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(204, 80);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(114, 23);
            this.txtnome.TabIndex = 9;
            this.txtnome.TextChanged += new System.EventHandler(this.btnnome_TextChanged);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(147, 42);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(202, 15);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Digite as informações do funcionario";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(422, 80);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(142, 23);
            this.txtmatricula.TabIndex = 11;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(646, 80);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 23);
            this.txtcargo.TabIndex = 12;
            // 
            // txtferias
            // 
            this.txtferias.Location = new System.Drawing.Point(340, 284);
            this.txtferias.Name = "txtferias";
            this.txtferias.Size = new System.Drawing.Size(100, 23);
            this.txtferias.TabIndex = 13;
            this.txtferias.TextChanged += new System.EventHandler(this.txtferias_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Matricula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cargo";
            // 
            // txtmeses
            // 
            this.txtmeses.Location = new System.Drawing.Point(340, 331);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(100, 23);
            this.txtmeses.TabIndex = 17;
            this.txtmeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblferias
            // 
            this.lblferias.AutoSize = true;
            this.lblferias.Location = new System.Drawing.Point(173, 292);
            this.lblferias.Name = "lblferias";
            this.lblferias.Size = new System.Drawing.Size(78, 15);
            this.lblferias.TabIndex = 18;
            this.lblferias.Text = "Dias de Férias";
            // 
            // lbldecimo
            // 
            this.lbldecimo.AutoSize = true;
            this.lbldecimo.Location = new System.Drawing.Point(170, 339);
            this.lbldecimo.Name = "lbldecimo";
            this.lbldecimo.Size = new System.Drawing.Size(105, 15);
            this.lbldecimo.TabIndex = 19;
            this.lbldecimo.Text = "Meses trabalhados";
            // 
            // btnferias
            // 
            this.btnferias.Location = new System.Drawing.Point(473, 284);
            this.btnferias.Name = "btnferias";
            this.btnferias.Size = new System.Drawing.Size(116, 23);
            this.btnferias.TabIndex = 20;
            this.btnferias.Text = "Calcular Férias";
            this.btnferias.UseVisualStyleBackColor = true;
            this.btnferias.Click += new System.EventHandler(this.btnferias_Click);
            // 
            // btndecimo
            // 
            this.btndecimo.Location = new System.Drawing.Point(473, 331);
            this.btndecimo.Name = "btndecimo";
            this.btndecimo.Size = new System.Drawing.Size(116, 23);
            this.btndecimo.TabIndex = 21;
            this.btndecimo.Text = "Calcular 13º";
            this.btndecimo.UseVisualStyleBackColor = true;
            this.btndecimo.Click += new System.EventHandler(this.btndecimo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Retorno sobre funcionario";
            // 
            // lblrferias
            // 
            this.lblrferias.AutoSize = true;
            this.lblrferias.Location = new System.Drawing.Point(621, 288);
            this.lblrferias.Name = "lblrferias";
            this.lblrferias.Size = new System.Drawing.Size(59, 15);
            this.lblrferias.TabIndex = 23;
            this.lblrferias.Text = "Resultado";
            this.lblrferias.Click += new System.EventHandler(this.lblrferias_Click);
            // 
            // lblrdecimo
            // 
            this.lblrdecimo.AutoSize = true;
            this.lblrdecimo.Location = new System.Drawing.Point(621, 335);
            this.lblrdecimo.Name = "lblrdecimo";
            this.lblrdecimo.Size = new System.Drawing.Size(59, 15);
            this.lblrdecimo.TabIndex = 24;
            this.lblrdecimo.Text = "Resultado";
            // 
            // lblinformacoes
            // 
            this.lblinformacoes.AutoSize = true;
            this.lblinformacoes.Location = new System.Drawing.Point(329, 124);
            this.lblinformacoes.Name = "lblinformacoes";
            this.lblinformacoes.Size = new System.Drawing.Size(203, 15);
            this.lblinformacoes.TabIndex = 25;
            this.lblinformacoes.Text = "Informações basicas do Funcionário :";
            // 
            // txtcompleto
            // 
            this.txtcompleto.Location = new System.Drawing.Point(191, 155);
            this.txtcompleto.Name = "txtcompleto";
            this.txtcompleto.Size = new System.Drawing.Size(489, 23);
            this.txtcompleto.TabIndex = 26;
            this.txtcompleto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncompleto
            // 
            this.btncompleto.Location = new System.Drawing.Point(329, 196);
            this.btncompleto.Name = "btncompleto";
            this.btncompleto.Size = new System.Drawing.Size(178, 23);
            this.btncompleto.TabIndex = 27;
            this.btncompleto.Text = "Informações Funcionário";
            this.btncompleto.UseVisualStyleBackColor = true;
            this.btncompleto.Click += new System.EventHandler(this.btncompleto_Click);
            // 
            // btnlucro
            // 
            this.btnlucro.Location = new System.Drawing.Point(473, 379);
            this.btnlucro.Name = "btnlucro";
            this.btnlucro.Size = new System.Drawing.Size(116, 23);
            this.btnlucro.TabIndex = 28;
            this.btnlucro.Text = "Calcular BI";
            this.btnlucro.UseVisualStyleBackColor = true;
            this.btnlucro.Click += new System.EventHandler(this.btnlucro_Click);
            // 
            // txtlucro
            // 
            this.txtlucro.Location = new System.Drawing.Point(340, 379);
            this.txtlucro.Name = "txtlucro";
            this.txtlucro.Size = new System.Drawing.Size(100, 23);
            this.txtlucro.TabIndex = 29;
            // 
            // lbllucro
            // 
            this.lbllucro.AutoSize = true;
            this.lbllucro.Location = new System.Drawing.Point(621, 382);
            this.lbllucro.Name = "lbllucro";
            this.lbllucro.Size = new System.Drawing.Size(59, 15);
            this.lbllucro.TabIndex = 30;
            this.lbllucro.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 529);
            this.Controls.Add(this.lbllucro);
            this.Controls.Add(this.txtlucro);
            this.Controls.Add(this.btnlucro);
            this.Controls.Add(this.btncompleto);
            this.Controls.Add(this.txtcompleto);
            this.Controls.Add(this.lblinformacoes);
            this.Controls.Add(this.lblrdecimo);
            this.Controls.Add(this.lblrferias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btndecimo);
            this.Controls.Add(this.btnferias);
            this.Controls.Add(this.lbldecimo);
            this.Controls.Add(this.lblferias);
            this.Controls.Add(this.txtmeses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtferias);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btncalcular;
        private Label label2;
        private Label label3;
        private TextBox txtvalor;
        private TextBox txthora;
        private Label txtresultado;
        private TextBox txtnome;
        private Label lblnome;
        private TextBox txtmatricula;
        private TextBox txtcargo;
        private TextBox txtferias;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmeses;
        private Label lblferias;
        private Label lbldecimo;
        private Button btnferias;
        private Button btndecimo;
        private Label label7;
        private Label lblrferias;
        private Label lblrdecimo;
        private Label lblinformacoes;
        private TextBox txtcompleto;
        private Button btncompleto;
        private Button btnlucro;
        private TextBox txtlucro;
        private Label lbllucro;
    }
}