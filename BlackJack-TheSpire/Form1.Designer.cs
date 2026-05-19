namespace BlackJack_TheSpire
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
            this.coin = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.odds = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장및종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재도전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.룰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.get = new System.Windows.Forms.Label();
            this.foldbutten = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.deck_count = new System.Windows.Forms.Button();
            this.deck = new System.Windows.Forms.Label();
            this.playerhandpanel = new System.Windows.Forms.Panel();
            this.foldnum = new System.Windows.Forms.Label();
            this.slot1 = new System.Windows.Forms.Label();
            this.slot2 = new System.Windows.Forms.Label();
            this.slot3 = new System.Windows.Forms.Label();
            this.slot4 = new System.Windows.Forms.Label();
            this.slot5 = new System.Windows.Forms.Label();
            this.item1 = new System.Windows.Forms.Label();
            this.item2 = new System.Windows.Forms.Label();
            this.item3 = new System.Windows.Forms.Label();
            this.item4 = new System.Windows.Forms.Label();
            this.item5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coin.Location = new System.Drawing.Point(23, 47);
            this.coin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(176, 41);
            this.coin.TabIndex = 0;
            this.coin.Text = "금고 금액 띄울곳";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(23, 230);
            this.num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(97, 50);
            this.num.TabIndex = 2;
            this.num.Text = "숫자";
            // 
            // odds
            // 
            this.odds.Location = new System.Drawing.Point(123, 230);
            this.odds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.odds.Name = "odds";
            this.odds.Size = new System.Drawing.Size(85, 50);
            this.odds.TabIndex = 3;
            this.odds.Text = "배율";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.룰ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장및종료ToolStripMenuItem,
            this.재도전ToolStripMenuItem,
            this.게임종료ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 저장및종료ToolStripMenuItem
            // 
            this.저장및종료ToolStripMenuItem.Name = "저장및종료ToolStripMenuItem";
            this.저장및종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장및종료ToolStripMenuItem.Text = "재도전";
            // 
            // 재도전ToolStripMenuItem
            // 
            this.재도전ToolStripMenuItem.Name = "재도전ToolStripMenuItem";
            this.재도전ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.재도전ToolStripMenuItem.Text = "나가기";
            // 
            // 게임종료ToolStripMenuItem
            // 
            this.게임종료ToolStripMenuItem.Name = "게임종료ToolStripMenuItem";
            this.게임종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.게임종료ToolStripMenuItem.Text = "게임종료";
            // 
            // 룰ToolStripMenuItem
            // 
            this.룰ToolStripMenuItem.Name = "룰ToolStripMenuItem";
            this.룰ToolStripMenuItem.Size = new System.Drawing.Size(31, 22);
            this.룰ToolStripMenuItem.Text = "룰";
            this.룰ToolStripMenuItem.Click += new System.EventHandler(this.룰ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(919, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 149);
            this.label1.TabIndex = 5;
            this.label1.Text = "미션띄울곳";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(251, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 180);
            this.label2.TabIndex = 6;
            this.label2.Text = "아이템 띄울곳";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(23, 117);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(176, 39);
            this.score.TabIndex = 9;
            this.score.Text = "라운드 패스 점수\r\n이번라운드에서 번 금액 / 목표 금액 이런식";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(743, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 180);
            this.label4.TabIndex = 10;
            this.label4.Text = "보스 효과";
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(23, 304);
            this.get.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(186, 40);
            this.get.TabIndex = 12;
            this.get.Text = "받는 점수 :";
            // 
            // foldbutten
            // 
            this.foldbutten.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.foldbutten.Location = new System.Drawing.Point(0, 475);
            this.foldbutten.Margin = new System.Windows.Forms.Padding(2);
            this.foldbutten.Name = "foldbutten";
            this.foldbutten.Size = new System.Drawing.Size(111, 42);
            this.foldbutten.TabIndex = 15;
            this.foldbutten.Text = "폴드";
            this.foldbutten.UseVisualStyleBackColor = true;
            this.foldbutten.Click += new System.EventHandler(this.foldbutten_Click);
            // 
            // round
            // 
            this.round.Location = new System.Drawing.Point(23, 344);
            this.round.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(88, 50);
            this.round.TabIndex = 16;
            this.round.Text = "남은 턴";
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw.Location = new System.Drawing.Point(0, 413);
            this.draw.Margin = new System.Windows.Forms.Padding(2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(237, 46);
            this.draw.TabIndex = 17;
            this.draw.Text = "드로우";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stand.Location = new System.Drawing.Point(125, 475);
            this.stand.Margin = new System.Windows.Forms.Padding(2);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(111, 42);
            this.stand.TabIndex = 18;
            this.stand.Text = "스탠드";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // deck_count
            // 
            this.deck_count.Image = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck_count.Location = new System.Drawing.Point(935, 290);
            this.deck_count.Margin = new System.Windows.Forms.Padding(2);
            this.deck_count.Name = "deck_count";
            this.deck_count.Size = new System.Drawing.Size(146, 200);
            this.deck_count.TabIndex = 7;
            this.deck_count.Text = "button1";
            this.deck_count.UseVisualStyleBackColor = true;
            this.deck_count.Click += new System.EventHandler(this.deck_count_Click);
            // 
            // deck
            // 
            this.deck.Location = new System.Drawing.Point(1021, 34);
            this.deck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(53, 41);
            this.deck.TabIndex = 19;
            this.deck.Text = "카드";
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // playerhandpanel
            // 
            this.playerhandpanel.Location = new System.Drawing.Point(253, 290);
            this.playerhandpanel.Margin = new System.Windows.Forms.Padding(2);
            this.playerhandpanel.Name = "playerhandpanel";
            this.playerhandpanel.Size = new System.Drawing.Size(664, 207);
            this.playerhandpanel.TabIndex = 20;
            // 
            // foldnum
            // 
            this.foldnum.AutoSize = true;
            this.foldnum.Location = new System.Drawing.Point(146, 345);
            this.foldnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foldnum.Name = "foldnum";
            this.foldnum.Size = new System.Drawing.Size(38, 12);
            this.foldnum.TabIndex = 21;
            this.foldnum.Text = "label3";
            // 
            // slot1
            // 
            this.slot1.Location = new System.Drawing.Point(0, 0);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(100, 23);
            this.slot1.TabIndex = 4;
            // 
            // slot2
            // 
            this.slot2.Location = new System.Drawing.Point(0, 0);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(100, 23);
            this.slot2.TabIndex = 3;
            // 
            // slot3
            // 
            this.slot3.Location = new System.Drawing.Point(0, 0);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(100, 23);
            this.slot3.TabIndex = 2;
            // 
            // slot4
            // 
            this.slot4.Location = new System.Drawing.Point(0, 0);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(100, 23);
            this.slot4.TabIndex = 1;
            // 
            // slot5
            // 
            this.slot5.Location = new System.Drawing.Point(0, 0);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(100, 23);
            this.slot5.TabIndex = 0;
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(259, 60);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(90, 130);
            this.item1.TabIndex = 22;
            this.item1.Text = "슬롯1";
            this.item1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(355, 60);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(90, 130);
            this.item2.TabIndex = 23;
            this.item2.Text = "슬롯2";
            this.item2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3
            // 
            this.item3.Location = new System.Drawing.Point(451, 60);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(90, 130);
            this.item3.TabIndex = 24;
            this.item3.Text = "슬롯3";
            this.item3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item4
            // 
            this.item4.Location = new System.Drawing.Point(547, 60);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(90, 130);
            this.item4.TabIndex = 25;
            this.item4.Text = "슬롯4";
            this.item4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item5
            // 
            this.item5.Location = new System.Drawing.Point(643, 60);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(90, 130);
            this.item5.TabIndex = 26;
            this.item5.Text = "슬롯5";
            this.item5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 563);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.foldnum);
            this.Controls.Add(this.deck_count);
            this.Controls.Add(this.playerhandpanel);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.round);
            this.Controls.Add(this.foldbutten);
            this.Controls.Add(this.get);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odds);
            this.Controls.Add(this.num);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coin;
        private System.Windows.Forms.Label odds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장및종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재도전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게임종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 룰ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deck_count;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label get;
        private System.Windows.Forms.Button foldbutten;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label deck;
        private System.Windows.Forms.Panel playerhandpanel;
        private System.Windows.Forms.Label foldnum;
        private System.Windows.Forms.Label slot1;
        private System.Windows.Forms.Label slot2;
        private System.Windows.Forms.Label slot3;
        private System.Windows.Forms.Label slot4;
        private System.Windows.Forms.Label slot5;
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Label item4;
        private System.Windows.Forms.Label item5;
    }
}

