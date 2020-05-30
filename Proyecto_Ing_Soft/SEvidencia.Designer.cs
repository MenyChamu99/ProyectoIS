namespace InterfazDocente
{
    partial class SEvidencia
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.archivo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.combomateria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = " Subir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(468, 148);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar comentarios:";
            // 
            // archivo
            // 
            this.archivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archivo.Location = new System.Drawing.Point(9, 116);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(364, 29);
            this.archivo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(483, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // combomateria
            // 
            this.combomateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomateria.FormattingEnabled = true;
            this.combomateria.Location = new System.Drawing.Point(435, 75);
            this.combomateria.Name = "combomateria";
            this.combomateria.Size = new System.Drawing.Size(121, 26);
            this.combomateria.TabIndex = 5;
            this.combomateria.Text = "Materia";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(568, 357);
            this.Controls.Add(this.combomateria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Evidencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label archivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combomateria;
    }
}