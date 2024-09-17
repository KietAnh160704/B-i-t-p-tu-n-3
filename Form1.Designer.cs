namespace Tuan3_ThemXoaSua
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
            this.lvSV = new System.Windows.Forms.ListView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSV
            // 
            this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSV.HideSelection = false;
            this.lvSV.Location = new System.Drawing.Point(12, 12);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(240, 268);
            this.lvSV.TabIndex = 0;
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.View = System.Windows.Forms.View.Details;
            this.lvSV.SelectedIndexChanged += new System.EventHandler(this.lvSV_SelectedIndexChanged);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(282, 256);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(364, 255);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(446, 254);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(335, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(277, 45);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(52, 13);
            this.lbLastname.TabIndex = 7;
            this.lbLastname.Text = "last name";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(277, 107);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(52, 13);
            this.lbFirstname.TabIndex = 8;
            this.lbFirstname.Text = "first name";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(291, 169);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "Phone";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 292);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.lvSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbPhone;
    }
}

