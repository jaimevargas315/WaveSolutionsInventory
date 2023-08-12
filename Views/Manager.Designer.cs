namespace Capstone
{
    partial class Manager
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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Navy;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(798, 417);
            button7.Name = "button7";
            button7.Size = new Size(191, 108);
            button7.TabIndex = 25;
            button7.Text = "Add Inventory";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(311, 417);
            button6.Name = "button6";
            button6.Size = new Size(191, 108);
            button6.TabIndex = 24;
            button6.Text = "Add User";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(554, 417);
            button5.Name = "button5";
            button5.Size = new Size(191, 108);
            button5.TabIndex = 23;
            button5.Text = "Add Order";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(798, 273);
            button4.Name = "button4";
            button4.Size = new Size(191, 108);
            button4.TabIndex = 22;
            button4.Text = "Edit Inventory";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(554, 273);
            button3.Name = "button3";
            button3.Size = new Size(191, 108);
            button3.TabIndex = 21;
            button3.Text = "Edit Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(311, 273);
            button1.Name = "button1";
            button1.Size = new Size(191, 108);
            button1.TabIndex = 20;
            button1.Text = "Edit Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1059, 738);
            button2.Name = "button2";
            button2.Size = new Size(137, 62);
            button2.TabIndex = 19;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(327, 47);
            label1.Name = "label1";
            label1.Size = new Size(642, 89);
            label1.TabIndex = 18;
            label1.Text = "Manager Functions";
            // 
            // button8
            // 
            button8.BackColor = Color.Navy;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(75, 738);
            button8.Name = "button8";
            button8.Size = new Size(137, 62);
            button8.TabIndex = 26;
            button8.Text = "Go Back";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Navy;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(554, 563);
            button9.Name = "button9";
            button9.Size = new Size(191, 108);
            button9.TabIndex = 27;
            button9.Text = "Reports";
            button9.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1284, 861);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button8;
        private Button button9;
    }
}