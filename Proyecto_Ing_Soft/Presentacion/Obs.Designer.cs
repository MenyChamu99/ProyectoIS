namespace InterfazDocente
{
    partial class Obs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obs));
            this.BandejaE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsua = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BandejaE
            // 
            this.BandejaE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BandejaE.Location = new System.Drawing.Point(13, 141);
            this.BandejaE.Name = "BandejaE";
            this.BandejaE.Size = new System.Drawing.Size(636, 345);
            this.BandejaE.TabIndex = 0;
            this.BandejaE.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensajes recibidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 23);
            this.label2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(662, 55);
            this.label3.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 29);
            this.label12.TabIndex = 46;
            this.label12.Text = "INSTITUTO TECNOLOGICO DE DELICIAS";
            // 
            // txtUsua
            // 
            this.txtUsua.Location = new System.Drawing.Point(338, 229);
            this.txtUsua.Name = "txtUsua";
            this.txtUsua.Size = new System.Drawing.Size(100, 20);
            this.txtUsua.TabIndex = 47;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(338, 271);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 48;
            this.txtContra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbUsuario
            // 
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(227, 229);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(73, 20);
            this.lbUsuario.TabIndex = 49;
            this.lbUsuario.Text = "Usuario:";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContra
            // 
            this.lbContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.Location = new System.Drawing.Point(227, 271);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(101, 20);
            this.lbContra.TabIndex = 50;
            this.lbContra.Text = "Contraseña:";
            this.lbContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbContra.Click += new System.EventHandler(this.lbContra_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(301, 311);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 26);
            this.btnIngresar.TabIndex = 51;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Obs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 495);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BandejaE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Obs";
            this.Text = "Bandeja de entrada";
            this.Load += new System.EventHandler(this.Obs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BandejaE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsua;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.Button btnIngresar;
    }
}