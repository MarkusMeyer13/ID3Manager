namespace ID3Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(79, 70);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(363, 39);
            this.tbArtist.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(79, 171);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(363, 39);
            this.tbTitle.TabIndex = 1;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(79, 272);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(363, 39);
            this.tbAlbum.TabIndex = 2;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(79, 474);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(363, 39);
            this.tbYear.TabIndex = 3;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(79, 373);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(363, 39);
            this.tbComment.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artist";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comment";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbArtist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

