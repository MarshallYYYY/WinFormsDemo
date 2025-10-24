namespace WinFormsDemo.UIL
{
    partial class FormOwnerAddEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboBuildingNum = new System.Windows.Forms.ComboBox();
            this.cboUnitNum = new System.Windows.Forms.ComboBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F);
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F);
            this.label3.Location = new System.Drawing.Point(11, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "手机号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(35, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "楼号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F);
            this.label5.Location = new System.Drawing.Point(11, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "单元号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F);
            this.label6.Location = new System.Drawing.Point(11, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "房间号：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 18F);
            this.txtName.Location = new System.Drawing.Point(123, 17);
            this.txtName.MaxLength = 4;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 35);
            this.txtName.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoFemale);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Location = new System.Drawing.Point(123, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 32);
            this.panel1.TabIndex = 7;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("宋体", 18F);
            this.rdoFemale.Location = new System.Drawing.Point(81, 3);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(52, 28);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("宋体", 18F);
            this.rdoMale.Location = new System.Drawing.Point(9, 3);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(52, 28);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 18F);
            this.txtPhone.Location = new System.Drawing.Point(123, 134);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 35);
            this.txtPhone.TabIndex = 8;
            // 
            // cboBuildingNum
            // 
            this.cboBuildingNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildingNum.Font = new System.Drawing.Font("宋体", 18F);
            this.cboBuildingNum.FormattingEnabled = true;
            this.cboBuildingNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboBuildingNum.Location = new System.Drawing.Point(123, 194);
            this.cboBuildingNum.Name = "cboBuildingNum";
            this.cboBuildingNum.Size = new System.Drawing.Size(150, 32);
            this.cboBuildingNum.TabIndex = 9;
            // 
            // cboUnitNum
            // 
            this.cboUnitNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitNum.Font = new System.Drawing.Font("宋体", 18F);
            this.cboUnitNum.FormattingEnabled = true;
            this.cboUnitNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboUnitNum.Location = new System.Drawing.Point(123, 251);
            this.cboUnitNum.Name = "cboUnitNum";
            this.cboUnitNum.Size = new System.Drawing.Size(150, 32);
            this.cboUnitNum.TabIndex = 10;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("宋体", 18F);
            this.txtRoomNum.Location = new System.Drawing.Point(123, 308);
            this.txtRoomNum.MaxLength = 4;
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(150, 35);
            this.txtRoomNum.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRoomNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboUnitNum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboBuildingNum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(151, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 362);
            this.panel2.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 27F);
            this.lblTitle.Location = new System.Drawing.Point(177, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 36);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "修改业主信息";
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.Font = new System.Drawing.Font("宋体", 18F);
            this.btnEnter.Location = new System.Drawing.Point(255, 489);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 34);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // FormOwnerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormOwnerAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOwnerAddEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOwnerAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormOwnerAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboBuildingNum;
        private System.Windows.Forms.ComboBox cboUnitNum;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEnter;
    }
}