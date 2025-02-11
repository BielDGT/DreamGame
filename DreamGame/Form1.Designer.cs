namespace DreamGame
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAlert = new System.Windows.Forms.Label();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDesenvolvedor = new System.Windows.Forms.TextBox();
            this.richTextBoxDescrição = new System.Windows.Forms.RichTextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxAvaliação = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTamanho = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlert.Location = new System.Drawing.Point(490, 116);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 29);
            this.labelAlert.TabIndex = 38;
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxValor.Location = new System.Drawing.Point(192, 189);
            this.maskedTextBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxValor.Mask = "$0,000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(281, 26);
            this.maskedTextBoxValor.TabIndex = 37;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(537, 206);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(211, 30);
            this.buttonFechar.TabIndex = 33;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(537, 167);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(211, 30);
            this.buttonLimpar.TabIndex = 32;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(537, 124);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(211, 30);
            this.buttonCadastrar.TabIndex = 31;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Desenvolvedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tamanho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Avaliação";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(192, 79);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(281, 26);
            this.textBoxTitulo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Jogos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Genero";
            // 
            // textBoxDesenvolvedor
            // 
            this.textBoxDesenvolvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesenvolvedor.Location = new System.Drawing.Point(192, 225);
            this.textBoxDesenvolvedor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesenvolvedor.Name = "textBoxDesenvolvedor";
            this.textBoxDesenvolvedor.Size = new System.Drawing.Size(281, 26);
            this.textBoxDesenvolvedor.TabIndex = 41;
            // 
            // richTextBoxDescrição
            // 
            this.richTextBoxDescrição.Location = new System.Drawing.Point(192, 295);
            this.richTextBoxDescrição.Name = "richTextBoxDescrição";
            this.richTextBoxDescrição.Size = new System.Drawing.Size(281, 118);
            this.richTextBoxDescrição.TabIndex = 43;
            this.richTextBoxDescrição.Text = "";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Fantasia",
            "Comedia",
            "Terror",
            "Suspense"});
            this.comboBoxGenero.Location = new System.Drawing.Point(192, 263);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(281, 21);
            this.comboBoxGenero.TabIndex = 45;
            // 
            // comboBoxAvaliação
            // 
            this.comboBoxAvaliação.FormattingEnabled = true;
            this.comboBoxAvaliação.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxAvaliação.Location = new System.Drawing.Point(192, 115);
            this.comboBoxAvaliação.Name = "comboBoxAvaliação";
            this.comboBoxAvaliação.Size = new System.Drawing.Size(281, 21);
            this.comboBoxAvaliação.TabIndex = 46;
            // 
            // maskedTextBoxTamanho
            // 
            this.maskedTextBoxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTamanho.Location = new System.Drawing.Point(192, 151);
            this.maskedTextBoxTamanho.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxTamanho.Mask = "000,00Gb";
            this.maskedTextBoxTamanho.Name = "maskedTextBoxTamanho";
            this.maskedTextBoxTamanho.Size = new System.Drawing.Size(281, 26);
            this.maskedTextBoxTamanho.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxTamanho);
            this.Controls.Add(this.comboBoxAvaliação);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.richTextBoxDescrição);
            this.Controls.Add(this.textBoxDesenvolvedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDesenvolvedor;
        private System.Windows.Forms.RichTextBox richTextBoxDescrição;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxAvaliação;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTamanho;
    }
}

