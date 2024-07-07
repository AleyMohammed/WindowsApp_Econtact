namespace FormApp.Econtact
{
    partial class FormEcontact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEcontact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContactid = new System.Windows.Forms.TextBox();
            this.labelfname = new System.Windows.Forms.Label();
            this.textBoxfname = new System.Windows.Forms.TextBox();
            this.textBoxlname = new System.Windows.Forms.TextBox();
            this.labelLname = new System.Windows.Forms.Label();
            this.textBoxConNo = new System.Windows.Forms.TextBox();
            this.labelCoNo = new System.Windows.Forms.Label();
            this.lAddresse = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.combox = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lsearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textboxaddresse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(959, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ContactID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxContactid
            // 
            this.textBoxContactid.Location = new System.Drawing.Point(142, 84);
            this.textBoxContactid.Multiline = true;
            this.textBoxContactid.Name = "textBoxContactid";
            this.textBoxContactid.ReadOnly = true;
            this.textBoxContactid.Size = new System.Drawing.Size(249, 34);
            this.textBoxContactid.TabIndex = 3;
            this.textBoxContactid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.Location = new System.Drawing.Point(31, 153);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(92, 19);
            this.labelfname.TabIndex = 4;
            this.labelfname.Text = "FirstName";
            this.labelfname.Click += new System.EventHandler(this.labelfname_Click);
            // 
            // textBoxfname
            // 
            this.textBoxfname.Location = new System.Drawing.Point(142, 153);
            this.textBoxfname.Multiline = true;
            this.textBoxfname.Name = "textBoxfname";
            this.textBoxfname.Size = new System.Drawing.Size(249, 37);
            this.textBoxfname.TabIndex = 5;
            this.textBoxfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxlname
            // 
            this.textBoxlname.Location = new System.Drawing.Point(142, 210);
            this.textBoxlname.Multiline = true;
            this.textBoxlname.Name = "textBoxlname";
            this.textBoxlname.Size = new System.Drawing.Size(249, 37);
            this.textBoxlname.TabIndex = 7;
            this.textBoxlname.TextChanged += new System.EventHandler(this.textBoxlname_TextChanged);
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(33, 228);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(90, 19);
            this.labelLname.TabIndex = 6;
            this.labelLname.Text = "LastName";
            // 
            // textBoxConNo
            // 
            this.textBoxConNo.Location = new System.Drawing.Point(142, 273);
            this.textBoxConNo.Multiline = true;
            this.textBoxConNo.Name = "textBoxConNo";
            this.textBoxConNo.Size = new System.Drawing.Size(249, 37);
            this.textBoxConNo.TabIndex = 9;
            this.textBoxConNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelCoNo
            // 
            this.labelCoNo.AutoSize = true;
            this.labelCoNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoNo.Location = new System.Drawing.Point(31, 291);
            this.labelCoNo.Name = "labelCoNo";
            this.labelCoNo.Size = new System.Drawing.Size(99, 19);
            this.labelCoNo.TabIndex = 8;
            this.labelCoNo.Text = "ContactNo.";
            // 
            // lAddresse
            // 
            this.lAddresse.AutoSize = true;
            this.lAddresse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddresse.Location = new System.Drawing.Point(40, 333);
            this.lAddresse.Name = "lAddresse";
            this.lAddresse.Size = new System.Drawing.Size(84, 19);
            this.lAddresse.TabIndex = 10;
            this.lAddresse.Text = "Addresse";
            this.lAddresse.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(33, 515);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 19);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender";
            // 
            // combox
            // 
            this.combox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox.FormattingEnabled = true;
            this.combox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combox.Location = new System.Drawing.Point(142, 512);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(249, 27);
            this.combox.TabIndex = 13;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(510, 84);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(497, 37);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsearch.Location = new System.Drawing.Point(414, 99);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(64, 19);
            this.lsearch.TabIndex = 14;
            this.lsearch.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 363);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(493, 516);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 51);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonupdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.ForeColor = System.Drawing.Color.White;
            this.buttonupdate.Location = new System.Drawing.Point(619, 516);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(107, 51);
            this.buttonupdate.TabIndex = 18;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(872, 514);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 52);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(752, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 52);
            this.button4.TabIndex = 20;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textboxaddresse
            // 
            this.textboxaddresse.Location = new System.Drawing.Point(142, 333);
            this.textboxaddresse.Multiline = true;
            this.textboxaddresse.Name = "textboxaddresse";
            this.textboxaddresse.Size = new System.Drawing.Size(249, 169);
            this.textboxaddresse.TabIndex = 21;
            this.textboxaddresse.TextChanged += new System.EventHandler(this.textboxaddresse_TextChanged);
            // 
            // FormEcontact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 605);
            this.Controls.Add(this.textboxaddresse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lsearch);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.lAddresse);
            this.Controls.Add(this.textBoxConNo);
            this.Controls.Add(this.labelCoNo);
            this.Controls.Add(this.textBoxlname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.textBoxfname);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.textBoxContactid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEcontact";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEcontact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContactid;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.TextBox textBoxfname;
        private System.Windows.Forms.TextBox textBoxlname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.TextBox textBoxConNo;
        private System.Windows.Forms.Label labelCoNo;
        private System.Windows.Forms.Label lAddresse;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textboxaddresse;
    }
}

