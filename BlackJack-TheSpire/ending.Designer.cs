namespace BlackJack_TheSpire
{
    partial class ending
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
            this.result = new System.Windows.Forms.Label();
            this.seedlbl = new System.Windows.Forms.Label();
            this.deck = new System.Windows.Forms.PictureBox();
            this.scorelbl = new System.Windows.Forms.Label();
            this.goalscorelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deck)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(218, 55);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(197, 57);
            this.result.TabIndex = 0;
            this.result.Text = "성공, 실패";
            // 
            // seedlbl
            // 
            this.seedlbl.Location = new System.Drawing.Point(197, 135);
            this.seedlbl.Name = "seedlbl";
            this.seedlbl.Size = new System.Drawing.Size(100, 23);
            this.seedlbl.TabIndex = 1;
            this.seedlbl.Text = "시드라벨";
            // 
            // deck
            // 
            this.deck.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck.Location = new System.Drawing.Point(656, 246);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(104, 132);
            this.deck.TabIndex = 2;
            this.deck.TabStop = false;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.Location = new System.Drawing.Point(61, 202);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(172, 56);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "점수";
            // 
            // goalscorelbl
            // 
            this.goalscorelbl.Location = new System.Drawing.Point(368, 202);
            this.goalscorelbl.Name = "goalscorelbl";
            this.goalscorelbl.Size = new System.Drawing.Size(223, 56);
            this.goalscorelbl.TabIndex = 4;
            this.goalscorelbl.Text = "목표점수";
            // 
            // ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goalscorelbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.seedlbl);
            this.Controls.Add(this.result);
            this.Name = "ending";
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.ending_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.deck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label seedlbl;
        private System.Windows.Forms.PictureBox deck;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label goalscorelbl;
    }
}