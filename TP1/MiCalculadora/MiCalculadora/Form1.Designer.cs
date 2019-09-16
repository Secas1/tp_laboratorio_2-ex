namespace MiCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnADecimal = new System.Windows.Forms.Button();
            this.btnABinario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(292, 173);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 173);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(130, 35);
            this.btnOperar.TabIndex = 2;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnADecimal
            // 
            this.btnADecimal.Location = new System.Drawing.Point(222, 214);
            this.btnADecimal.Name = "btnADecimal";
            this.btnADecimal.Size = new System.Drawing.Size(200, 35);
            this.btnADecimal.TabIndex = 3;
            this.btnADecimal.Text = "Convertir a Decimal";
            this.btnADecimal.UseVisualStyleBackColor = true;
            // 
            // btnABinario
            // 
            this.btnABinario.Location = new System.Drawing.Point(12, 214);
            this.btnABinario.Name = "btnABinario";
            this.btnABinario.Size = new System.Drawing.Size(200, 35);
            this.btnABinario.TabIndex = 4;
            this.btnABinario.Text = "Convertir a Binario";
            this.btnABinario.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(153, 173);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnABinario);
            this.Controls.Add(this.btnADecimal);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = " Calculadora de Sebastian Rodriguez de 2C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnADecimal;
        private System.Windows.Forms.Button btnABinario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

