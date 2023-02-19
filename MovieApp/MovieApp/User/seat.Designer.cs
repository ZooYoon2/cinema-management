
namespace MovieApp.User
{
    partial class seat
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
            this.panel_seat = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_seat = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_buy = new System.Windows.Forms.Button();
            this.panel_seat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_seat
            // 
            this.panel_seat.Controls.Add(this.label9);
            this.panel_seat.Controls.Add(this.tableLayoutPanel_seat);
            this.panel_seat.Location = new System.Drawing.Point(16, 8);
            this.panel_seat.Name = "panel_seat";
            this.panel_seat.Padding = new System.Windows.Forms.Padding(10);
            this.panel_seat.Size = new System.Drawing.Size(1104, 600);
            this.panel_seat.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1084, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "SCREEN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_seat
            // 
            this.tableLayoutPanel_seat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_seat.ColumnCount = 2;
            this.tableLayoutPanel_seat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.Location = new System.Drawing.Point(50, 72);
            this.tableLayoutPanel_seat.Name = "tableLayoutPanel_seat";
            this.tableLayoutPanel_seat.RowCount = 2;
            this.tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.Size = new System.Drawing.Size(1000, 500);
            this.tableLayoutPanel_seat.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1136, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "돌아가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_buy
            // 
            this.button_buy.Location = new System.Drawing.Point(1136, 528);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(120, 80);
            this.button_buy.TabIndex = 35;
            this.button_buy.Text = "예매하기";
            this.button_buy.UseVisualStyleBackColor = true;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 624);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_seat);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seat";
            this.Text = "seat";
            this.Load += new System.EventHandler(this.seat_Load);
            this.panel_seat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_seat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_seat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_buy;
    }
}