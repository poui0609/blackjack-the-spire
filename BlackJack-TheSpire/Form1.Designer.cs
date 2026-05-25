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
            this.components = new System.ComponentModel.Container();
            this.coin = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.odds = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.나가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.item1 = new System.Windows.Forms.Label();
            this.item2 = new System.Windows.Forms.Label();
            this.item3 = new System.Windows.Forms.Label();
            this.item4 = new System.Windows.Forms.Label();
            this.item5 = new System.Windows.Forms.Label();
            this.Mission1 = new System.Windows.Forms.Label();
            this.Mission2 = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coin.Location = new System.Drawing.Point(33, 70);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(251, 62);
            this.coin.TabIndex = 0;
            this.coin.Text = "금고 금액 띄울곳";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(33, 345);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(139, 75);
            this.num.TabIndex = 2;
            this.num.Text = "숫자";
            // 
            // odds
            // 
            this.odds.Location = new System.Drawing.Point(176, 345);
            this.odds.Name = "odds";
            this.odds.Size = new System.Drawing.Size(121, 75);
            this.odds.TabIndex = 3;
            this.odds.Text = "배율";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.룰ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2254, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.나가기ToolStripMenuItem,
            this.게임종료ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 나가기ToolStripMenuItem
            // 
            this.나가기ToolStripMenuItem.Name = "나가기ToolStripMenuItem";
            this.나가기ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.나가기ToolStripMenuItem.Text = "나가기";
            this.나가기ToolStripMenuItem.Click += new System.EventHandler(this.나가기ToolStripMenuItem_Click);
            // 
            // 게임종료ToolStripMenuItem
            // 
            this.게임종료ToolStripMenuItem.Name = "게임종료ToolStripMenuItem";
            this.게임종료ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.게임종료ToolStripMenuItem.Text = "게임종료";
            this.게임종료ToolStripMenuItem.Click += new System.EventHandler(this.게임종료ToolStripMenuItem_Click);
            // 
            // 룰ToolStripMenuItem
            // 
            this.룰ToolStripMenuItem.Name = "룰ToolStripMenuItem";
            this.룰ToolStripMenuItem.Size = new System.Drawing.Size(46, 29);
            this.룰ToolStripMenuItem.Text = "룰";
            this.룰ToolStripMenuItem.Click += new System.EventHandler(this.룰ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1313, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 224);
            this.label1.TabIndex = 5;
            this.label1.Text = "미션띄울곳";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(359, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 270);
            this.label2.TabIndex = 6;
            this.label2.Text = "아이템 띄울곳";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(33, 176);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(251, 58);
            this.score.TabIndex = 9;
            this.score.Text = "라운드 패스 점수\r\n이번라운드에서 번 금액 / 목표 금액 이런식";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1061, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 270);
            this.label4.TabIndex = 10;
            this.label4.Text = "보스 효과";
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(33, 456);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(266, 60);
            this.get.TabIndex = 12;
            this.get.Text = "받는 점수 :";
            // 
            // foldbutten
            // 
            this.foldbutten.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.foldbutten.Location = new System.Drawing.Point(0, 712);
            this.foldbutten.Name = "foldbutten";
            this.foldbutten.Size = new System.Drawing.Size(159, 63);
            this.foldbutten.TabIndex = 15;
            this.foldbutten.Text = "폴드";
            this.foldbutten.UseVisualStyleBackColor = true;
            this.foldbutten.Click += new System.EventHandler(this.foldbutten_Click);
            // 
            // round
            // 
            this.round.Location = new System.Drawing.Point(33, 516);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(126, 75);
            this.round.TabIndex = 16;
            this.round.Text = "남은 턴";
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw.Location = new System.Drawing.Point(0, 620);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(339, 69);
            this.draw.TabIndex = 17;
            this.draw.Text = "드로우";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stand.Location = new System.Drawing.Point(179, 712);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(159, 63);
            this.stand.TabIndex = 18;
            this.stand.Text = "스탠드";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // deck_count
            // 
            this.deck_count.Image = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck_count.Location = new System.Drawing.Point(1336, 435);
            this.deck_count.Name = "deck_count";
            this.deck_count.Size = new System.Drawing.Size(200, 300);
            this.deck_count.TabIndex = 7;
            this.deck_count.Text = "button1";
            this.deck_count.UseVisualStyleBackColor = true;
            this.deck_count.Click += new System.EventHandler(this.deck_count_Click);
            // 
            // deck
            // 
            this.deck.Location = new System.Drawing.Point(1459, 51);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(76, 62);
            this.deck.TabIndex = 19;
            this.deck.Text = "카드";
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // playerhandpanel
            // 
            this.playerhandpanel.Location = new System.Drawing.Point(361, 398);
            this.playerhandpanel.Name = "playerhandpanel";
            this.playerhandpanel.Size = new System.Drawing.Size(949, 435);
            this.playerhandpanel.TabIndex = 20;
            // 
            // foldnum
            // 
            this.foldnum.AutoSize = true;
            this.foldnum.Location = new System.Drawing.Point(209, 518);
            this.foldnum.Name = "foldnum";
            this.foldnum.Size = new System.Drawing.Size(54, 18);
            this.foldnum.TabIndex = 21;
            this.foldnum.Text = "label3";
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(370, 90);
            this.item1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(129, 195);
            this.item1.TabIndex = 22;
            this.item1.Text = "슬롯1";
            this.item1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(507, 90);
            this.item2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(129, 195);
            this.item2.TabIndex = 23;
            this.item2.Text = "슬롯2";
            this.item2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3
            // 
            this.item3.Location = new System.Drawing.Point(644, 90);
            this.item3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(129, 195);
            this.item3.TabIndex = 24;
            this.item3.Text = "슬롯3";
            this.item3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item4
            // 
            this.item4.Location = new System.Drawing.Point(781, 90);
            this.item4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(129, 195);
            this.item4.TabIndex = 25;
            this.item4.Text = "슬롯4";
            this.item4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item5
            // 
            this.item5.Location = new System.Drawing.Point(919, 90);
            this.item5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(129, 195);
            this.item5.TabIndex = 26;
            this.item5.Text = "슬롯5";
            this.item5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mission1
            // 
            this.Mission1.Location = new System.Drawing.Point(1327, 147);
            this.Mission1.Name = "Mission1";
            this.Mission1.Size = new System.Drawing.Size(214, 75);
            this.Mission1.TabIndex = 27;
            this.Mission1.Text = "미션1";
            this.Mission1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mission2
            // 
            this.Mission2.Location = new System.Drawing.Point(1327, 238);
            this.Mission2.Name = "Mission2";
            this.Mission2.Size = new System.Drawing.Size(214, 75);
            this.Mission2.TabIndex = 28;
            this.Mission2.Text = "미션2";
            this.Mission2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2254, 1266);
            this.Controls.Add(this.Mission2);
            this.Controls.Add(this.Mission1);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem 나가기ToolStripMenuItem;
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
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Label item4;
        private System.Windows.Forms.Label item5;
        private System.Windows.Forms.Label Mission1;
        private System.Windows.Forms.Label Mission2;
        private System.Windows.Forms.Timer moveTimer;
    }
}
