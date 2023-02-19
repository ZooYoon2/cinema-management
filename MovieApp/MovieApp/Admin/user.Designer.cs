
namespace MovieApp.Admin
{
    partial class user
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGRADE = new System.Windows.Forms.ComboBox();
            this.listView_user = new System.Windows.Forms.ListView();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "회원관리";
            // 
            // txtPN
            // 
            this.txtPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPN.Enabled = false;
            this.txtPN.Location = new System.Drawing.Point(624, 184);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(120, 21);
            this.txtPN.TabIndex = 38;
            // 
            // txtNAME
            // 
            this.txtNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNAME.Enabled = false;
            this.txtNAME.Location = new System.Drawing.Point(624, 152);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(120, 21);
            this.txtNAME.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(624, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 21);
            this.txtID.TabIndex = 36;
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_update.Location = new System.Drawing.Point(624, 256);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(120, 35);
            this.button_update.TabIndex = 35;
            this.button_update.Text = "등급수정";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "이름";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 33;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "등급";
            // 
            // txtGRADE
            // 
            this.txtGRADE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGRADE.AutoCompleteCustomSource.AddRange(new string[] {
            "SILVER",
            "GOLD",
            "VIP"});
            this.txtGRADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGRADE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGRADE.FormattingEnabled = true;
            this.txtGRADE.Location = new System.Drawing.Point(624, 224);
            this.txtGRADE.Name = "txtGRADE";
            this.txtGRADE.Size = new System.Drawing.Size(121, 22);
            this.txtGRADE.TabIndex = 30;
            // 
            // listView_user
            // 
            this.listView_user.HideSelection = false;
            this.listView_user.Location = new System.Drawing.Point(32, 80);
            this.listView_user.Name = "listView_user";
            this.listView_user.Size = new System.Drawing.Size(500, 592);
            this.listView_user.TabIndex = 29;
            this.listView_user.UseCompatibleStateImageBehavior = false;
            this.listView_user.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_user_MouseDoubleClick_1);
            // 
            // txtCD
            // 
            this.txtCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCD.Enabled = false;
            this.txtCD.Location = new System.Drawing.Point(624, 88);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(120, 21);
            this.txtCD.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 39;
            this.label5.Text = "번호";
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 700);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGRADE);
            this.Controls.Add(this.listView_user);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtGRADE;
        private System.Windows.Forms.ListView listView_user;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.Label label5;
    }
}