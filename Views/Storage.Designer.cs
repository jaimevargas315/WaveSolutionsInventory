namespace Capstone
{
    partial class Storage
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            button6 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(472, 1);
            label1.Name = "label1";
            label1.Size = new Size(281, 89);
            label1.TabIndex = 9;
            label1.Text = "Storage";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Inhouse Part", "Outsourced Part", "Product" });
            comboBox1.Location = new Point(557, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 45);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1045, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 45);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(328, 603);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(207, 45);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(227, 671);
            button2.Name = "button2";
            button2.Size = new Size(137, 71);
            button2.TabIndex = 16;
            button2.Text = "Move Selected";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1073, 760);
            button6.Name = "button6";
            button6.Size = new Size(137, 71);
            button6.TabIndex = 22;
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
            button4.Location = new Point(71, 760);
            button4.Name = "button4";
            button4.Size = new Size(137, 71);
            button4.TabIndex = 20;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Navy;
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(615, 382);
            dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BackgroundColor = Color.DodgerBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Navy;
            dataGridView2.Location = new Point(657, 200);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(615, 382);
            dataGridView2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(418, 101);
            label2.Name = "label2";
            label2.Size = new Size(133, 37);
            label2.TabIndex = 25;
            label2.Text = "Item Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(757, 152);
            label3.Name = "label3";
            label3.Size = new Size(282, 37);
            label3.TabIndex = 26;
            label3.Text = "View Storage Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(262, 152);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 27;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(128, 606);
            label5.Name = "label5";
            label5.Size = new Size(180, 37);
            label5.TabIndex = 28;
            label5.Text = "New Location";
            // 
            // Storage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1284, 861);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Storage";
            Text = "Storage";
            Load += Storage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button2;
        private Button button6;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}