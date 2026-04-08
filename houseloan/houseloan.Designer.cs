namespace houseloan
{
    partial class Houseloan
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
            tbtotalprice = new TextBox();
            grpInput = new GroupBox();
            btncount = new Button();
            tbselfprice = new TextBox();
            cbself = new ComboBox();
            tbgrace = new TextBox();
            tbloanterm = new TextBox();
            tbrate = new TextBox();
            lblgrace = new Label();
            lblloanterm = new Label();
            lblloanrate = new Label();
            lblselfprice = new Label();
            lbltotalprice = new Label();
            grpoutput = new GroupBox();
            lbltotalback = new Label();
            label12 = new Label();
            lbltotalinterest = new Label();
            lblfirstprice = new Label();
            lblfirstinterest = new Label();
            lblpriceperm = new Label();
            lbltotalloan = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grpInput.SuspendLayout();
            grpoutput.SuspendLayout();
            SuspendLayout();
            // 
            // tbtotalprice
            // 
            tbtotalprice.BackColor = SystemColors.ButtonFace;
            tbtotalprice.Location = new Point(42, 58);
            tbtotalprice.Name = "tbtotalprice";
            tbtotalprice.Size = new Size(153, 29);
            tbtotalprice.TabIndex = 0;
            // 
            // grpInput
            // 
            grpInput.BackColor = Color.Transparent;
            grpInput.BackgroundImageLayout = ImageLayout.None;
            grpInput.Controls.Add(btncount);
            grpInput.Controls.Add(tbselfprice);
            grpInput.Controls.Add(cbself);
            grpInput.Controls.Add(tbgrace);
            grpInput.Controls.Add(tbloanterm);
            grpInput.Controls.Add(tbrate);
            grpInput.Controls.Add(lblgrace);
            grpInput.Controls.Add(lblloanterm);
            grpInput.Controls.Add(lblloanrate);
            grpInput.Controls.Add(lblselfprice);
            grpInput.Controls.Add(lbltotalprice);
            grpInput.Controls.Add(tbtotalprice);
            grpInput.FlatStyle = FlatStyle.Flat;
            grpInput.Location = new Point(21, 27);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(449, 434);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "輸入";
            // 
            // btncount
            // 
            btncount.BackColor = Color.Navy;
            btncount.FlatStyle = FlatStyle.Flat;
            btncount.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncount.ForeColor = SystemColors.HighlightText;
            btncount.Location = new Point(224, 357);
            btncount.Name = "btncount";
            btncount.Size = new Size(195, 41);
            btncount.TabIndex = 13;
            btncount.Text = "計算";
            btncount.UseVisualStyleBackColor = false;
            btncount.Click += btncount_Click;
            // 
            // tbselfprice
            // 
            tbselfprice.BackColor = SystemColors.ButtonFace;
            tbselfprice.Location = new Point(42, 114);
            tbselfprice.Name = "tbselfprice";
            tbselfprice.Size = new Size(153, 29);
            tbselfprice.TabIndex = 2;
            // 
            // cbself
            // 
            cbself.FormattingEnabled = true;
            cbself.Items.AddRange(new object[] { "比例%", "金額" });
            cbself.Location = new Point(201, 87);
            cbself.Name = "cbself";
            cbself.Size = new Size(78, 28);
            cbself.TabIndex = 1;
            cbself.Text = "比例%";
            // 
            // tbgrace
            // 
            tbgrace.BackColor = SystemColors.ButtonFace;
            tbgrace.Location = new Point(42, 282);
            tbgrace.Name = "tbgrace";
            tbgrace.Size = new Size(153, 29);
            tbgrace.TabIndex = 5;
            // 
            // tbloanterm
            // 
            tbloanterm.BackColor = SystemColors.ButtonFace;
            tbloanterm.Location = new Point(42, 226);
            tbloanterm.Name = "tbloanterm";
            tbloanterm.Size = new Size(153, 29);
            tbloanterm.TabIndex = 4;
            // 
            // tbrate
            // 
            tbrate.BackColor = SystemColors.ButtonFace;
            tbrate.Location = new Point(42, 170);
            tbrate.Name = "tbrate";
            tbrate.Size = new Size(153, 29);
            tbrate.TabIndex = 3;
            // 
            // lblgrace
            // 
            lblgrace.AutoSize = true;
            lblgrace.Location = new Point(42, 258);
            lblgrace.Name = "lblgrace";
            lblgrace.Size = new Size(88, 22);
            lblgrace.TabIndex = 5;
            lblgrace.Text = "寬限期(年)";
            // 
            // lblloanterm
            // 
            lblloanterm.AutoSize = true;
            lblloanterm.Location = new Point(42, 202);
            lblloanterm.Name = "lblloanterm";
            lblloanterm.Size = new Size(105, 22);
            lblloanterm.TabIndex = 4;
            lblloanterm.Text = "貸款年限(年)";
            // 
            // lblloanrate
            // 
            lblloanrate.AutoSize = true;
            lblloanrate.Location = new Point(42, 146);
            lblloanrate.Name = "lblloanrate";
            lblloanrate.Size = new Size(103, 22);
            lblloanrate.TabIndex = 3;
            lblloanrate.Text = "貸款利率(%)";
            // 
            // lblselfprice
            // 
            lblselfprice.AutoSize = true;
            lblselfprice.Location = new Point(42, 90);
            lblselfprice.Name = "lblselfprice";
            lblselfprice.Size = new Size(146, 22);
            lblselfprice.TabIndex = 2;
            lblselfprice.Text = "自備款比例或金額";
            // 
            // lbltotalprice
            // 
            lbltotalprice.AutoSize = true;
            lbltotalprice.Location = new Point(42, 34);
            lbltotalprice.Name = "lbltotalprice";
            lbltotalprice.Size = new Size(78, 22);
            lbltotalprice.TabIndex = 1;
            lbltotalprice.Text = "房屋總價";
            // 
            // grpoutput
            // 
            grpoutput.BackColor = Color.Transparent;
            grpoutput.Controls.Add(lbltotalback);
            grpoutput.Controls.Add(label12);
            grpoutput.Controls.Add(lbltotalinterest);
            grpoutput.Controls.Add(lblfirstprice);
            grpoutput.Controls.Add(lblfirstinterest);
            grpoutput.Controls.Add(lblpriceperm);
            grpoutput.Controls.Add(lbltotalloan);
            grpoutput.Controls.Add(label1);
            grpoutput.Controls.Add(label2);
            grpoutput.Controls.Add(label3);
            grpoutput.Controls.Add(label4);
            grpoutput.Controls.Add(label5);
            grpoutput.Location = new Point(599, 27);
            grpoutput.Name = "grpoutput";
            grpoutput.Size = new Size(449, 434);
            grpoutput.TabIndex = 2;
            grpoutput.TabStop = false;
            grpoutput.Text = "輸出";
            // 
            // lbltotalback
            // 
            lbltotalback.BackColor = SystemColors.ButtonFace;
            lbltotalback.BorderStyle = BorderStyle.Fixed3D;
            lbltotalback.ImageAlign = ContentAlignment.TopCenter;
            lbltotalback.Location = new Point(40, 366);
            lbltotalback.Name = "lbltotalback";
            lbltotalback.Size = new Size(154, 29);
            lbltotalback.TabIndex = 12;
            lbltotalback.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 339);
            label12.Name = "label12";
            label12.Size = new Size(95, 22);
            label12.TabIndex = 11;
            label12.Text = "總還款金額";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltotalinterest
            // 
            lbltotalinterest.BackColor = SystemColors.ButtonFace;
            lbltotalinterest.BorderStyle = BorderStyle.Fixed3D;
            lbltotalinterest.ImageAlign = ContentAlignment.TopCenter;
            lbltotalinterest.Location = new Point(40, 305);
            lbltotalinterest.Name = "lbltotalinterest";
            lbltotalinterest.Size = new Size(153, 29);
            lbltotalinterest.TabIndex = 10;
            lbltotalinterest.Text = " ";
            // 
            // lblfirstprice
            // 
            lblfirstprice.BackColor = SystemColors.ButtonFace;
            lblfirstprice.BorderStyle = BorderStyle.Fixed3D;
            lblfirstprice.ImageAlign = ContentAlignment.TopCenter;
            lblfirstprice.Location = new Point(40, 244);
            lblfirstprice.Name = "lblfirstprice";
            lblfirstprice.Size = new Size(153, 29);
            lblfirstprice.TabIndex = 9;
            lblfirstprice.Text = " ";
            // 
            // lblfirstinterest
            // 
            lblfirstinterest.BackColor = SystemColors.ButtonFace;
            lblfirstinterest.BorderStyle = BorderStyle.Fixed3D;
            lblfirstinterest.ImageAlign = ContentAlignment.TopCenter;
            lblfirstinterest.Location = new Point(40, 183);
            lblfirstinterest.Name = "lblfirstinterest";
            lblfirstinterest.Size = new Size(153, 29);
            lblfirstinterest.TabIndex = 8;
            lblfirstinterest.Text = " ";
            // 
            // lblpriceperm
            // 
            lblpriceperm.BackColor = SystemColors.ButtonFace;
            lblpriceperm.BorderStyle = BorderStyle.Fixed3D;
            lblpriceperm.ImageAlign = ContentAlignment.TopCenter;
            lblpriceperm.Location = new Point(40, 122);
            lblpriceperm.Name = "lblpriceperm";
            lblpriceperm.Size = new Size(154, 29);
            lblpriceperm.TabIndex = 7;
            lblpriceperm.Text = " ";
            lblpriceperm.Click += lblpriceperm_Click;
            // 
            // lbltotalloan
            // 
            lbltotalloan.BackColor = SystemColors.ButtonFace;
            lbltotalloan.BorderStyle = BorderStyle.Fixed3D;
            lbltotalloan.ImageAlign = ContentAlignment.TopCenter;
            lbltotalloan.Location = new Point(40, 61);
            lbltotalloan.Name = "lbltotalloan";
            lbltotalloan.Size = new Size(153, 29);
            lbltotalloan.TabIndex = 6;
            lbltotalloan.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 278);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 5;
            label1.Text = "總利息支出";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 217);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 4;
            label2.Text = "首期本金";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 156);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 3;
            label3.Text = "首期利息";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 95);
            label4.Name = "label4";
            label4.Size = new Size(169, 22);
            label4.TabIndex = 2;
            label4.Text = "每月應繳金額(本+息)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 34);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 1;
            label5.Text = "貸款總金額";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Houseloan
            // 
            AcceptButton = btncount;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.網站縮圖_930x500_41;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1175, 670);
            Controls.Add(grpoutput);
            Controls.Add(grpInput);
            DoubleBuffered = true;
            Font = new Font("微軟正黑體", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "Houseloan";
            Text = "房貸計算器";
            Load += Houseloan_Load_1;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpoutput.ResumeLayout(false);
            grpoutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbtotalprice;
        private GroupBox grpInput;
        private Label lblloanterm;
        private Label lblloanrate;
        private Label lblselfprice;
        private Label lbltotalprice;
        private TextBox tbgrace;
        private TextBox tbloanterm;
        private TextBox tbrate;
        private Label lblgrace;
        private GroupBox grpoutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbltotalinterest;
        private Label lblfirstprice;
        private Label lblfirstinterest;
        private Label lblpriceperm;
        private Label lbltotalloan;
        private Label lbltotalback;
        private Label label12;
        private ComboBox cbself;
        private TextBox tbselfprice;
        private Button btncount;
    }
}
