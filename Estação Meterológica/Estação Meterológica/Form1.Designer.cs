
namespace Estação_Meterológica
{
    partial class TelaPrincipal
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
            this.Relógio1 = new System.Windows.Forms.Timer(this.components);
            this.Relógio = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Relógio1
            // 
            this.Relógio1.Enabled = true;
            this.Relógio1.Interval = 2;
            this.Relógio1.Tick += new System.EventHandler(this.Relógio1_Tick);
            // 
            // Relógio
            // 
            this.Relógio.AutoSize = true;
            this.Relógio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relógio.Location = new System.Drawing.Point(12, 9);
            this.Relógio.Name = "Relógio";
            this.Relógio.Size = new System.Drawing.Size(148, 31);
            this.Relógio.TabIndex = 0;
            this.Relógio.Text = "00 : 00 : 00";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(1365, 9);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(150, 31);
            this.Data.TabIndex = 1;
            this.Data.Text = "01/01/0000";
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 656);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Relógio);
            this.Name = "TelaPrincipal";
            this.Text = "Estação Meterológica";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Relógio1;
        private System.Windows.Forms.Label Relógio;
        private System.Windows.Forms.Label Data;
    }
}

