
namespace Placar_Jogo_Futebol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goloc_plus = new System.Windows.Forms.Button();
            this.goloc_minus = new System.Windows.Forms.Button();
            this.golof_minus = new System.Windows.Forms.Button();
            this.golof_plus = new System.Windows.Forms.Button();
            this.NomeC = new System.Windows.Forms.Label();
            this.NomeF = new System.Windows.Forms.Label();
            this.GolosC = new System.Windows.Forms.Label();
            this.EquipaC = new System.Windows.Forms.PictureBox();
            this.EquipaF = new System.Windows.Forms.PictureBox();
            this.TempoJogo = new System.Windows.Forms.Label();
            this.GolosF = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ParteJogo = new System.Windows.Forms.Label();
            this.ComeçarJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaF)).BeginInit();
            this.SuspendLayout();
            // 
            // goloc_plus
            // 
            this.goloc_plus.BackColor = System.Drawing.Color.Transparent;
            this.goloc_plus.Enabled = false;
            this.goloc_plus.Location = new System.Drawing.Point(12, 415);
            this.goloc_plus.Name = "goloc_plus";
            this.goloc_plus.Size = new System.Drawing.Size(75, 23);
            this.goloc_plus.TabIndex = 0;
            this.goloc_plus.Text = "+";
            this.goloc_plus.UseVisualStyleBackColor = false;
            this.goloc_plus.Click += new System.EventHandler(this.goloc_plus_Click);
            // 
            // goloc_minus
            // 
            this.goloc_minus.BackColor = System.Drawing.Color.Transparent;
            this.goloc_minus.Enabled = false;
            this.goloc_minus.Location = new System.Drawing.Point(192, 415);
            this.goloc_minus.Name = "goloc_minus";
            this.goloc_minus.Size = new System.Drawing.Size(75, 23);
            this.goloc_minus.TabIndex = 1;
            this.goloc_minus.Text = "-";
            this.goloc_minus.UseVisualStyleBackColor = false;
            this.goloc_minus.Click += new System.EventHandler(this.goloc_minus_Click);
            // 
            // golof_minus
            // 
            this.golof_minus.BackColor = System.Drawing.Color.Transparent;
            this.golof_minus.Enabled = false;
            this.golof_minus.Location = new System.Drawing.Point(713, 415);
            this.golof_minus.Name = "golof_minus";
            this.golof_minus.Size = new System.Drawing.Size(75, 23);
            this.golof_minus.TabIndex = 3;
            this.golof_minus.Text = "-";
            this.golof_minus.UseVisualStyleBackColor = false;
            this.golof_minus.Click += new System.EventHandler(this.golof_minus_Click);
            // 
            // golof_plus
            // 
            this.golof_plus.BackColor = System.Drawing.Color.Transparent;
            this.golof_plus.Enabled = false;
            this.golof_plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.golof_plus.Location = new System.Drawing.Point(537, 415);
            this.golof_plus.Name = "golof_plus";
            this.golof_plus.Size = new System.Drawing.Size(75, 23);
            this.golof_plus.TabIndex = 2;
            this.golof_plus.Text = "+";
            this.golof_plus.UseVisualStyleBackColor = false;
            this.golof_plus.Click += new System.EventHandler(this.golof_plus_Click);
            // 
            // NomeC
            // 
            this.NomeC.AutoSize = true;
            this.NomeC.BackColor = System.Drawing.Color.Transparent;
            this.NomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomeC.Location = new System.Drawing.Point(96, 280);
            this.NomeC.Name = "NomeC";
            this.NomeC.Size = new System.Drawing.Size(88, 25);
            this.NomeC.TabIndex = 4;
            this.NomeC.Text = "Nacional";
            // 
            // NomeF
            // 
            this.NomeF.AutoSize = true;
            this.NomeF.BackColor = System.Drawing.Color.Transparent;
            this.NomeF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomeF.Location = new System.Drawing.Point(595, 280);
            this.NomeF.Name = "NomeF";
            this.NomeF.Size = new System.Drawing.Size(165, 25);
            this.NomeF.TabIndex = 5;
            this.NomeF.Text = "Académica Viseu";
            // 
            // GolosC
            // 
            this.GolosC.AutoSize = true;
            this.GolosC.BackColor = System.Drawing.Color.Transparent;
            this.GolosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GolosC.ForeColor = System.Drawing.SystemColors.Window;
            this.GolosC.Location = new System.Drawing.Point(125, 335);
            this.GolosC.Name = "GolosC";
            this.GolosC.Size = new System.Drawing.Size(29, 31);
            this.GolosC.TabIndex = 6;
            this.GolosC.Text = "0";
            // 
            // EquipaC
            // 
            this.EquipaC.Image = global::Placar_Jogo_Futebol.Properties.Resources.Nacional;
            this.EquipaC.Location = new System.Drawing.Point(56, 77);
            this.EquipaC.Name = "EquipaC";
            this.EquipaC.Size = new System.Drawing.Size(158, 172);
            this.EquipaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EquipaC.TabIndex = 8;
            this.EquipaC.TabStop = false;
            // 
            // EquipaF
            // 
            this.EquipaF.Image = global::Placar_Jogo_Futebol.Properties.Resources.Viseu;
            this.EquipaF.Location = new System.Drawing.Point(577, 77);
            this.EquipaF.Name = "EquipaF";
            this.EquipaF.Size = new System.Drawing.Size(183, 172);
            this.EquipaF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EquipaF.TabIndex = 9;
            this.EquipaF.TabStop = false;
            // 
            // TempoJogo
            // 
            this.TempoJogo.AutoSize = true;
            this.TempoJogo.BackColor = System.Drawing.Color.Transparent;
            this.TempoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoJogo.Location = new System.Drawing.Point(354, 123);
            this.TempoJogo.Name = "TempoJogo";
            this.TempoJogo.Size = new System.Drawing.Size(140, 54);
            this.TempoJogo.TabIndex = 10;
            this.TempoJogo.Text = "00:00";
            // 
            // GolosF
            // 
            this.GolosF.AutoSize = true;
            this.GolosF.BackColor = System.Drawing.Color.Transparent;
            this.GolosF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GolosF.ForeColor = System.Drawing.SystemColors.Window;
            this.GolosF.Location = new System.Drawing.Point(658, 335);
            this.GolosF.Name = "GolosF";
            this.GolosF.Size = new System.Drawing.Size(29, 31);
            this.GolosF.TabIndex = 11;
            this.GolosF.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ParteJogo
            // 
            this.ParteJogo.AutoSize = true;
            this.ParteJogo.BackColor = System.Drawing.Color.Transparent;
            this.ParteJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParteJogo.Location = new System.Drawing.Point(331, 77);
            this.ParteJogo.Name = "ParteJogo";
            this.ParteJogo.Size = new System.Drawing.Size(163, 46);
            this.ParteJogo.TabIndex = 12;
            this.ParteJogo.Text = "1ª Parte";
            // 
            // ComeçarJ
            // 
            this.ComeçarJ.BackColor = System.Drawing.Color.Transparent;
            this.ComeçarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComeçarJ.Location = new System.Drawing.Point(349, 330);
            this.ComeçarJ.Name = "ComeçarJ";
            this.ComeçarJ.Size = new System.Drawing.Size(159, 41);
            this.ComeçarJ.TabIndex = 13;
            this.ComeçarJ.Text = "Começar";
            this.ComeçarJ.UseVisualStyleBackColor = false;
            this.ComeçarJ.Click += new System.EventHandler(this.ComeçarJ_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComeçarJ);
            this.Controls.Add(this.ParteJogo);
            this.Controls.Add(this.GolosF);
            this.Controls.Add(this.TempoJogo);
            this.Controls.Add(this.EquipaF);
            this.Controls.Add(this.EquipaC);
            this.Controls.Add(this.GolosC);
            this.Controls.Add(this.NomeF);
            this.Controls.Add(this.NomeC);
            this.Controls.Add(this.golof_minus);
            this.Controls.Add(this.golof_plus);
            this.Controls.Add(this.goloc_minus);
            this.Controls.Add(this.goloc_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.EquipaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipaF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goloc_plus;
        private System.Windows.Forms.Button goloc_minus;
        private System.Windows.Forms.Button golof_minus;
        private System.Windows.Forms.Button golof_plus;
        private System.Windows.Forms.Label NomeC;
        private System.Windows.Forms.Label NomeF;
        private System.Windows.Forms.Label GolosC;
        private System.Windows.Forms.PictureBox EquipaC;
        private System.Windows.Forms.PictureBox EquipaF;
        private System.Windows.Forms.Label TempoJogo;
        private System.Windows.Forms.Label GolosF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ParteJogo;
        private System.Windows.Forms.Button ComeçarJ;
    }
}

