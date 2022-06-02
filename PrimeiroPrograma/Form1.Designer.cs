namespace PrimeiroPrograma
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.TextBox();
            this.masculino = new System.Windows.Forms.CheckBox();
            this.feminino = new System.Windows.Forms.CheckBox();
            this.labsexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(221, 297);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(174, 47);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(401, 297);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(174, 47);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lblnome
            // 
            this.lblnome.Location = new System.Drawing.Point(150, 43);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(181, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblemail
            // 
            this.lblemail.Location = new System.Drawing.Point(149, 103);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(182, 20);
            this.lblemail.TabIndex = 5;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(63, 166);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(56, 13);
            this.endereco.TabIndex = 6;
            this.endereco.Text = "Endereço:";
            // 
            // lblend
            // 
            this.lblend.Location = new System.Drawing.Point(149, 166);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(182, 20);
            this.lblend.TabIndex = 7;
            this.lblend.TextChanged += new System.EventHandler(this.lblend_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone:";
            // 
            // lbltel
            // 
            this.lbltel.Location = new System.Drawing.Point(483, 42);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(181, 20);
            this.lbltel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bairro:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblbairro
            // 
            this.lblbairro.Location = new System.Drawing.Point(483, 102);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(180, 20);
            this.lblbairro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade:";
            // 
            // lblcidade
            // 
            this.lblcidade.Location = new System.Drawing.Point(483, 169);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(179, 20);
            this.lblcidade.TabIndex = 13;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(150, 225);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(69, 17);
            this.masculino.TabIndex = 14;
            this.masculino.Text = "Maculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(150, 248);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(68, 17);
            this.feminino.TabIndex = 15;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // labsexo
            // 
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(81, 238);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(34, 13);
            this.labsexo.TabIndex = 16;
            this.labsexo.Text = "Sexo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labsexo);
            this.Controls.Add(this.feminino);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Name = "Form1";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblemail;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox lblend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbltel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblbairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblcidade;
        private System.Windows.Forms.CheckBox masculino;
        private System.Windows.Forms.CheckBox feminino;
        private System.Windows.Forms.Label labsexo;
    }
}

