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
            this.newbtn.Location = new System.Drawing.Point(232, 168);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(127, 45);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "새로시작";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(232, 251);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(99, 47);
            this.loading.TabIndex = 1;
            this.loading.Text = "이어하기";
            this.loading.UseVisualStyleBackColor = true;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.newbtn);
            this.Name = "start";
            this.Text = "start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button loading;
    }
}