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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coin = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.odds = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.나가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.카드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtype = new System.Windows.Forms.ToolStripComboBox();
            this.cbvalue = new System.Windows.Forms.ToolStripComboBox();
            this.카드추가ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.카드삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이템ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCombo = new System.Windows.Forms.ToolStripComboBox();
            this.addItem = new System.Windows.Forms.ToolStripTextBox();
            this.delItem = new System.Windows.Forms.ToolStripTextBox();
            this.score = new System.Windows.Forms.Label();
            this.get = new System.Windows.Forms.Label();
            this.foldbutten = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
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
            this.bosslbl = new System.Windows.Forms.Label();
            this.deck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coin.Location = new System.Drawing.Point(86, 87);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(213, 63);
            this.coin.TabIndex = 0;
            this.coin.Text = "금고 금액 띄울곳";
            this.coin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.num.Location = new System.Drawing.Point(86, 306);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(90, 57);
            this.num.TabIndex = 2;
            this.num.Text = "숫자";
            this.num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // odds
            // 
            this.odds.BackColor = System.Drawing.Color.Transparent;
            this.odds.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.odds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.odds.Location = new System.Drawing.Point(217, 306);
            this.odds.Name = "odds";
            this.odds.Size = new System.Drawing.Size(93, 57);
            this.odds.TabIndex = 3;
            this.odds.Text = "배율";
            this.odds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.추가ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1578, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.나가기ToolStripMenuItem,
            this.게임종료ToolStripMenuItem});
            this.설정ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 나가기ToolStripMenuItem
            // 
            this.나가기ToolStripMenuItem.Name = "나가기ToolStripMenuItem";
            this.나가기ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.나가기ToolStripMenuItem.Text = "나가기";
            this.나가기ToolStripMenuItem.Click += new System.EventHandler(this.나가기ToolStripMenuItem_Click);
            // 
            // 게임종료ToolStripMenuItem
            // 
            this.게임종료ToolStripMenuItem.Name = "게임종료ToolStripMenuItem";
            this.게임종료ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.게임종료ToolStripMenuItem.Text = "게임종료";
            this.게임종료ToolStripMenuItem.Click += new System.EventHandler(this.게임종료ToolStripMenuItem_Click_1);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.카드ToolStripMenuItem,
            this.아이템ToolStripMenuItem});
            this.추가ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.추가ToolStripMenuItem.Text = "추가";
            // 
            // 카드ToolStripMenuItem
            // 
            this.카드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtype,
            this.cbvalue,
            this.카드추가ToolStripMenuItem1,
            this.카드삭제ToolStripMenuItem});
            this.카드ToolStripMenuItem.Name = "카드ToolStripMenuItem";
            this.카드ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.카드ToolStripMenuItem.Text = "카드";
            // 
            // cbtype
            // 
            this.cbtype.Items.AddRange(new object[] {
            "Spade",
            "Club",
            "Diamond",
            "Heart"});
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 33);
            // 
            // cbvalue
            // 
            this.cbvalue.Items.AddRange(new object[] {
            "Ace",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King"});
            this.cbvalue.Name = "cbvalue";
            this.cbvalue.Size = new System.Drawing.Size(121, 33);
            // 
            // 카드추가ToolStripMenuItem1
            // 
            this.카드추가ToolStripMenuItem1.Name = "카드추가ToolStripMenuItem1";
            this.카드추가ToolStripMenuItem1.Size = new System.Drawing.Size(211, 34);
            this.카드추가ToolStripMenuItem1.Text = "추가";
            this.카드추가ToolStripMenuItem1.Click += new System.EventHandler(this.카드추가ToolStripMenuItem1_Click);
            // 
            // 카드삭제ToolStripMenuItem
            // 
            this.카드삭제ToolStripMenuItem.Name = "카드삭제ToolStripMenuItem";
            this.카드삭제ToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.카드삭제ToolStripMenuItem.Text = "삭제";
            this.카드삭제ToolStripMenuItem.Click += new System.EventHandler(this.카드삭제ToolStripMenuItem_Click);
            // 
            // 아이템ToolStripMenuItem
            // 
            this.아이템ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCombo,
            this.addItem,
            this.delItem});
            this.아이템ToolStripMenuItem.Name = "아이템ToolStripMenuItem";
            this.아이템ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.아이템ToolStripMenuItem.Text = "아이템";
            // 
            // ItemCombo
            // 
            this.ItemCombo.Name = "ItemCombo";
            this.ItemCombo.Size = new System.Drawing.Size(121, 33);
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(100, 31);
            this.addItem.Text = "추가";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // delItem
            // 
            this.delItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(100, 31);
            this.delItem.Text = "삭제";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.score.Location = new System.Drawing.Point(86, 195);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(224, 75);
            this.score.TabIndex = 9;
            this.score.Text = "라운드 패스 점수\r\n이번라운드에서 번 금액 / 목표 금액 이런식";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // get
            // 
            this.get.BackColor = System.Drawing.Color.Transparent;
            this.get.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.get.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.get.Location = new System.Drawing.Point(86, 399);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(224, 51);
            this.get.TabIndex = 12;
            this.get.Text = "받는 점수 :";
            this.get.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foldbutten
            // 
            this.foldbutten.BackColor = System.Drawing.Color.Transparent;
            this.foldbutten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.foldbutten.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.foldbutten.Image = global::BlackJack_TheSpire.Properties.Resources.버튼사진;
            this.foldbutten.Location = new System.Drawing.Point(60, 663);
            this.foldbutten.Name = "foldbutten";
            this.foldbutten.Size = new System.Drawing.Size(130, 69);
            this.foldbutten.TabIndex = 15;
            this.foldbutten.Text = "폴드";
            this.foldbutten.UseVisualStyleBackColor = false;
            this.foldbutten.Click += new System.EventHandler(this.foldbutten_Click);
            // 
            // round
            // 
            this.round.BackColor = System.Drawing.Color.Transparent;
            this.round.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.round.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.round.Location = new System.Drawing.Point(89, 495);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(87, 51);
            this.round.TabIndex = 16;
            this.round.Text = "남은 턴";
            this.round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.Transparent;
            this.draw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.draw.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.draw.Image = global::BlackJack_TheSpire.Properties.Resources.버튼사진;
            this.draw.Location = new System.Drawing.Point(60, 570);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(266, 66);
            this.draw.TabIndex = 17;
            this.draw.Text = "드로우";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // stand
            // 
            this.stand.BackColor = System.Drawing.Color.Transparent;
            this.stand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stand.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stand.Image = global::BlackJack_TheSpire.Properties.Resources.버튼사진;
            this.stand.Location = new System.Drawing.Point(196, 663);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(130, 69);
            this.stand.TabIndex = 18;
            this.stand.Text = "스탠드";
            this.stand.UseVisualStyleBackColor = false;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // playerhandpanel
            // 
            this.playerhandpanel.BackColor = System.Drawing.Color.Transparent;
            this.playerhandpanel.Location = new System.Drawing.Point(397, 399);
            this.playerhandpanel.Name = "playerhandpanel";
            this.playerhandpanel.Size = new System.Drawing.Size(924, 405);
            this.playerhandpanel.TabIndex = 20;
            // 
            // foldnum
            // 
            this.foldnum.BackColor = System.Drawing.Color.Transparent;
            this.foldnum.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.foldnum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.foldnum.Location = new System.Drawing.Point(220, 480);
            this.foldnum.Name = "foldnum";
            this.foldnum.Size = new System.Drawing.Size(90, 63);
            this.foldnum.TabIndex = 21;
            this.foldnum.Text = "폴드";
            this.foldnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.Transparent;
            this.item1.ForeColor = System.Drawing.Color.White;
            this.item1.Location = new System.Drawing.Point(394, 99);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(127, 183);
            this.item1.TabIndex = 22;
            this.item1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.Color.Transparent;
            this.item2.ForeColor = System.Drawing.Color.White;
            this.item2.Location = new System.Drawing.Point(544, 99);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(124, 183);
            this.item2.TabIndex = 23;
            this.item2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item3
            // 
            this.item3.BackColor = System.Drawing.Color.Transparent;
            this.item3.ForeColor = System.Drawing.Color.White;
            this.item3.Location = new System.Drawing.Point(693, 99);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(123, 183);
            this.item3.TabIndex = 24;
            this.item3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item4
            // 
            this.item4.BackColor = System.Drawing.Color.Transparent;
            this.item4.ForeColor = System.Drawing.Color.White;
            this.item4.Location = new System.Drawing.Point(837, 99);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(124, 183);
            this.item4.TabIndex = 25;
            this.item4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item5
            // 
            this.item5.BackColor = System.Drawing.Color.Transparent;
            this.item5.ForeColor = System.Drawing.Color.White;
            this.item5.Location = new System.Drawing.Point(984, 99);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(126, 183);
            this.item5.TabIndex = 26;
            this.item5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mission1
            // 
            this.Mission1.BackColor = System.Drawing.Color.Transparent;
            this.Mission1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mission1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mission1.Location = new System.Drawing.Point(1327, 165);
            this.Mission1.Name = "Mission1";
            this.Mission1.Size = new System.Drawing.Size(146, 68);
            this.Mission1.TabIndex = 27;
            this.Mission1.Text = "미션1";
            this.Mission1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mission2
            // 
            this.Mission2.BackColor = System.Drawing.Color.Transparent;
            this.Mission2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mission2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mission2.Location = new System.Drawing.Point(1327, 252);
            this.Mission2.Name = "Mission2";
            this.Mission2.Size = new System.Drawing.Size(146, 68);
            this.Mission2.TabIndex = 28;
            this.Mission2.Text = "미션2";
            this.Mission2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bosslbl
            // 
            this.bosslbl.BackColor = System.Drawing.Color.Transparent;
            this.bosslbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bosslbl.Location = new System.Drawing.Point(1143, 93);
            this.bosslbl.Name = "bosslbl";
            this.bosslbl.Size = new System.Drawing.Size(154, 228);
            this.bosslbl.TabIndex = 30;
            this.bosslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deck
            // 
            this.deck.BackColor = System.Drawing.Color.Transparent;
            this.deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deck.Location = new System.Drawing.Point(1262, 377);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(230, 354);
            this.deck.TabIndex = 31;
            this.deck.UseVisualStyleBackColor = false;
            this.deck.Click += new System.EventHandler(this.deck_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(724, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "아이템";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1185, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "디버프";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1379, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "미션";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.배경그림2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.bosslbl);
            this.Controls.Add(this.odds);
            this.Controls.Add(this.foldnum);
            this.Controls.Add(this.Mission2);
            this.Controls.Add(this.Mission1);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.playerhandpanel);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.round);
            this.Controls.Add(this.foldbutten);
            this.Controls.Add(this.get);
            this.Controls.Add(this.score);
            this.Controls.Add(this.num);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
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
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label get;
        private System.Windows.Forms.Button foldbutten;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button stand;
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
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbtype;
        private System.Windows.Forms.ToolStripComboBox cbvalue;
        private System.Windows.Forms.ToolStripMenuItem 아이템ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카드추가ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 카드삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ItemCombo;
        private System.Windows.Forms.ToolStripTextBox addItem;
        private System.Windows.Forms.ToolStripTextBox delItem;
        private System.Windows.Forms.Label bosslbl;
        private System.Windows.Forms.Button deck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
