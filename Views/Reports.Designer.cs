namespace Capstone
{
    partial class Reports
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 169);
            label2.Name = "label2";
            label2.Size = new Size(159, 37);
            label2.TabIndex = 42;
            label2.Text = "Report Type";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Navy;
            dataGridView1.Location = new Point(43, 217);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1198, 474);
            dataGridView1.TabIndex = 41;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1104, 777);
            button6.Name = "button6";
            button6.Size = new Size(137, 71);
            button6.TabIndex = 40;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(102, 777);
            button4.Name = "button4";
            button4.Size = new Size(137, 71);
            button4.TabIndex = 39;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(615, 777);
            button2.Name = "button2";
            button2.Size = new Size(137, 71);
            button2.TabIndex = 38;
            button2.Text = "Print Report";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(587, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 45);
            comboBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(500, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 89);
            label1.TabIndex = 36;
            label1.Text = "Reports";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1284, 861);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button4;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
    }
}