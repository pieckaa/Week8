namespace Week8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            dgvStudentInfo = new DataGridView();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            tbxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxLname = new TextBox();
            label3 = new Label();
            tbxFname = new TextBox();
            btnInst = new Button();
            btnDel = new Button();
            bntUpdt = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(110, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 0;
            button1.Text = "Connection Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.BackgroundColor = Color.White;
            dgvStudentInfo.BorderStyle = BorderStyle.None;
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(215, 31);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(754, 343);
            dgvStudentInfo.TabIndex = 1;
            dgvStudentInfo.CellContentClick += dgvStudentInfo_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 342);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 2;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(958, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbxID
            // 
            tbxID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxID.Location = new Point(98, 40);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(100, 25);
            tbxID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 5;
            label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 7;
            label2.Text = "LAST NAME";
            // 
            // tbxLname
            // 
            tbxLname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLname.Location = new Point(98, 81);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(100, 25);
            tbxLname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 9;
            label3.Text = "FIRSTNAME";
            // 
            // tbxFname
            // 
            tbxFname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFname.Location = new Point(98, 121);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(100, 25);
            tbxFname.TabIndex = 8;
            // 
            // btnInst
            // 
            btnInst.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInst.Location = new Point(12, 191);
            btnInst.Name = "btnInst";
            btnInst.Size = new Size(52, 23);
            btnInst.TabIndex = 10;
            btnInst.Text = "Insert";
            btnInst.UseVisualStyleBackColor = true;
            btnInst.Click += btnInst_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel.Location = new Point(70, 191);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(64, 23);
            btnDel.TabIndex = 11;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // bntUpdt
            // 
            bntUpdt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bntUpdt.Location = new Point(140, 191);
            bntUpdt.Name = "bntUpdt";
            bntUpdt.Size = new Size(64, 23);
            bntUpdt.TabIndex = 12;
            bntUpdt.Text = "Update";
            bntUpdt.UseVisualStyleBackColor = true;
            bntUpdt.Click += bntUpdt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(981, 386);
            Controls.Add(bntUpdt);
            Controls.Add(btnDel);
            Controls.Add(btnInst);
            Controls.Add(label3);
            Controls.Add(tbxFname);
            Controls.Add(label2);
            Controls.Add(tbxLname);
            Controls.Add(label1);
            Controls.Add(tbxID);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(dgvStudentInfo);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvStudentInfo;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox tbxID;
        private Label label1;
        private Label label2;
        private TextBox tbxLname;
        private Label label3;
        private TextBox tbxFname;
        private Button btnInst;
        private Button btnDel;
        private Button bntUpdt;
    }
}
