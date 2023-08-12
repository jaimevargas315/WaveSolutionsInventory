namespace Capstone
{
    partial class Orders
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
            label4 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 166);
            label4.Name = "label4";
            label4.Size = new Size(210, 37);
            label4.TabIndex = 35;
            label4.Text = "Assigned Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(870, 166);
            label3.Name = "label3";
            label3.Size = new Size(180, 37);
            label3.TabIndex = 34;
            label3.Text = "Current Order";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = Color.DodgerBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Navy;
            dataGridView2.Location = new Point(657, 214);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(615, 382);
            dataGridView2.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Navy;
            dataGridView1.Location = new Point(12, 214);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(615, 382);
            dataGridView1.TabIndex = 32;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1073, 774);
            button6.Name = "button6";
            button6.Size = new Size(137, 71);
            button6.TabIndex = 31;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(71, 774);
            button4.Name = "button4";
            button4.Size = new Size(137, 71);
            button4.TabIndex = 30;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(227, 618);
            button2.Name = "button2";
            button2.Size = new Size(160, 71);
            button2.TabIndex = 29;
            button2.Text = "Set As Current Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(505, 21);
            label1.Name = "label1";
            label1.Size = new Size(249, 89);
            label1.TabIndex = 28;
            label1.Text = "Orders";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(890, 618);
            button1.Name = "button1";
            button1.Size = new Size(160, 71);
            button1.TabIndex = 36;
            button1.Text = "Mark As Complete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1284, 861);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button4;
        private Button button2;
        private Label label1;
        private Button button1;
    }
}