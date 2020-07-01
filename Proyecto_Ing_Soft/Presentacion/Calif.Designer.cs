namespace InterfazDocente
{
    partial class Calif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calif));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TablaCalif = new System.Windows.Forms.DataGridView();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtU1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtU2 = new System.Windows.Forms.TextBox();
            this.txtU3 = new System.Windows.Forms.TextBox();
            this.txtU4 = new System.Windows.Forms.TextBox();
            this.txtU5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCalif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Id Alumno";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TablaCalif
            // 
            this.TablaCalif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCalif.Location = new System.Drawing.Point(12, 205);
            this.TablaCalif.Name = "TablaCalif";
            this.TablaCalif.Size = new System.Drawing.Size(869, 330);
            this.TablaCalif.TabIndex = 3;
            this.TablaCalif.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(89, 118);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(121, 20);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(325, 118);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.ReadOnly = true;
            this.txtApellidoP.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoP.TabIndex = 5;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(565, 118);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.ReadOnly = true;
            this.txtApellidoM.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoM.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(895, 38);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(0, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(895, 23);
            this.label5.TabIndex = 11;
            // 
            // txtU1
            // 
            this.txtU1.Location = new System.Drawing.Point(110, 163);
            this.txtU1.MaxLength = 3;
            this.txtU1.Name = "txtU1";
            this.txtU1.Size = new System.Drawing.Size(47, 20);
            this.txtU1.TabIndex = 12;
            this.txtU1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.txtU1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtU1_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Unidad I:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unidad II:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unidad III:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unidad IV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Unidad V:";
            // 
            // txtU2
            // 
            this.txtU2.Location = new System.Drawing.Point(222, 163);
            this.txtU2.MaxLength = 3;
            this.txtU2.Name = "txtU2";
            this.txtU2.Size = new System.Drawing.Size(46, 20);
            this.txtU2.TabIndex = 18;
            this.txtU2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.txtU2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtU2_KeyUp);
            // 
            // txtU3
            // 
            this.txtU3.Location = new System.Drawing.Point(336, 163);
            this.txtU3.MaxLength = 3;
            this.txtU3.Name = "txtU3";
            this.txtU3.Size = new System.Drawing.Size(46, 20);
            this.txtU3.TabIndex = 19;
            this.txtU3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.txtU3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtU3_KeyUp);
            // 
            // txtU4
            // 
            this.txtU4.Location = new System.Drawing.Point(448, 163);
            this.txtU4.MaxLength = 3;
            this.txtU4.Name = "txtU4";
            this.txtU4.Size = new System.Drawing.Size(46, 20);
            this.txtU4.TabIndex = 20;
            this.txtU4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            this.txtU4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtU4_KeyUp);
            // 
            // txtU5
            // 
            this.txtU5.Location = new System.Drawing.Point(556, 163);
            this.txtU5.MaxLength = 3;
            this.txtU5.Name = "txtU5";
            this.txtU5.Size = new System.Drawing.Size(46, 20);
            this.txtU5.TabIndex = 21;
            this.txtU5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            this.txtU5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtU5_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(320, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Calificaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "INSTITUTO TECNOLOGICO DE DELICIAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Subir Calificaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(688, 154);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar Calificaciones";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Calif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 547);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtU5);
            this.Controls.Add(this.txtU4);
            this.Controls.Add(this.txtU3);
            this.Controls.Add(this.txtU2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtU1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.TablaCalif);
            this.Controls.Add(this.comboBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calif";
            this.Text = "Captura de Calificaciones";
            this.Load += new System.EventHandler(this.Calif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCalif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView TablaCalif;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtU1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtU2;
        private System.Windows.Forms.TextBox txtU3;
        private System.Windows.Forms.TextBox txtU4;
        private System.Windows.Forms.TextBox txtU5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
    }
}