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
            this.buy1 = new System.Windows.Forms.Label();
            this.buy2 = new System.Windows.Forms.Label();
            this.buy3 = new System.Windows.Forms.Label();
            this.selectbtn1 = new System.Windows.Forms.Button();
            this.selectbtn2 = new System.Windows.Forms.Button();
            this.selectbtn3 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buy1
            // 
            this.buy1.Location = new System.Drawing.Point(38, 36);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(200, 100);
            this.buy1.TabIndex = 0;
            this.buy1.Text = "label1";
            // 
            // buy2
            // 
            this.buy2.Location = new System.Drawing.Point(303, 36);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(200, 100);
            this.buy2.TabIndex = 1;
            this.buy2.Text = "label2";
            // 
            // buy3
            // 
            this.buy3.Location = new System.Drawing.Point(565, 36);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(200, 100);
            this.buy3.TabIndex = 2;
            this.buy3.Text = "label3";
            // 
            // selectbtn1
            // 
            this.selectbtn1.Location = new System.Drawing.Point(86, 166);
            this.selectbtn1.Name = "selectbtn1";
            this.selectbtn1.Size = new System.Drawing.Size(100, 50);
            this.selectbtn1.TabIndex = 3;
            this.selectbtn1.Text = "구매";
            this.selectbtn1.UseVisualStyleBackColor = true;
            this.selectbtn1.Click += new System.EventHandler(this.selectbtn1_Click);
            // 
            // selectbtn2
            // 
            this.selectbtn2.Location = new System.Drawing.Point(342, 166);
            this.selectbtn2.Name = "selectbtn2";
            this.selectbtn2.Size = new System.Drawing.Size(100, 50);
            this.selectbtn2.TabIndex = 4;
            this.selectbtn2.Text = "구매";
            this.selectbtn2.UseVisualStyleBackColor = true;
            this.selectbtn2.Click += new System.EventHandler(this.selectbtn2_Click);
            // 
            // selectbtn3
            // 
            this.selectbtn3.Location = new System.Drawing.Point(613, 166);
            this.selectbtn3.Name = "selectbtn3";
            this.selectbtn3.Size = new System.Drawing.Size(100, 50);
            this.selectbtn3.TabIndex = 5;
            this.selectbtn3.Text = "구매";
            this.selectbtn3.UseVisualStyleBackColor = true;
            this.selectbtn3.Click += new System.EventHandler(this.selectbtn3_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(626, 456);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(139, 52);
            this.pass.TabIndex = 6;
            this.pass.Text = "나가기";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 158);
            this.label1.TabIndex = 7;
            this.label1.Text = "카드\r\n얘네는 하나 뽑으면 하나만 남기고 없애야함\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(285, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 158);
            this.label2.TabIndex = 8;
            this.label2.Text = "카드";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(565, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 158);
            this.label3.TabIndex = 9;
            this.label3.Text = "카드";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.selectbtn3);
            this.Controls.Add(this.selectbtn2);
            this.Controls.Add(this.selectbtn1);
            this.Controls.Add(this.buy3);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.buy1);
            this.Name = "store";
            this.Text = "store";
            this.Load += new System.EventHandler(this.store_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label buy1;
        private System.Windows.Forms.Label buy2;
        private System.Windows.Forms.Label buy3;
        private System.Windows.Forms.Button selectbtn1;
        private System.Windows.Forms.Button selectbtn2;
        private System.Windows.Forms.Button selectbtn3;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}