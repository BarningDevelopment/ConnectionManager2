namespace ConnectionManager2
{
    partial class connection_manager
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chAccesPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSignal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connect_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.wifi_connect_checkBox = new System.Windows.Forms.CheckBox();
            this.mobile_connect_checkBox = new System.Windows.Forms.CheckBox();
            this.connect_mobile_button = new System.Windows.Forms.Button();
            this.password_mobile_label = new System.Windows.Forms.Label();
            this.password_mobile_textBox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.AccesPointMobilecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignalStrengthMobilecolumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusMobilecolumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecurityMobilecolumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAccesPoint,
            this.chSignal,
            this.chStatus,
            this.chInfo});
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 120);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chAccesPoint
            // 
            this.chAccesPoint.Text = "Access Point";
            this.chAccesPoint.Width = 99;
            // 
            // chSignal
            // 
            this.chSignal.Text = "Signal Strength";
            this.chSignal.Width = 95;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 90;
            // 
            // chInfo
            // 
            this.chInfo.Text = "Secure?";
            this.chInfo.Width = 97;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(416, 39);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(144, 23);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(416, 91);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(144, 20);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(427, 75);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // wifi_connect_checkBox
            // 
            this.wifi_connect_checkBox.AutoSize = true;
            this.wifi_connect_checkBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.wifi_connect_checkBox.Location = new System.Drawing.Point(90, 12);
            this.wifi_connect_checkBox.Name = "wifi_connect_checkBox";
            this.wifi_connect_checkBox.Size = new System.Drawing.Size(87, 17);
            this.wifi_connect_checkBox.TabIndex = 4;
            this.wifi_connect_checkBox.Text = "Wifi Connect";
            this.wifi_connect_checkBox.UseVisualStyleBackColor = false;
            this.wifi_connect_checkBox.CheckedChanged += new System.EventHandler(this.wifi_connect_checkBox_CheckedChanged);
            // 
            // mobile_connect_checkBox
            // 
            this.mobile_connect_checkBox.AutoSize = true;
            this.mobile_connect_checkBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mobile_connect_checkBox.Location = new System.Drawing.Point(90, 192);
            this.mobile_connect_checkBox.Name = "mobile_connect_checkBox";
            this.mobile_connect_checkBox.Size = new System.Drawing.Size(100, 17);
            this.mobile_connect_checkBox.TabIndex = 5;
            this.mobile_connect_checkBox.Text = "Mobile Connect";
            this.mobile_connect_checkBox.UseVisualStyleBackColor = false;
            this.mobile_connect_checkBox.CheckedChanged += new System.EventHandler(this.mobile_connect_checkBox_CheckedChanged);
            // 
            // connect_mobile_button
            // 
            this.connect_mobile_button.Location = new System.Drawing.Point(416, 215);
            this.connect_mobile_button.Name = "connect_mobile_button";
            this.connect_mobile_button.Size = new System.Drawing.Size(144, 23);
            this.connect_mobile_button.TabIndex = 7;
            this.connect_mobile_button.Text = "connect to mobile";
            this.connect_mobile_button.UseVisualStyleBackColor = true;
            // 
            // password_mobile_label
            // 
            this.password_mobile_label.AutoSize = true;
            this.password_mobile_label.Location = new System.Drawing.Point(421, 251);
            this.password_mobile_label.Name = "password_mobile_label";
            this.password_mobile_label.Size = new System.Drawing.Size(53, 13);
            this.password_mobile_label.TabIndex = 8;
            this.password_mobile_label.Text = "Password";
            // 
            // password_mobile_textBox
            // 
            this.password_mobile_textBox.Location = new System.Drawing.Point(424, 267);
            this.password_mobile_textBox.Name = "password_mobile_textBox";
            this.password_mobile_textBox.Size = new System.Drawing.Size(136, 20);
            this.password_mobile_textBox.TabIndex = 9;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccesPointMobilecolumnHeader,
            this.SignalStrengthMobilecolumnHead,
            this.StatusMobilecolumnHead,
            this.SecurityMobilecolumnHead});
            this.listView2.Location = new System.Drawing.Point(12, 215);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(356, 125);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // AccesPointMobilecolumnHeader
            // 
            this.AccesPointMobilecolumnHeader.Text = "Acces Point";
            this.AccesPointMobilecolumnHeader.Width = 79;
            // 
            // SignalStrengthMobilecolumnHead
            // 
            this.SignalStrengthMobilecolumnHead.Text = "Signal strength";
            this.SignalStrengthMobilecolumnHead.Width = 85;
            // 
            // StatusMobilecolumnHead
            // 
            this.StatusMobilecolumnHead.Text = "Status";
            this.StatusMobilecolumnHead.Width = 93;
            // 
            // SecurityMobilecolumnHead
            // 
            this.SecurityMobilecolumnHead.Text = "Security";
            this.SecurityMobilecolumnHead.Width = 114;
            // 
            // connection_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.password_mobile_textBox);
            this.Controls.Add(this.password_mobile_label);
            this.Controls.Add(this.connect_mobile_button);
            this.Controls.Add(this.mobile_connect_checkBox);
            this.Controls.Add(this.wifi_connect_checkBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.listView1);
            this.Name = "connection_manager";
            this.Text = "connection_manager";
            this.Load += new System.EventHandler(this.connection_manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ColumnHeader chAccesPoint;
        private System.Windows.Forms.ColumnHeader chSignal;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chInfo;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.CheckBox wifi_connect_checkBox;
        private System.Windows.Forms.CheckBox mobile_connect_checkBox;
        private System.Windows.Forms.Button connect_mobile_button;
        private System.Windows.Forms.Label password_mobile_label;
        private System.Windows.Forms.TextBox password_mobile_textBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader AccesPointMobilecolumnHeader;
        private System.Windows.Forms.ColumnHeader SignalStrengthMobilecolumnHead;
        private System.Windows.Forms.ColumnHeader StatusMobilecolumnHead;
        private System.Windows.Forms.ColumnHeader SecurityMobilecolumnHead;
    }
}