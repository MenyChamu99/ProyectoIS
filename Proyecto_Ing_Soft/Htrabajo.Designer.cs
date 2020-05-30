namespace InterfazDocente
{
    partial class Htrabajo
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
            this.combomateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combomateria
            // 
            this.combomateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combomateria.FormattingEnabled = true;
            this.combomateria.Location = new System.Drawing.Point(13, 97);
            this.combomateria.Name = "combomateria";
            this.combomateria.Size = new System.Drawing.Size(121, 26);
            this.combomateria.TabIndex = 6;
            this.combomateria.Text = "Materia";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 346);
            this.label1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(690, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(787, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combomateria);
            this.Name = "Form4";
            this.Text = "Historial de trabajos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combomateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}