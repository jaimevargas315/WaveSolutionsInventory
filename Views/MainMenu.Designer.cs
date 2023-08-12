namespace Capstone
{
    partial class MainMenu
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
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(996, 740);
            button2.Name = "button2";
            button2.Size = new Size(137, 62);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(400, 36);
            label1.Name = "label1";
            label1.Size = new Size(474, 106);
            label1.TabIndex = 7;
            label1.Text = "Main Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(297, 293);
            button1.Name = "button1";
            button1.Size = new Size(191, 108);
            button1.TabIndex = 12;
            button1.Text = "Bulk Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(540, 293);
            button3.Name = "button3";
            button3.Size = new Size(191, 108);
            button3.TabIndex = 13;
            button3.Text = "Storage";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(784, 293);
            button4.Name = "button4";
            button4.Size = new Size(191, 108);
            button4.TabIndex = 14;
            button4.Text = "Orders";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(540, 437);
            button5.Name = "button5";
            button5.Size = new Size(191, 108);
            button5.TabIndex = 15;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(297, 437);
            button6.Name = "button6";
            button6.Size = new Size(191, 108);
            button6.TabIndex = 16;
            button6.Text = "Bulk Remove";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Navy;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(784, 437);
            button7.Name = "button7";
            button7.Size = new Size(191, 108);
            button7.TabIndex = 17;
            button7.Text = "Manager Functions";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1284, 861);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}