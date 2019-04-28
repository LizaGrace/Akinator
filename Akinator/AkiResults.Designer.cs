namespace Akinator
{
    partial class AkiResults
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNumPatas = new System.Windows.Forms.Label();
            this.lblPiel = new System.Windows.Forms.Label();
            this.lblVoz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 39);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(45, 140);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(176, 39);
            this.lblNacimiento.TabIndex = 1;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(45, 211);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(87, 39);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // lblNumPatas
            // 
            this.lblNumPatas.AutoSize = true;
            this.lblNumPatas.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPatas.Location = new System.Drawing.Point(45, 282);
            this.lblNumPatas.Name = "lblNumPatas";
            this.lblNumPatas.Size = new System.Drawing.Size(265, 39);
            this.lblNumPatas.TabIndex = 3;
            this.lblNumPatas.Text = "Número de patas";
            // 
            // lblPiel
            // 
            this.lblPiel.AutoSize = true;
            this.lblPiel.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiel.Location = new System.Drawing.Point(45, 353);
            this.lblPiel.Name = "lblPiel";
            this.lblPiel.Size = new System.Drawing.Size(67, 39);
            this.lblPiel.TabIndex = 4;
            this.lblPiel.Text = "Piel";
            // 
            // lblVoz
            // 
            this.lblVoz.AutoSize = true;
            this.lblVoz.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoz.Location = new System.Drawing.Point(45, 424);
            this.lblVoz.Name = "lblVoz";
            this.lblVoz.Size = new System.Drawing.Size(69, 39);
            this.lblVoz.TabIndex = 5;
            this.lblVoz.Text = "Voz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(476, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 299);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AkiResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Akinator.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(995, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVoz);
            this.Controls.Add(this.lblPiel);
            this.Controls.Add(this.lblNumPatas);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblNombre);
            this.DoubleBuffered = true;
            this.Name = "AkiResults";
            this.Text = "AkiResults";
            this.Load += new System.EventHandler(this.AkiResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNumPatas;
        private System.Windows.Forms.Label lblPiel;
        private System.Windows.Forms.Label lblVoz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}