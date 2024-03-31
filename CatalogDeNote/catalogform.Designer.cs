
namespace CatalogDeNote
{
    partial class catalogform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogform));
            System.Windows.Forms.Button stergerebtn;
            System.Windows.Forms.Button adaugarebtn;
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notelist = new System.Windows.Forms.ListBox();
            this.disciplinalist = new System.Windows.Forms.ListBox();
            this.studentlist = new System.Windows.Forms.ListBox();
            this.listastudenti = new System.Windows.Forms.ListBox();
            this.listadiscipline = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteadd = new System.Windows.Forms.TextBox();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            iesirebtn.Location = new System.Drawing.Point(18, 306);
            iesirebtn.Name = "iesirebtn";
            iesirebtn.Size = new System.Drawing.Size(125, 40);
            iesirebtn.TabIndex = 5;
            iesirebtn.TabStop = false;
            iesirebtn.Text = "Ieșire";
            iesirebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iesirebtn.UseVisualStyleBackColor = false;
            iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click);
            // 
            // stergerebtn
            // 
            stergerebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            stergerebtn.FlatAppearance.BorderSize = 0;
            stergerebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            stergerebtn.ForeColor = System.Drawing.Color.White;
            stergerebtn.Image = ((System.Drawing.Image)(resources.GetObject("stergerebtn.Image")));
            stergerebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            stergerebtn.Location = new System.Drawing.Point(18, 169);
            stergerebtn.Name = "stergerebtn";
            stergerebtn.Size = new System.Drawing.Size(125, 40);
            stergerebtn.TabIndex = 4;
            stergerebtn.TabStop = false;
            stergerebtn.Text = "Ștergere";
            stergerebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            stergerebtn.UseVisualStyleBackColor = false;
            stergerebtn.Click += new System.EventHandler(this.stergerebtn_Click_1);
            // 
            // adaugarebtn
            // 
            adaugarebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            adaugarebtn.FlatAppearance.BorderSize = 0;
            adaugarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            adaugarebtn.ForeColor = System.Drawing.Color.White;
            adaugarebtn.Image = ((System.Drawing.Image)(resources.GetObject("adaugarebtn.Image")));
            adaugarebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            adaugarebtn.Location = new System.Drawing.Point(18, 109);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(125, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.TabStop = false;
            adaugarebtn.Text = "Salvare";
            adaugarebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            adaugarebtn.UseVisualStyleBackColor = false;
            adaugarebtn.Click += new System.EventHandler(this.adaugarebtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "CATALOG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.noteadd);
            this.panel1.Controls.Add(iesirebtn);
            this.panel1.Controls.Add(stergerebtn);
            this.panel1.Controls.Add(adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(751, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 408);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // notelist
            // 
            this.notelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.notelist.FormattingEnabled = true;
            this.notelist.Location = new System.Drawing.Point(596, 91);
            this.notelist.Name = "notelist";
            this.notelist.Size = new System.Drawing.Size(156, 381);
            this.notelist.TabIndex = 40;
            this.notelist.SelectedIndexChanged += new System.EventHandler(this.notelist_SelectedIndexChanged);
            // 
            // disciplinalist
            // 
            this.disciplinalist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.disciplinalist.FormattingEnabled = true;
            this.disciplinalist.Location = new System.Drawing.Point(447, 90);
            this.disciplinalist.Name = "disciplinalist";
            this.disciplinalist.Size = new System.Drawing.Size(149, 381);
            this.disciplinalist.TabIndex = 41;
            this.disciplinalist.SelectedIndexChanged += new System.EventHandler(this.disciplinalist_SelectedIndexChanged);
            // 
            // studentlist
            // 
            this.studentlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.studentlist.FormattingEnabled = true;
            this.studentlist.Location = new System.Drawing.Point(149, 90);
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(149, 381);
            this.studentlist.TabIndex = 42;
            this.studentlist.SelectedIndexChanged += new System.EventHandler(this.studentlist_SelectedIndexChanged);
            // 
            // listastudenti
            // 
            this.listastudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.listastudenti.FormattingEnabled = true;
            this.listastudenti.Location = new System.Drawing.Point(0, 90);
            this.listastudenti.Name = "listastudenti";
            this.listastudenti.Size = new System.Drawing.Size(149, 381);
            this.listastudenti.TabIndex = 43;
            this.listastudenti.SelectedIndexChanged += new System.EventHandler(this.listastudenti_SelectedIndexChanged);
            // 
            // listadiscipline
            // 
            this.listadiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.listadiscipline.FormattingEnabled = true;
            this.listadiscipline.Location = new System.Drawing.Point(298, 90);
            this.listadiscipline.Name = "listadiscipline";
            this.listadiscipline.Size = new System.Drawing.Size(149, 381);
            this.listadiscipline.TabIndex = 44;
            this.listadiscipline.SelectedIndexChanged += new System.EventHandler(this.listadiscipline_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Număr Matricol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(149, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Student";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(298, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cod Disciplină";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(447, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Disciplină";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(596, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Notă";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteadd
            // 
            this.noteadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteadd.Location = new System.Drawing.Point(49, 27);
            this.noteadd.Multiline = true;
            this.noteadd.Name = "noteadd";
            this.noteadd.Size = new System.Drawing.Size(61, 51);
            this.noteadd.TabIndex = 6;
            this.noteadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noteadd.TextChanged += new System.EventHandler(this.noteadd_TextChanged_1);
            // 
            // catalogform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadiscipline);
            this.Controls.Add(this.listastudenti);
            this.Controls.Add(this.disciplinalist);
            this.Controls.Add(this.notelist);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "catalogform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox notelist;
        private System.Windows.Forms.ListBox disciplinalist;
        private System.Windows.Forms.ListBox studentlist;
        private System.Windows.Forms.ListBox listastudenti;
        private System.Windows.Forms.ListBox listadiscipline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noteadd;
    }
}