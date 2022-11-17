namespace WindowsFormsApp1
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
            this.btnPic1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPic1
            // 
            this.btnPic1.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPic1.Location = new System.Drawing.Point(89, 241);
            this.btnPic1.Name = "btnPic1";
            this.btnPic1.Size = new System.Drawing.Size(84, 38);
            this.btnPic1.TabIndex = 0;
            this.btnPic1.Tag = "click";
            this.btnPic1.Text = "picture1";
            this.btnPic1.UseVisualStyleBackColor = false;
            this.btnPic1.Click += new System.EventHandler(this.btnPic1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.CadetBlue;
            this.btn2.Location = new System.Drawing.Point(334, 241);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "click";
            this.btn2.Text = "picture2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.CadetBlue;
            this.btn3.Location = new System.Drawing.Point(574, 241);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 38);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "click";
            this.btn3.Text = "picture3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // picbox2
            // 
            this.picbox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox2.Location = new System.Drawing.Point(299, 56);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(156, 151);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox2.TabIndex = 3;
            this.picbox2.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox1.Location = new System.Drawing.Point(64, 56);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(156, 151);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox1.TabIndex = 4;
            this.picbox1.TabStop = false;
            // 
            // picbox3
            // 
            this.picbox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox3.Location = new System.Drawing.Point(540, 56);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(156, 151);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox3.TabIndex = 5;
            this.picbox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 323);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnPic1);
            this.Name = "Form1";
            this.Tag = "click";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPic1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox3;
    }
}

