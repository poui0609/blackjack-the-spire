namespace BlackJack_TheSpire
{
    partial class start
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
            this.newbtn = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.Transparent;
            this.newbtn.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.시작_버튼;
            this.newbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newbtn.Location = new System.Drawing.Point(247, 168);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(262, 106);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "새로시작";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.시작_버튼;
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loading.Location = new System.Drawing.Point(247, 277);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(262, 106);
            this.loading.TabIndex = 1;
            this.loading.Text = "이어하기";
            this.loading.UseVisualStyleBackColor = false;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_TheSpire.Properties.Resources.시작배경1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.newbtn);
            this.Name = "start";
            this.Text = "start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.start_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button loading;
    }
}