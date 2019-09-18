namespace Clase_10WindowsForms
{
    partial class FrmCatedra
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
            this.Alumnos_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calificar_button2 = new System.Windows.Forms.Button();
            this.Agregar_button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AlumnosCalificados_groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Modificar_button3 = new System.Windows.Forms.Button();
            this.Orientacion_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Alumnos_groupBox1.SuspendLayout();
            this.AlumnosCalificados_groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alumnos_groupBox1
            // 
            this.Alumnos_groupBox1.Controls.Add(this.Orientacion_comboBox1);
            this.Alumnos_groupBox1.Controls.Add(this.Modificar_button3);
            this.Alumnos_groupBox1.Controls.Add(this.Calificar_button2);
            this.Alumnos_groupBox1.Controls.Add(this.Agregar_button1);
            this.Alumnos_groupBox1.Controls.Add(this.listBox1);
            this.Alumnos_groupBox1.Location = new System.Drawing.Point(12, 9);
            this.Alumnos_groupBox1.Name = "Alumnos_groupBox1";
            this.Alumnos_groupBox1.Size = new System.Drawing.Size(481, 237);
            this.Alumnos_groupBox1.TabIndex = 0;
            this.Alumnos_groupBox1.TabStop = false;
            this.Alumnos_groupBox1.Text = "Alumnos";
            // 
            // Calificar_button2
            // 
            this.Calificar_button2.Location = new System.Drawing.Point(186, 28);
            this.Calificar_button2.Name = "Calificar_button2";
            this.Calificar_button2.Size = new System.Drawing.Size(102, 26);
            this.Calificar_button2.TabIndex = 2;
            this.Calificar_button2.Text = "Calificar";
            this.Calificar_button2.UseVisualStyleBackColor = true;
            // 
            // Agregar_button1
            // 
            this.Agregar_button1.Location = new System.Drawing.Point(6, 28);
            this.Agregar_button1.Name = "Agregar_button1";
            this.Agregar_button1.Size = new System.Drawing.Size(102, 26);
            this.Agregar_button1.TabIndex = 1;
            this.Agregar_button1.Text = "Agregar";
            this.Agregar_button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 134);
            this.listBox1.TabIndex = 0;
            // 
            // AlumnosCalificados_groupBox2
            // 
            this.AlumnosCalificados_groupBox2.Controls.Add(this.listBox2);
            this.AlumnosCalificados_groupBox2.Location = new System.Drawing.Point(12, 252);
            this.AlumnosCalificados_groupBox2.Name = "AlumnosCalificados_groupBox2";
            this.AlumnosCalificados_groupBox2.Size = new System.Drawing.Size(481, 186);
            this.AlumnosCalificados_groupBox2.TabIndex = 1;
            this.AlumnosCalificados_groupBox2.TabStop = false;
            this.AlumnosCalificados_groupBox2.Text = "Alumnos Calificados";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(469, 160);
            this.listBox2.TabIndex = 1;
            // 
            // Modificar_button3
            // 
            this.Modificar_button3.Location = new System.Drawing.Point(373, 28);
            this.Modificar_button3.Name = "Modificar_button3";
            this.Modificar_button3.Size = new System.Drawing.Size(102, 26);
            this.Modificar_button3.TabIndex = 3;
            this.Modificar_button3.Text = "Modificar";
            this.Modificar_button3.UseVisualStyleBackColor = true;
            // 
            // Orientacion_comboBox1
            // 
            this.Orientacion_comboBox1.FormattingEnabled = true;
            this.Orientacion_comboBox1.Location = new System.Drawing.Point(6, 213);
            this.Orientacion_comboBox1.Name = "Orientacion_comboBox1";
            this.Orientacion_comboBox1.Size = new System.Drawing.Size(469, 21);
            this.Orientacion_comboBox1.TabIndex = 4;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.AlumnosCalificados_groupBox2);
            this.Controls.Add(this.Alumnos_groupBox1);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.Alumnos_groupBox1.ResumeLayout(false);
            this.AlumnosCalificados_groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Alumnos_groupBox1;
        private System.Windows.Forms.GroupBox AlumnosCalificados_groupBox2;
        private System.Windows.Forms.Button Calificar_button2;
        private System.Windows.Forms.Button Agregar_button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox Orientacion_comboBox1;
        private System.Windows.Forms.Button Modificar_button3;
    }
}