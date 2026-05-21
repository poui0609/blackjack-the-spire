namespace BlackJack_TheSpire
{
    partial class store
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
            this.buy1 = new System.Windows.Forms.Label();
            this.buy2 = new System.Windows.Forms.Label();
            this.buy3 = new System.Windows.Forms.Label();
            this.selectbtn1 = new System.Windows.Forms.Button();
            this.selectbtn2 = new System.Windows.Forms.Button();
            this.selectbtn3 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.Button();
            this.draw1 = new System.Windows.Forms.Label();
            this.draw2 = new System.Windows.Forms.Label();
            this.draw3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.slot1 = new System.Windows.Forms.Label();
            this.itemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slot2 = new System.Windows.Forms.Label();
            this.slot3 = new System.Windows.Forms.Label();
            this.slot4 = new System.Windows.Forms.Label();
            this.slot5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buy1
            // 
            this.buy1.Location = new System.Drawing.Point(136, 10);
            this.buy1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(141, 67);
            this.buy1.TabIndex = 0;
            this.buy1.Text = "label1";
            this.buy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy2
            // 
            this.buy2.Location = new System.Drawing.Point(321, 10);
            this.buy2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(141, 67);
            this.buy2.TabIndex = 1;
            this.buy2.Text = "label2";
            this.buy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy3
            // 
            this.buy3.Location = new System.Drawing.Point(505, 10);
            this.buy3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(141, 67);
            this.buy3.TabIndex = 2;
            this.buy3.Text = "label3";
            this.buy3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectbtn1
            // 
            this.selectbtn1.Location = new System.Drawing.Point(171, 97);
            this.selectbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.selectbtn1.Name = "selectbtn1";
            this.selectbtn1.Size = new System.Drawing.Size(71, 33);
            this.selectbtn1.TabIndex = 3;
            this.selectbtn1.Text = "구매";
            this.selectbtn1.UseVisualStyleBackColor = true;
            this.selectbtn1.Click += new System.EventHandler(this.selectbtn1_Click);
            // 
            // selectbtn2
            // 
            this.selectbtn2.Location = new System.Drawing.Point(358, 97);
            this.selectbtn2.Margin = new System.Windows.Forms.Padding(2);
            this.selectbtn2.Name = "selectbtn2";
            this.selectbtn2.Size = new System.Drawing.Size(71, 33);
            this.selectbtn2.TabIndex = 4;
            this.selectbtn2.Text = "구매";
            this.selectbtn2.UseVisualStyleBackColor = true;
            this.selectbtn2.Click += new System.EventHandler(this.selectbtn2_Click);
            // 
            // selectbtn3
            // 
            this.selectbtn3.Location = new System.Drawing.Point(547, 97);
            this.selectbtn3.Margin = new System.Windows.Forms.Padding(2);
            this.selectbtn3.Name = "selectbtn3";
            this.selectbtn3.Size = new System.Drawing.Size(71, 33);
            this.selectbtn3.TabIndex = 5;
            this.selectbtn3.Text = "구매";
            this.selectbtn3.UseVisualStyleBackColor = true;
            this.selectbtn3.Click += new System.EventHandler(this.selectbtn3_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(533, 291);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(98, 35);
            this.pass.TabIndex = 6;
            this.pass.Text = "나가기";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // draw1
            // 
            this.draw1.Location = new System.Drawing.Point(136, 184);
            this.draw1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.draw1.Name = "draw1";
            this.draw1.Size = new System.Drawing.Size(141, 105);
            this.draw1.TabIndex = 7;
            this.draw1.Text = "카드\r\n얘네는 하나 뽑으면 하나만 남기고 없애야함\r\n\r\n";
            this.draw1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.draw1.Click += new System.EventHandler(this.drawLabel_Click);
            // 
            // draw2
            // 
            this.draw2.Location = new System.Drawing.Point(321, 184);
            this.draw2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.draw2.Name = "draw2";
            this.draw2.Size = new System.Drawing.Size(141, 105);
            this.draw2.TabIndex = 8;
            this.draw2.Text = "카드";
            this.draw2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.draw2.Click += new System.EventHandler(this.drawLabel_Click);
            // 
            // draw3
            // 
            this.draw3.Location = new System.Drawing.Point(513, 184);
            this.draw3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.draw3.Name = "draw3";
            this.draw3.Size = new System.Drawing.Size(141, 105);
            this.draw3.TabIndex = 9;
            this.draw3.Text = "카드";
            this.draw3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.draw3.Click += new System.EventHandler(this.drawLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "코인:";
            // 
            // slot1
            // 
            this.slot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slot1.ContextMenuStrip = this.itemMenu;
            this.slot1.Location = new System.Drawing.Point(12, 66);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(80, 35);
            this.slot1.TabIndex = 11;
            this.slot1.Text = "슬롯1";
            this.slot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slot_MouseDown);
            // 
            // itemMenu
            // 
            this.itemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem});
            this.itemMenu.Name = "itemMenu";
            this.itemMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // slot2
            // 
            this.slot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slot2.ContextMenuStrip = this.itemMenu;
            this.slot2.Location = new System.Drawing.Point(12, 125);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(80, 35);
            this.slot2.TabIndex = 12;
            this.slot2.Text = "슬롯2";
            this.slot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slot_MouseDown);
            // 
            // slot3
            // 
            this.slot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slot3.ContextMenuStrip = this.itemMenu;
            this.slot3.Location = new System.Drawing.Point(12, 184);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(80, 35);
            this.slot3.TabIndex = 13;
            this.slot3.Text = "슬롯3";
            this.slot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slot_MouseDown);
            // 
            // slot4
            // 
            this.slot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slot4.ContextMenuStrip = this.itemMenu;
            this.slot4.Location = new System.Drawing.Point(12, 240);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(80, 35);
            this.slot4.TabIndex = 14;
            this.slot4.Text = "슬롯4";
            this.slot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slot_MouseDown);
            // 
            // slot5
            // 
            this.slot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slot5.ContextMenuStrip = this.itemMenu;
            this.slot5.Location = new System.Drawing.Point(12, 296);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(80, 35);
            this.slot5.TabIndex = 15;
            this.slot5.Text = "슬롯5";
            this.slot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slot_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "우클릭으로\r\n삭제 가능";
            // 
            // store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.draw3);
            this.Controls.Add(this.draw2);
            this.Controls.Add(this.draw1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.selectbtn3);
            this.Controls.Add(this.selectbtn2);
            this.Controls.Add(this.selectbtn1);
            this.Controls.Add(this.buy3);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.buy1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "store";
            this.Text = "store";
            this.Load += new System.EventHandler(this.store_Load);
            this.itemMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buy1;
        private System.Windows.Forms.Label buy2;
        private System.Windows.Forms.Label buy3;
        private System.Windows.Forms.Button selectbtn1;
        private System.Windows.Forms.Button selectbtn2;
        private System.Windows.Forms.Button selectbtn3;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.Label draw1;
        private System.Windows.Forms.Label draw2;
        private System.Windows.Forms.Label draw3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label slot1;
        private System.Windows.Forms.Label slot2;
        private System.Windows.Forms.Label slot3;
        private System.Windows.Forms.Label slot4;
        private System.Windows.Forms.Label slot5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip itemMenu;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}