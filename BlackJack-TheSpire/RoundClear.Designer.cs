namespace BlackJack_TheSpire
{
    partial class RoundClear
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
            this.lblRound = new System.Windows.Forms.Label();
            this.lblCoin = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRoundDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRound.Location = new System.Drawing.Point(334, 137);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(72, 40);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "몇 라운드 ";
            // 
            // lblCoin
            // 
            this.lblCoin.BackColor = System.Drawing.Color.Transparent;
            this.lblCoin.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCoin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoin.Location = new System.Drawing.Point(455, 304);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(82, 41);
            this.lblCoin.TabIndex = 3;
            this.lblCoin.Text = "획득 코인";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(297, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(204, 38);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblRoundDetail
            // 
            this.lblRoundDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundDetail.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoundDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoundDetail.Location = new System.Drawing.Point(407, 190);
            this.lblRoundDetail.Name = "lblRoundDetail";
            this.lblRoundDetail.Size = new System.Drawing.Size(94, 75);
            this.lblRoundDetail.TabIndex = 6;
            this.lblRoundDetail.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(508, 208);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 46);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label2";
            // 
            // RoundClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.ChatGPT_Image_2026년_5월_29일_오후_05_04_261;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoundDetail);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.lblRound);
            this.DoubleBuffered = true;
            this.Name = "RoundClear";
            this.Text = "RoundClear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRoundDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
    }
}