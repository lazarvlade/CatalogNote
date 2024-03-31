
namespace CatalogDeNote
{
    partial class studentiform
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
            System.Windows.Forms.Button iesirebtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentiform));
            System.Windows.Forms.Button stergerebtn;
            System.Windows.Forms.Button modificarebtn;
            System.Windows.Forms.Button adaugarebtn;
            this.listastudenti = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codtxt = new System.Windows.Forms.Label();
            this.creditetxt = new System.Windows.Forms.Label();
            this.denumiretxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clasastudenti = new System.Windows.Forms.GroupBox();
            this.listacod = new System.Windows.Forms.ListBox();
            this.Titlu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            modificarebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.clasastudenti.SuspendLayout();
            this.SuspendLayout();
            // 
            // iesirebtn
            // 
            iesirebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            iesirebtn.FlatAppearance.BorderSize = 0;
            iesirebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            iesirebtn.ForeColor = System.Drawing.Color.White;
            iesirebtn.Image = ((System.Drawing.Image)(resources.GetObject("iesirebtn.Image")));
            iesirebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iesirebtn.Location = new System.Drawing.Point(13, 340);
            iesirebtn.Name = "iesirebtn";
            iesirebtn.Size = new System.Drawing.Size(142, 40);
            iesirebtn.TabIndex = 5;
            iesirebtn.TabStop = false;
            iesirebtn.Text = "Ieșire";
            iesirebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iesirebtn.UseVisualStyleBackColor = false;
            iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click_2);
            // 
            // stergerebtn
            // 
            stergerebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            stergerebtn.FlatAppearance.BorderSize = 0;
            stergerebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            stergerebtn.ForeColor = System.Drawing.Color.White;
            stergerebtn.Image = ((System.Drawing.Image)(resources.GetObject("stergerebtn.Image")));
            stergerebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            stergerebtn.Location = new System.Drawing.Point(13, 157);
            stergerebtn.Name = "stergerebtn";
            stergerebtn.Size = new System.Drawing.Size(142, 40);
            stergerebtn.TabIndex = 4;
            stergerebtn.TabStop = false;
            stergerebtn.Text = "Ștergere";
            stergerebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            stergerebtn.UseVisualStyleBackColor = false;
            stergerebtn.Click += new System.EventHandler(this.stergerebtn_Click);
            // 
            // modificarebtn
            // 
            modificarebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            modificarebtn.FlatAppearance.BorderSize = 0;
            modificarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            modificarebtn.ForeColor = System.Drawing.Color.White;
            modificarebtn.Image = ((System.Drawing.Image)(resources.GetObject("modificarebtn.Image")));
            modificarebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            modificarebtn.Location = new System.Drawing.Point(13, 87);
            modificarebtn.Name = "modificarebtn";
            modificarebtn.Size = new System.Drawing.Size(142, 40);
            modificarebtn.TabIndex = 3;
            modificarebtn.TabStop = false;
            modificarebtn.Text = "Modificare";
            modificarebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            modificarebtn.UseVisualStyleBackColor = false;
            modificarebtn.Click += new System.EventHandler(this.modificarebtn_Click);
            // 
            // adaugarebtn
            // 
            adaugarebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            adaugarebtn.FlatAppearance.BorderSize = 0;
            adaugarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            adaugarebtn.ForeColor = System.Drawing.Color.White;
            adaugarebtn.Image = ((System.Drawing.Image)(resources.GetObject("adaugarebtn.Image")));
            adaugarebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            adaugarebtn.Location = new System.Drawing.Point(13, 21);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(142, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.TabStop = false;
            adaugarebtn.Text = "Adăugare";
            adaugarebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adaugarebtn.UseVisualStyleBackColor = false;
            adaugarebtn.Click += new System.EventHandler(this.adaugarebtn_Click);
            // 
            // listastudenti
            // 
            this.listastudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.listastudenti.FormattingEnabled = true;
            this.listastudenti.Location = new System.Drawing.Point(150, 91);
            this.listastudenti.Name = "listastudenti";
            this.listastudenti.Size = new System.Drawing.Size(150, 381);
            this.listastudenti.TabIndex = 2;
            this.listastudenti.SelectedIndexChanged += new System.EventHandler(this.listastudenti_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codtxt
            // 
            this.codtxt.BackColor = System.Drawing.Color.LightGray;
            this.codtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codtxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.codtxt.ForeColor = System.Drawing.Color.Black;
            this.codtxt.Location = new System.Drawing.Point(43, 166);
            this.codtxt.Name = "codtxt";
            this.codtxt.Size = new System.Drawing.Size(152, 21);
            this.codtxt.TabIndex = 24;
            this.codtxt.Text = "Număr Matricol";
            this.codtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // creditetxt
            // 
            this.creditetxt.BackColor = System.Drawing.Color.LightGray;
            this.creditetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditetxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.creditetxt.ForeColor = System.Drawing.Color.Black;
            this.creditetxt.Location = new System.Drawing.Point(46, 106);
            this.creditetxt.Name = "creditetxt";
            this.creditetxt.Size = new System.Drawing.Size(124, 18);
            this.creditetxt.TabIndex = 23;
            this.creditetxt.Text = "Prenume Student";
            this.creditetxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // denumiretxt
            // 
            this.denumiretxt.BackColor = System.Drawing.Color.LightGray;
            this.denumiretxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denumiretxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.denumiretxt.ForeColor = System.Drawing.Color.Black;
            this.denumiretxt.Location = new System.Drawing.Point(46, 40);
            this.denumiretxt.Name = "denumiretxt";
            this.denumiretxt.Size = new System.Drawing.Size(149, 25);
            this.denumiretxt.TabIndex = 22;
            this.denumiretxt.Text = "Nume Student";
            this.denumiretxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(iesirebtn);
            this.panel1.Controls.Add(stergerebtn);
            this.panel1.Controls.Add(modificarebtn);
            this.panel1.Controls.Add(adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(739, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 408);
            this.panel1.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 29;
            // 
            // clasastudenti
            // 
            this.clasastudenti.BackColor = System.Drawing.Color.LightGray;
            this.clasastudenti.Controls.Add(this.textBox3);
            this.clasastudenti.Controls.Add(this.textBox2);
            this.clasastudenti.Controls.Add(this.textBox1);
            this.clasastudenti.Controls.Add(this.codtxt);
            this.clasastudenti.Controls.Add(this.creditetxt);
            this.clasastudenti.Controls.Add(this.denumiretxt);
            this.clasastudenti.Location = new System.Drawing.Point(300, 64);
            this.clasastudenti.Name = "clasastudenti";
            this.clasastudenti.Size = new System.Drawing.Size(439, 410);
            this.clasastudenti.TabIndex = 30;
            this.clasastudenti.TabStop = false;
            this.clasastudenti.Enter += new System.EventHandler(this.clasastudenti_Enter);
            // 
            // listacod
            // 
            this.listacod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.listacod.FormattingEnabled = true;
            this.listacod.Location = new System.Drawing.Point(0, 91);
            this.listacod.Name = "listacod";
            this.listacod.Size = new System.Drawing.Size(150, 381);
            this.listacod.TabIndex = 31;
            this.listacod.SelectedIndexChanged += new System.EventHandler(this.listacod_SelectedIndexChanged);
            // 
            // Titlu
            // 
            this.Titlu.BackColor = System.Drawing.Color.Transparent;
            this.Titlu.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.ForeColor = System.Drawing.Color.LightGray;
            this.Titlu.Location = new System.Drawing.Point(-12, 23);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(930, 38);
            this.Titlu.TabIndex = 32;
            this.Titlu.Text = "STUDENȚI";
            this.Titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Număr Matricol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(150, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Studenți";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listastudenti);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.listacod);
            this.Controls.Add(this.clasastudenti);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "studentiform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.panel1.ResumeLayout(false);
            this.clasastudenti.ResumeLayout(false);
            this.clasastudenti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listastudenti;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label codtxt;
        private System.Windows.Forms.Label creditetxt;
        private System.Windows.Forms.Label denumiretxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox clasastudenti;
        private System.Windows.Forms.ListBox listacod;
        private System.Windows.Forms.Label Titlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}