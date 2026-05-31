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
            this.deck = new System.Windows.Forms.PictureBox();
            this.roundlbl = new System.Windows.Forms.Label();
            this.itemlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deck)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("휴먼옛체", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.result.Location = new System.Drawing.Point(357, 64);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(197, 57);
            this.result.TabIndex = 0;
            this.result.Text = "성공, 실패";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deck
            // 
            this.deck.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deck.Location = new System.Drawing.Point(788, 342);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(104, 132);
            this.deck.TabIndex = 2;
            this.deck.TabStop = false;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // roundlbl
            // 
            this.roundlbl.BackColor = System.Drawing.Color.Transparent;
            this.roundlbl.Font = new System.Drawing.Font("휴먼옛체", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roundlbl.ForeColor = System.Drawing.Color.White;
            this.roundlbl.Location = new System.Drawing.Point(356, 170);
            this.roundlbl.Name = "roundlbl";
            this.roundlbl.Size = new System.Drawing.Size(212, 71);
            this.roundlbl.TabIndex = 3;
            this.roundlbl.Text = "라운드";
            this.roundlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemlbl
            // 
            this.itemlbl.BackColor = System.Drawing.Color.Transparent;
            this.itemlbl.Font = new System.Drawing.Font("휴먼옛체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itemlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemlbl.Location = new System.Drawing.Point(180, 322);
            this.itemlbl.Name = "itemlbl";
            this.itemlbl.Size = new System.Drawing.Size(559, 186);
            this.itemlbl.TabIndex = 5;
            this.itemlbl.Text = "아이템 목록";
            // 
            // ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.엔딩화면;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 586);
            this.Controls.Add(this.itemlbl);
            this.Controls.Add(this.roundlbl);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.result);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ending";
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.ending_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.deck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox deck;
        private System.Windows.Forms.Label roundlbl;
        private System.Windows.Forms.Label itemlbl;
    }
}