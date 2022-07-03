
using System;

namespace _5118_ficha1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EquipaC = new System.Windows.Forms.PictureBox();
            this.EquipaF = new System.Windows.Forms.PictureBox();
            this.NomeEquipaC = new System.Windows.Forms.TextBox();
            this.NomeEquipaF = new System.Windows.Forms.TextBox();
            this.GoloCasaM = new System.Windows.Forms.Button();
            this.GoloCasaMen = new System.Windows.Forms.Button();
            this.GoloForaMe = new System.Windows.Forms.Button();
            this.GoloForaM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaF)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipaC
            // 
            this.EquipaC.Image = ((System.Drawing.Image)(resources.GetObject("EquipaC.Image")));
            this.EquipaC.Location = new System.Drawing.Point(12, 79);
            this.EquipaC.Name = "EquipaC";
            this.EquipaC.Size = new System.Drawing.Size(119, 119);
            this.EquipaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EquipaC.TabIndex = 0;
            this.EquipaC.TabStop = false;
            this.EquipaC.Click += new System.EventHandler(this.EquipaC_Click);
            // 
            // EquipaF
            // 
            this.EquipaF.Image = ((System.Drawing.Image)(resources.GetObject("EquipaF.Image")));
            this.EquipaF.Location = new System.Drawing.Point(593, 79);
            this.EquipaF.Name = "EquipaF";
            this.EquipaF.Size = new System.Drawing.Size(186, 186);
            this.EquipaF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EquipaF.TabIndex = 1;
            this.EquipaF.TabStop = false;
            // 
            // NomeEquipaC
            // 
            this.NomeEquipaC.Location = new System.Drawing.Point(12, 135);
            this.NomeEquipaC.Name = "NomeEquipaC";
            this.NomeEquipaC.Size = new System.Drawing.Size(100, 20);
            this.NomeEquipaC.TabIndex = 2;
            this.NomeEquipaC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NomeEquipaF
            // 
            this.NomeEquipaF.Location = new System.Drawing.Point(626, 271);
            this.NomeEquipaF.Name = "NomeEquipaF";
            this.NomeEquipaF.Size = new System.Drawing.Size(118, 20);
            this.NomeEquipaF.TabIndex = 3;
            this.NomeEquipaF.TextChanged += new System.EventHandler(this.NomeEquipaF_TextChanged);
            // 
            // GoloCasaM
            // 
            this.GoloCasaM.Location = new System.Drawing.Point(12, 261);
            this.GoloCasaM.Name = "GoloCasaM";
            this.GoloCasaM.Size = new System.Drawing.Size(38, 23);
            this.GoloCasaM.TabIndex = 4;
            this.GoloCasaM.Text = "button1";
            this.GoloCasaM.UseVisualStyleBackColor = true;
            this.GoloCasaM.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoloCasaMen
            // 
            this.GoloCasaMen.Location = new System.Drawing.Point(74, 261);
            this.GoloCasaMen.Name = "GoloCasaMen";
            this.GoloCasaMen.Size = new System.Drawing.Size(38, 23);
            this.GoloCasaMen.TabIndex = 5;
            this.GoloCasaMen.Text = "button2";
            this.GoloCasaMen.UseVisualStyleBackColor = true;
            this.GoloCasaMen.Click += new System.EventHandler(this.GoloCasaMen_Click);
            // 
            // GoloForaMe
            // 
            this.GoloForaMe.Location = new System.Drawing.Point(741, 297);
            this.GoloForaMe.Name = "GoloForaMe";
            this.GoloForaMe.Size = new System.Drawing.Size(38, 23);
            this.GoloForaMe.TabIndex = 7;
            this.GoloForaMe.Text = "button2";
            this.GoloForaMe.UseVisualStyleBackColor = true;
            this.GoloForaMe.Click += new System.EventHandler(this.GoloForaMe_Click);
            // 
            // GoloForaM
            // 
            this.GoloForaM.Location = new System.Drawing.Point(593, 297);
            this.GoloForaM.Name = "GoloForaM";
            this.GoloForaM.Size = new System.Drawing.Size(38, 23);
            this.GoloForaM.TabIndex = 6;
            this.GoloForaM.Text = "button1";
            this.GoloForaM.UseVisualStyleBackColor = true;
            this.GoloForaM.Click += new System.EventHandler(this.GoloForaM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoloForaMe);
            this.Controls.Add(this.GoloForaM);
            this.Controls.Add(this.GoloCasaMen);
            this.Controls.Add(this.GoloCasaM);
            this.Controls.Add(this.NomeEquipaF);
            this.Controls.Add(this.NomeEquipaC);
            this.Controls.Add(this.EquipaF);
            this.Controls.Add(this.EquipaC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EquipaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox EquipaC;
        private System.Windows.Forms.PictureBox EquipaF;
        private System.Windows.Forms.TextBox NomeEquipaC;
        private System.Windows.Forms.TextBox NomeEquipaF;
        private System.Windows.Forms.Button GoloCasaM;
        private System.Windows.Forms.Button GoloCasaMen;
        private System.Windows.Forms.Button GoloForaMe;
        private System.Windows.Forms.Button GoloForaM;
    }
}

