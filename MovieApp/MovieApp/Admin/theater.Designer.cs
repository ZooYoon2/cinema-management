
namespace MovieApp.Admin
{
    partial class theater
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
            this.listView_theater = new System.Windows.Forms.ListView();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.panel_seat = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_seat = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_row = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_colunm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_group = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_seat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_colunm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "상영관 관리";
            // 
            // listView_theater
            // 
            this.listView_theater.HideSelection = false;
            this.listView_theater.Location = new System.Drawing.Point(24, 72);
            this.listView_theater.Name = "listView_theater";
            this.listView_theater.Size = new System.Drawing.Size(215, 425);
            this.listView_theater.TabIndex = 23;
            this.listView_theater.UseCompatibleStateImageBehavior = false;
            this.listView_theater.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_theater_MouseDoubleClick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(24, 584);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(216, 32);
            this.button_reset.TabIndex = 27;
            this.button_reset.Text = "초기화";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(168, 616);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(72, 31);
            this.button_update.TabIndex = 26;
            this.button_update.Text = "수정";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(96, 616);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(72, 31);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(24, 616);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(72, 31);
            this.button_create.TabIndex = 24;
            this.button_create.Text = "추가";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_no
            // 
            this.textBox_no.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_no.Location = new System.Drawing.Point(112, 512);
            this.textBox_no.MaxLength = 14;
            this.textBox_no.Name = "textBox_no";
            this.textBox_no.Size = new System.Drawing.Size(120, 22);
            this.textBox_no.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(24, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "상영관 형태";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "상영관 번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_type
            // 
            this.comboBox_type.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(112, 544);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 22);
            this.comboBox_type.TabIndex = 31;
            // 
            // panel_seat
            // 
            this.panel_seat.Controls.Add(this.label9);
            this.panel_seat.Controls.Add(this.tableLayoutPanel_seat);
            this.panel_seat.Location = new System.Drawing.Point(253, 72);
            this.panel_seat.Name = "panel_seat";
            this.panel_seat.Padding = new System.Windows.Forms.Padding(10);
            this.panel_seat.Size = new System.Drawing.Size(550, 550);
            this.panel_seat.TabIndex = 32;
            this.panel_seat.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_seat_Paint);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(530, 32);
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
            this.tableLayoutPanel_seat.Location = new System.Drawing.Point(16, 80);
            this.tableLayoutPanel_seat.Name = "tableLayoutPanel_seat";
            this.tableLayoutPanel_seat.RowCount = 2;
            this.tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_seat.Size = new System.Drawing.Size(520, 450);
            this.tableLayoutPanel_seat.TabIndex = 0;
            // 
            // numericUpDown_row
            // 
            this.numericUpDown_row.Location = new System.Drawing.Point(288, 624);
            this.numericUpDown_row.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_row.Name = "numericUpDown_row";
            this.numericUpDown_row.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_row.TabIndex = 33;
            this.numericUpDown_row.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_row.ValueChanged += new System.EventHandler(this.numericUpDown_row_ValueChanged);
            // 
            // numericUpDown_colunm
            // 
            this.numericUpDown_colunm.Location = new System.Drawing.Point(411, 624);
            this.numericUpDown_colunm.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_colunm.Name = "numericUpDown_colunm";
            this.numericUpDown_colunm.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_colunm.TabIndex = 34;
            this.numericUpDown_colunm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_colunm.ValueChanged += new System.EventHandler(this.numericUpDown_colunm_ValueChanged);
            // 
            // numericUpDown_group
            // 
            this.numericUpDown_group.Location = new System.Drawing.Point(523, 624);
            this.numericUpDown_group.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_group.Name = "numericUpDown_group";
            this.numericUpDown_group.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_group.TabIndex = 35;
            this.numericUpDown_group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_group.ValueChanged += new System.EventHandler(this.numericUpDown_group_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(256, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "행";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(379, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "블럭";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(475, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "블럭 별";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(344, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "/  열 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(464, 624);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_group);
            this.Controls.Add(this.numericUpDown_colunm);
            this.Controls.Add(this.numericUpDown_row);
            this.Controls.Add(this.panel_seat);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.listView_theater);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "theater";
            this.Text = " ";
            this.Load += new System.EventHandler(this.theater_Load);
            this.panel_seat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_colunm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView_theater;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Panel panel_seat;
        private System.Windows.Forms.NumericUpDown numericUpDown_row;
        private System.Windows.Forms.NumericUpDown numericUpDown_colunm;
        private System.Windows.Forms.NumericUpDown numericUpDown_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_seat;
        private System.Windows.Forms.Label label9;
    }
}