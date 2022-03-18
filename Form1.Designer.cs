namespace Quiz_Vitoriano_Victor
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.lblPergunta1.Location = new System.Drawing.Point(106, 67);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(296, 52);
            this.lblPergunta1.TabIndex = 0;
            this.lblPergunta1.Text = "Quantos anos a Rainha Elizabeth\r\ntinha com 18 anos de idade?";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdbA.Location = new System.Drawing.Point(111, 122);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(81, 27);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "16 anos";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdbB.Location = new System.Drawing.Point(111, 155);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(81, 27);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "18 anos";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckedChanged += new System.EventHandler(this.rdbB_CheckedChanged);
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdbC.Location = new System.Drawing.Point(111, 188);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(84, 27);
            this.rdbC.TabIndex = 3;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "30 anos";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.CheckedChanged += new System.EventHandler(this.rdbC_CheckedChanged);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rdbD.Location = new System.Drawing.Point(111, 221);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(84, 27);
            this.rdbD.TabIndex = 4;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "56 anos";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.CheckedChanged += new System.EventHandler(this.rdbD_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(111, 254);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(291, 33);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.lblPergunta1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

