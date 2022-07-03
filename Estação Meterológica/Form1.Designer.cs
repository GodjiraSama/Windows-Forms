namespace Estação_Meterológica
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.relogio = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.data = new System.Windows.Forms.Label();
            this.forecast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture_forecast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_forecast)).BeginInit();
            this.SuspendLayout();
            // 
            // relogio
            // 
            this.relogio.AutoSize = true;
            this.relogio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.relogio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.relogio.Location = new System.Drawing.Point(346, 9);
            this.relogio.Name = "relogio";
            this.relogio.Size = new System.Drawing.Size(119, 37);
            this.relogio.TabIndex = 0;
            this.relogio.Text = "00:00:00";            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.data.Location = new System.Drawing.Point(659, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(129, 37);
            this.data.TabIndex = 1;
            this.data.Text = "01/01/01";
            // 
            // forecast
            // 
            this.forecast.AutoSize = true;
            this.forecast.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forecast.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.forecast.Location = new System.Drawing.Point(346, 68);
            this.forecast.Name = "forecast";
            this.forecast.Size = new System.Drawing.Size(115, 37);
            this.forecast.TabIndex = 2;
            this.forecast.Text = "Forecast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(49, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "00 ªC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(49, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "00%";
            // 
            // picture_forecast
            // 
            this.picture_forecast.Image = global::Estação_Meterológica.Properties.Resources.sun;
            this.picture_forecast.Location = new System.Drawing.Point(346, 148);
            this.picture_forecast.Name = "picture_forecast";
            this.picture_forecast.Size = new System.Drawing.Size(106, 98);
            this.picture_forecast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_forecast.TabIndex = 7;
            this.picture_forecast.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture_forecast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecast);
            this.Controls.Add(this.data);
            this.Controls.Add(this.relogio);
            this.Name = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_forecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label relogio;
        private System.Windows.Forms.Timer tempo;
        private Label data;
        private Label forecast;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox picture_forecast;
    }
}