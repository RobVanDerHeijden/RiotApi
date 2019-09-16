namespace RiotAPIWinForm
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
            this.btn_summonerName = new System.Windows.Forms.Button();
            this.lbl_summonerLevel = new System.Windows.Forms.Label();
            this.tbx_summonerName = new System.Windows.Forms.TextBox();
            this.lbl_summonerName = new System.Windows.Forms.Label();
            this.lbl_region = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_summonerName
            // 
            this.btn_summonerName.Location = new System.Drawing.Point(273, 147);
            this.btn_summonerName.Name = "btn_summonerName";
            this.btn_summonerName.Size = new System.Drawing.Size(263, 69);
            this.btn_summonerName.TabIndex = 0;
            this.btn_summonerName.Text = "SummonerName";
            this.btn_summonerName.UseVisualStyleBackColor = true;
            this.btn_summonerName.Click += new System.EventHandler(this.btn_summonerName_Click);
            // 
            // lbl_summonerLevel
            // 
            this.lbl_summonerLevel.AutoSize = true;
            this.lbl_summonerLevel.Location = new System.Drawing.Point(551, 294);
            this.lbl_summonerLevel.Name = "lbl_summonerLevel";
            this.lbl_summonerLevel.Size = new System.Drawing.Size(74, 17);
            this.lbl_summonerLevel.TabIndex = 1;
            this.lbl_summonerLevel.Text = "summlevel";
            // 
            // tbx_summonerName
            // 
            this.tbx_summonerName.Location = new System.Drawing.Point(273, 108);
            this.tbx_summonerName.Name = "tbx_summonerName";
            this.tbx_summonerName.Size = new System.Drawing.Size(117, 22);
            this.tbx_summonerName.TabIndex = 2;
            // 
            // lbl_summonerName
            // 
            this.lbl_summonerName.AutoSize = true;
            this.lbl_summonerName.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_summonerName.Location = new System.Drawing.Point(273, 82);
            this.lbl_summonerName.Name = "lbl_summonerName";
            this.lbl_summonerName.Size = new System.Drawing.Size(117, 17);
            this.lbl_summonerName.TabIndex = 3;
            this.lbl_summonerName.Text = "Summoner Name";
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_region.Location = new System.Drawing.Point(419, 82);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(53, 17);
            this.lbl_region.TabIndex = 5;
            this.lbl_region.Text = "Region";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_summonerName);
            this.Controls.Add(this.tbx_summonerName);
            this.Controls.Add(this.lbl_summonerLevel);
            this.Controls.Add(this.btn_summonerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_summonerName;
        private System.Windows.Forms.Label lbl_summonerLevel;
        private System.Windows.Forms.TextBox tbx_summonerName;
        private System.Windows.Forms.Label lbl_summonerName;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.TextBox textBox1;
    }
}

