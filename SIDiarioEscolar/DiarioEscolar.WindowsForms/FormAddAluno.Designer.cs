namespace DiarioEscolar.WindowsForms
{
    partial class FormAddAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Turma:";
            // 
            // cbxTurma
            // 
            this.cbxTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Location = new System.Drawing.Point(85, 19);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(184, 21);
            this.cbxTurma.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sobrenome: ";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(85, 83);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(184, 20);
            this.txtSobrenome.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Idade: ";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(85, 115);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(184, 20);
            this.txtIdade.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nota: ";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(85, 151);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(184, 20);
            this.txtNota.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(85, 186);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(184, 21);
            this.cbxStatus.TabIndex = 30;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTurma);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAluno";
            this.Text = "FormAddAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}