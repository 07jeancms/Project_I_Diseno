namespace ProyectoIDiseno.View
{
    partial class FormSeleccionIG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            this.radioGrafico = new System.Windows.Forms.RadioButton();
            this.radioConsola = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccion el tipo de vista:";
            // 
            // radioGrafico
            // 
            this.radioGrafico.AutoSize = true;
            this.radioGrafico.Checked = true;
            this.radioGrafico.Location = new System.Drawing.Point(94, 48);
            this.radioGrafico.Name = "radioGrafico";
            this.radioGrafico.Size = new System.Drawing.Size(89, 17);
            this.radioGrafico.TabIndex = 6;
            this.radioGrafico.TabStop = true;
            this.radioGrafico.Text = "Modo Grafico";
            this.radioGrafico.UseVisualStyleBackColor = true;
            // 
            // radioConsola
            // 
            this.radioConsola.AutoSize = true;
            this.radioConsola.Location = new System.Drawing.Point(94, 71);
            this.radioConsola.Name = "radioConsola";
            this.radioConsola.Size = new System.Drawing.Size(63, 17);
            this.radioConsola.TabIndex = 5;
            this.radioConsola.Text = "Consola";
            this.radioConsola.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(73, 94);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(125, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FormSeleccionIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioGrafico);
            this.Controls.Add(this.radioConsola);
            this.Controls.Add(this.btnIngresar);
            this.Name = "FormSeleccionIG";
            this.Text = "FormSeleccionIG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioGrafico;
        private System.Windows.Forms.RadioButton radioConsola;
        private System.Windows.Forms.Button btnIngresar;
    }
}