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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ending));
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
            this.result.Location = new System.Drawing.Point(283, 73);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(256, 76);
            this.result.TabIndex = 0;
            this.result.Text = "성공, 실패";
            // 
            // seedlbl
            // 
            this.seedlbl.Location = new System.Drawing.Point(256, 180);
            this.seedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seedlbl.Name = "seedlbl";
            this.seedlbl.Size = new System.Drawing.Size(130, 31);
            this.seedlbl.TabIndex = 1;
            this.seedlbl.Text = "시드라벨";
            // 
            // deck
            // 
            this.deck.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck.Location = new System.Drawing.Point(853, 328);
            this.deck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(135, 176);
            this.deck.TabIndex = 2;
            this.deck.TabStop = false;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.Location = new System.Drawing.Point(79, 269);
            this.scorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(224, 75);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "점수";
            // 
            // goalscorelbl
            // 
            this.goalscorelbl.Location = new System.Drawing.Point(478, 269);
            this.goalscorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goalscorelbl.Name = "goalscorelbl";
            this.goalscorelbl.Size = new System.Drawing.Size(290, 75);
            this.goalscorelbl.TabIndex = 4;
            this.goalscorelbl.Text = "목표점수";
            // 
            // ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.goalscorelbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.seedlbl);
            this.Controls.Add(this.result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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