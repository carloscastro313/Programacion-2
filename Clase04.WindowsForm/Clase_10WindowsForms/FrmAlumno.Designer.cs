namespace Clase_06_windowsForms
{
    partial class FrmAlumno
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Nombre_label1 = new System.Windows.Forms.Label();
            this.Legajo_label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Apellido_label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TipoDeExamen_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(15, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Nombre_label1
            // 
            this.Nombre_label1.AutoSize = true;
            this.Nombre_label1.Location = new System.Drawing.Point(12, 16);
            this.Nombre_label1.Name = "Nombre_label1";
            this.Nombre_label1.Size = new System.Drawing.Size(44, 13);
            this.Nombre_label1.TabIndex = 3;
            this.Nombre_label1.Text = "Nombre";
            // 
            // Legajo_label3
            // 
            this.Legajo_label3.AutoSize = true;
            this.Legajo_label3.Location = new System.Drawing.Point(12, 101);
            this.Legajo_label3.Name = "Legajo_label3";
            this.Legajo_label3.Size = new System.Drawing.Size(39, 13);
            this.Legajo_label3.TabIndex = 5;
            this.Legajo_label3.Text = "Legajo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Apellido_label2
            // 
            this.Apellido_label2.AutoSize = true;
            this.Apellido_label2.Location = new System.Drawing.Point(12, 62);
            this.Apellido_label2.Name = "Apellido_label2";
            this.Apellido_label2.Size = new System.Drawing.Size(44, 13);
            this.Apellido_label2.TabIndex = 8;
            this.Apellido_label2.Text = "Apellido";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 9;
            // 
            // TipoDeExamen_label1
            // 
            this.TipoDeExamen_label1.AutoSize = true;
            this.TipoDeExamen_label1.Location = new System.Drawing.Point(12, 140);
            this.TipoDeExamen_label1.Name = "TipoDeExamen_label1";
            this.TipoDeExamen_label1.Size = new System.Drawing.Size(83, 13);
            this.TipoDeExamen_label1.TabIndex = 10;
            this.TipoDeExamen_label1.Text = "Tipo de examen";
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 235);
            this.Controls.Add(this.TipoDeExamen_label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Apellido_label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Legajo_label3);
            this.Controls.Add(this.Nombre_label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmAlumno";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Nombre_label1;
        private System.Windows.Forms.Label Legajo_label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Apellido_label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TipoDeExamen_label1;
    }
}