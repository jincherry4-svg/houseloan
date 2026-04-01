namespace houseloan
{
    partial class houseloan
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
            tbtotalprice.Location = new Point(42, 58);
            tbtotalprice.Name = "tbtotalprice";
            tbtotalprice.Size = new Size(153, 25);
            tbtotalprice.TabIndex = 0;
            // 
            // grpInput
            // 
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
            grpInput.Location = new Point(21, 27);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(449, 403);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "輸入";
            // 
            // btncount
            // 
            btncount.Location = new Point(223, 341);
            btncount.Name = "btncount";
            btncount.Size = new Size(195, 41);
            btncount.TabIndex = 13;
            btncount.Text = "計算";
            btncount.UseVisualStyleBackColor = true;
            btncount.Click += btncount_Click;
            // 
            // tbselfprice
            // 
            tbselfprice.Location = new Point(42, 114);
            tbselfprice.Name = "tbselfprice";
            tbselfprice.Size = new Size(153, 25);
            tbselfprice.TabIndex = 12;
            // 
            // cbself
            // 
            cbself.FormattingEnabled = true;
            cbself.Items.AddRange(new object[] { "比例", "金額" });
            cbself.Location = new Point(223, 87);
            cbself.Name = "cbself";
            cbself.Size = new Size(69, 25);
            cbself.TabIndex = 11;
            cbself.Text = "比例";
            // 
            // tbgrace
            // 
            tbgrace.Location = new Point(42, 282);
            tbgrace.Name = "tbgrace";
            tbgrace.Size = new Size(153, 25);
            tbgrace.TabIndex = 9;
            // 
            // tbloanterm
            // 
            tbloanterm.Location = new Point(42, 226);
            tbloanterm.Name = "tbloanterm";
            tbloanterm.Size = new Size(153, 25);
            tbloanterm.TabIndex = 8;
            // 
            // tbrate
            // 
            tbrate.Location = new Point(42, 170);
            tbrate.Name = "tbrate";
            tbrate.Size = new Size(153, 25);
            tbrate.TabIndex = 7;
            // 
            // lblgrace
            // 
            lblgrace.AutoSize = true;
            lblgrace.Location = new Point(42, 258);
            lblgrace.Name = "lblgrace";
            lblgrace.Size = new Size(68, 17);
            lblgrace.TabIndex = 5;
            lblgrace.Text = "寬限期(年)";
            // 
            // lblloanterm
            // 
            lblloanterm.AutoSize = true;
            lblloanterm.Location = new Point(42, 202);
            lblloanterm.Name = "lblloanterm";
            lblloanterm.Size = new Size(81, 17);
            lblloanterm.TabIndex = 4;
            lblloanterm.Text = "貸款年限(年)";
            // 
            // lblloanrate
            // 
            lblloanrate.AutoSize = true;
            lblloanrate.Location = new Point(42, 146);
            lblloanrate.Name = "lblloanrate";
            lblloanrate.Size = new Size(79, 17);
            lblloanrate.TabIndex = 3;
            lblloanrate.Text = "貸款利率(%)";
            // 
            // lblselfprice
            // 
            lblselfprice.AutoSize = true;
            lblselfprice.Location = new Point(42, 90);
            lblselfprice.Name = "lblselfprice";
            lblselfprice.Size = new Size(164, 17);
            lblselfprice.TabIndex = 2;
            lblselfprice.Text = "自備款比例或金額(  % / 萬 )";
            // 
            // lbltotalprice
            // 
            lbltotalprice.AutoSize = true;
            lbltotalprice.Location = new Point(42, 34);
            lbltotalprice.Name = "lbltotalprice";
            lbltotalprice.Size = new Size(81, 17);
            lbltotalprice.TabIndex = 1;
            lbltotalprice.Text = "房屋總價(萬)";
            // 
            // grpoutput
            // 
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
            grpoutput.Size = new Size(449, 403);
            grpoutput.TabIndex = 2;
            grpoutput.TabStop = false;
            grpoutput.Text = "輸出";
            // 
            // lbltotalback
            // 
            lbltotalback.BorderStyle = BorderStyle.Fixed3D;
            lbltotalback.ImageAlign = ContentAlignment.TopCenter;
            lbltotalback.Location = new Point(40, 331);
            lbltotalback.Name = "lbltotalback";
            lbltotalback.Size = new Size(154, 17);
            lbltotalback.TabIndex = 12;
            lbltotalback.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 304);
            label12.Name = "label12";
            label12.Size = new Size(73, 17);
            label12.TabIndex = 11;
            label12.Text = "總還款金額";
            // 
            // lbltotalinterest
            // 
            lbltotalinterest.BorderStyle = BorderStyle.Fixed3D;
            lbltotalinterest.ImageAlign = ContentAlignment.TopCenter;
            lbltotalinterest.Location = new Point(40, 277);
            lbltotalinterest.Name = "lbltotalinterest";
            lbltotalinterest.Size = new Size(153, 17);
            lbltotalinterest.TabIndex = 10;
            lbltotalinterest.Text = " ";
            // 
            // lblfirstprice
            // 
            lblfirstprice.BorderStyle = BorderStyle.Fixed3D;
            lblfirstprice.ImageAlign = ContentAlignment.TopCenter;
            lblfirstprice.Location = new Point(40, 223);
            lblfirstprice.Name = "lblfirstprice";
            lblfirstprice.Size = new Size(153, 17);
            lblfirstprice.TabIndex = 9;
            lblfirstprice.Text = " ";
            // 
            // lblfirstinterest
            // 
            lblfirstinterest.BorderStyle = BorderStyle.Fixed3D;
            lblfirstinterest.ImageAlign = ContentAlignment.TopCenter;
            lblfirstinterest.Location = new Point(40, 169);
            lblfirstinterest.Name = "lblfirstinterest";
            lblfirstinterest.Size = new Size(153, 17);
            lblfirstinterest.TabIndex = 8;
            lblfirstinterest.Text = " ";
            // 
            // lblpriceperm
            // 
            lblpriceperm.BorderStyle = BorderStyle.Fixed3D;
            lblpriceperm.ImageAlign = ContentAlignment.TopCenter;
            lblpriceperm.Location = new Point(40, 115);
            lblpriceperm.Name = "lblpriceperm";
            lblpriceperm.Size = new Size(154, 17);
            lblpriceperm.TabIndex = 7;
            lblpriceperm.Text = " ";
            // 
            // lbltotalloan
            // 
            lbltotalloan.BorderStyle = BorderStyle.Fixed3D;
            lbltotalloan.ImageAlign = ContentAlignment.TopCenter;
            lbltotalloan.Location = new Point(40, 61);
            lbltotalloan.Name = "lbltotalloan";
            lbltotalloan.Size = new Size(153, 17);
            lbltotalloan.TabIndex = 6;
            lbltotalloan.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 250);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 5;
            label1.Text = "總利息支出";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 196);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 4;
            label2.Text = "首期本金";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 142);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 3;
            label3.Text = "首期利息";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 88);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 2;
            label4.Text = "每月應繳金額(本+息)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 34);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 1;
            label5.Text = "貸款總金額";
            // 
            // houseloan
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 670);
            Controls.Add(grpoutput);
            Controls.Add(grpInput);
            Font = new Font("微軟正黑體", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "houseloan";
            Text = "房貸計算器";
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
