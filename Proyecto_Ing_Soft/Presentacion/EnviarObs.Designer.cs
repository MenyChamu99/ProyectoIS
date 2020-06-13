namespace Proyecto_Ing_Soft.Presentacion
{
    partial class EnviarObs
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbIdDocente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNombreD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIdPlan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(-1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(-1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 23);
            this.label2.TabIndex = 1;
            // 
            // cbIdDocente
            // 
            this.cbIdDocente.FormattingEnabled = true;
            this.cbIdDocente.Location = new System.Drawing.Point(88, 81);
            this.cbIdDocente.Name = "cbIdDocente";
            this.cbIdDocente.Size = new System.Drawing.Size(121, 21);
            this.cbIdDocente.TabIndex = 2;
            this.cbIdDocente.SelectedIndexChanged += new System.EventHandler(this.cbIdDocente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Docente:";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(12, 139);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(455, 278);
            this.txtPlan.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar Observaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Docente:";
            // 
            // lbNombreD
            // 
            this.lbNombreD.BackColor = System.Drawing.Color.White;
            this.lbNombreD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNombreD.Location = new System.Drawing.Point(125, 111);
            this.lbNombreD.Name = "lbNombreD";
            this.lbNombreD.Size = new System.Drawing.Size(97, 21);
            this.lbNombreD.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id Plan de Trabajo:";
            // 
            // cbIdPlan
            // 
            this.cbIdPlan.FormattingEnabled = true;
            this.cbIdPlan.Location = new System.Drawing.Point(345, 81);
            this.cbIdPlan.Name = "cbIdPlan";
            this.cbIdPlan.Size = new System.Drawing.Size(121, 21);
            this.cbIdPlan.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Materia:";
            // 
            // lbMateria
            // 
            this.lbMateria.BackColor = System.Drawing.Color.White;
            this.lbMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMateria.Location = new System.Drawing.Point(280, 112);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(97, 21);
            this.lbMateria.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unidad:";
            // 
            // lbUnidad
            // 
            this.lbUnidad.BackColor = System.Drawing.Color.White;
            this.lbUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUnidad.Location = new System.Drawing.Point(434, 111);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(32, 20);
            this.lbUnidad.TabIndex = 13;
            // 
            // EnviarObs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 464);
            this.Controls.Add(this.lbUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIdPlan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNombreD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIdDocente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnviarObs";
            this.Text = "EnviarObs";
            this.Load += new System.EventHandler(this.EnviarObs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIdDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNombreD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIdPlan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUnidad;
    }
}