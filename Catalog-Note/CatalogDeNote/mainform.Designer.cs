
namespace CatalogDeNote
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.studentibtn = new System.Windows.Forms.Button();
            this.catalogbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iesirebtn = new System.Windows.Forms.Button();
            this.disciplinebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raportbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentibtn
            // 
            this.studentibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.studentibtn.FlatAppearance.BorderSize = 0;
            this.studentibtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.studentibtn.ForeColor = System.Drawing.Color.White;
            this.studentibtn.Image = ((System.Drawing.Image)(resources.GetObject("studentibtn.Image")));
            this.studentibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentibtn.Location = new System.Drawing.Point(13, 87);
            this.studentibtn.Name = "studentibtn";
            this.studentibtn.Size = new System.Drawing.Size(142, 40);
            this.studentibtn.TabIndex = 2;
            this.studentibtn.TabStop = false;
            this.studentibtn.Text = "Studenți";
            this.studentibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentibtn.UseVisualStyleBackColor = false;
            this.studentibtn.Click += new System.EventHandler(this.studentibtn_Click);
            // 
            // catalogbtn
            // 
            this.catalogbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.catalogbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.catalogbtn.FlatAppearance.BorderSize = 0;
            this.catalogbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.catalogbtn.ForeColor = System.Drawing.Color.White;
            this.catalogbtn.Image = ((System.Drawing.Image)(resources.GetObject("catalogbtn.Image")));
            this.catalogbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogbtn.Location = new System.Drawing.Point(13, 21);
            this.catalogbtn.Name = "catalogbtn";
            this.catalogbtn.Size = new System.Drawing.Size(142, 40);
            this.catalogbtn.TabIndex = 0;
            this.catalogbtn.TabStop = false;
            this.catalogbtn.Text = "Catalog";
            this.catalogbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.catalogbtn.UseVisualStyleBackColor = false;
            this.catalogbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.raportbtn);
            this.panel1.Controls.Add(this.iesirebtn);
            this.panel1.Controls.Add(this.disciplinebtn);
            this.panel1.Controls.Add(this.catalogbtn);
            this.panel1.Controls.Add(this.studentibtn);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 408);
            this.panel1.TabIndex = 5;
            // 
            // iesirebtn
            // 
            this.iesirebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.iesirebtn.FlatAppearance.BorderSize = 0;
            this.iesirebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.iesirebtn.ForeColor = System.Drawing.Color.White;
            this.iesirebtn.Image = ((System.Drawing.Image)(resources.GetObject("iesirebtn.Image")));
            this.iesirebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iesirebtn.Location = new System.Drawing.Point(13, 340);
            this.iesirebtn.Name = "iesirebtn";
            this.iesirebtn.Size = new System.Drawing.Size(142, 40);
            this.iesirebtn.TabIndex = 6;
            this.iesirebtn.TabStop = false;
            this.iesirebtn.Text = "Ieșire";
            this.iesirebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iesirebtn.UseVisualStyleBackColor = false;
            this.iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click);
            // 
            // disciplinebtn
            // 
            this.disciplinebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.disciplinebtn.FlatAppearance.BorderSize = 0;
            this.disciplinebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.disciplinebtn.ForeColor = System.Drawing.Color.White;
            this.disciplinebtn.Image = ((System.Drawing.Image)(resources.GetObject("disciplinebtn.Image")));
            this.disciplinebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disciplinebtn.Location = new System.Drawing.Point(13, 157);
            this.disciplinebtn.Name = "disciplinebtn";
            this.disciplinebtn.Size = new System.Drawing.Size(142, 40);
            this.disciplinebtn.TabIndex = 5;
            this.disciplinebtn.TabStop = false;
            this.disciplinebtn.Text = "Discipline";
            this.disciplinebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.disciplinebtn.UseVisualStyleBackColor = false;
            this.disciplinebtn.Click += new System.EventHandler(this.disciplinebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 408);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // raportbtn
            // 
            this.raportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.raportbtn.FlatAppearance.BorderSize = 0;
            this.raportbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.raportbtn.ForeColor = System.Drawing.Color.White;
            this.raportbtn.Image = ((System.Drawing.Image)(resources.GetObject("raportbtn.Image")));
            this.raportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raportbtn.Location = new System.Drawing.Point(12, 227);
            this.raportbtn.Name = "raportbtn";
            this.raportbtn.Size = new System.Drawing.Size(142, 40);
            this.raportbtn.TabIndex = 7;
            this.raportbtn.TabStop = false;
            this.raportbtn.Text = "Raport";
            this.raportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raportbtn.UseVisualStyleBackColor = false;
            this.raportbtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button studentibtn;
        private System.Windows.Forms.Button catalogbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button disciplinebtn;
        private System.Windows.Forms.Button iesirebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button raportbtn;
    }
}

