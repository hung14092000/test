namespace bai6
{
    partial class frmTapLuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTapLuyen));
            this.picHaTa = new System.Windows.Forms.PictureBox();
            this.picNangTa = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblDesignBy = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).BeginInit();
            this.SuspendLayout();
            // 
            // picHaTa
            // 
            this.picHaTa.Image = ((System.Drawing.Image)(resources.GetObject("picHaTa.Image")));
            this.picHaTa.Location = new System.Drawing.Point(30, 130);
            this.picHaTa.Name = "picHaTa";
            this.picHaTa.Size = new System.Drawing.Size(341, 275);
            this.picHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHaTa.TabIndex = 0;
            this.picHaTa.TabStop = false;
            // 
            // picNangTa
            // 
            this.picNangTa.Image = ((System.Drawing.Image)(resources.GetObject("picNangTa.Image")));
            this.picNangTa.Location = new System.Drawing.Point(30, 130);
            this.picNangTa.Name = "picNangTa";
            this.picNangTa.Size = new System.Drawing.Size(341, 275);
            this.picNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNangTa.TabIndex = 1;
            this.picNangTa.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nhập tên Sếp vào đây: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.Location = new System.Drawing.Point(213, 104);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(164, 20);
            this.chkMusic.TabIndex = 4;
            this.chkMusic.Text = "Làm Tí Music đi sếp";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Silver;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.Color.Red;
            this.btnClick.Location = new System.Drawing.Point(30, 428);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(341, 57);
            this.btnClick.TabIndex = 5;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblDesignBy
            // 
            this.lblDesignBy.AutoSize = true;
            this.lblDesignBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignBy.Location = new System.Drawing.Point(30, 524);
            this.lblDesignBy.Name = "lblDesignBy";
            this.lblDesignBy.Size = new System.Drawing.Size(127, 32);
            this.lblDesignBy.TabIndex = 6;
            this.lblDesignBy.Text = "Designed by: \r\nPhạm Ngọc Hưng";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(163, 515);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(113, 41);
            this.lblCount.TabIndex = 7;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(296, 533);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTapLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(389, 575);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDesignBy);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNangTa);
            this.Controls.Add(this.picHaTa);
            this.Name = "frmTapLuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tập luyện";
            this.Load += new System.EventHandler(this.frmTapLuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHaTa;
        private System.Windows.Forms.PictureBox picNangTa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblDesignBy;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnThoat;
    }
}

