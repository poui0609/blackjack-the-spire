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
            this.safe = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.get = new System.Windows.Forms.Label();
            this.deck = new System.Windows.Forms.Button();
            this.foldbutten = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // safe
            // 
            this.safe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.safe.Location = new System.Drawing.Point(33, 71);
            this.safe.Name = "safe";
            this.safe.Size = new System.Drawing.Size(353, 78);
            this.safe.TabIndex = 0;
            this.safe.Text = "금고 금액 띄울곳";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(33, 421);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(139, 75);
            this.num.TabIndex = 2;
            this.num.Text = "숫자";
            // 
            // odds
            // 
            this.odds.Location = new System.Drawing.Point(264, 421);
            this.odds.Name = "odds";
            this.odds.Size = new System.Drawing.Size(122, 75);
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
            this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
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
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 저장및종료ToolStripMenuItem
            // 
            this.저장및종료ToolStripMenuItem.Name = "저장및종료ToolStripMenuItem";
            this.저장및종료ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.저장및종료ToolStripMenuItem.Text = "재도전";
            // 
            // 재도전ToolStripMenuItem
            // 
            this.재도전ToolStripMenuItem.Name = "재도전ToolStripMenuItem";
            this.재도전ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.재도전ToolStripMenuItem.Text = "나가기";
            // 
            // 게임종료ToolStripMenuItem
            // 
            this.게임종료ToolStripMenuItem.Name = "게임종료ToolStripMenuItem";
            this.게임종료ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.게임종료ToolStripMenuItem.Text = "게임종료";
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
            this.label1.Location = new System.Drawing.Point(1615, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 456);
            this.label1.TabIndex = 5;
            this.label1.Text = "미션띄울곳";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(483, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(785, 270);
            this.label2.TabIndex = 6;
            this.label2.Text = "아이템 띄울곳";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(480, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1082, 573);
            this.label3.TabIndex = 8;
            this.label3.Text = "자기 카드 보여줄곳";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(33, 205);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(353, 74);
            this.score.TabIndex = 9;
            this.score.Text = "라운드 패스 점수\r\n이번라운드에서 번 금액 / 목표 금액 이런식";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1313, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 270);
            this.label4.TabIndex = 10;
            this.label4.Text = "보스 효과";
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(33, 546);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(353, 60);
            this.get.TabIndex = 12;
            this.get.Text = "받는 점수 :";
            // 
            // deck
            // 
            this.deck.Image = global::BlackJack_TheSpire.Properties.Resources.카드_뒷면;
            this.deck.Location = new System.Drawing.Point(1629, 608);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(209, 300);
            this.deck.TabIndex = 7;
            this.deck.Text = "button1";
            this.deck.UseVisualStyleBackColor = true;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // foldbutten
            // 
            this.foldbutten.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.foldbutten.Location = new System.Drawing.Point(36, 845);
            this.foldbutten.Name = "foldbutten";
            this.foldbutten.Size = new System.Drawing.Size(159, 63);
            this.foldbutten.TabIndex = 15;
            this.foldbutten.Text = "폴드";
            this.foldbutten.UseVisualStyleBackColor = true;
            this.foldbutten.Click += new System.EventHandler(this.foldbutten_Click);
            // 
            // turn
            // 
            this.turn.Location = new System.Drawing.Point(33, 608);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(353, 75);
            this.turn.TabIndex = 16;
            this.turn.Text = "남은 턴";
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw.Location = new System.Drawing.Point(36, 722);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(350, 63);
            this.draw.TabIndex = 17;
            this.draw.Text = "드로우";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stand.Location = new System.Drawing.Point(227, 845);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(159, 63);
            this.stand.TabIndex = 18;
            this.stand.Text = "스탠드";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.foldbutten);
            this.Controls.Add(this.get);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odds);
            this.Controls.Add(this.num);
            this.Controls.Add(this.safe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label safe;
        private System.Windows.Forms.Label odds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장및종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재도전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게임종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 룰ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label get;
        private System.Windows.Forms.Button foldbutten;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button stand;
    }
}

