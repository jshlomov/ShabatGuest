namespace ShabatGuest.View
{
    partial class FoodForm
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
            label_Category = new Label();
            dataGridView_orderedFood = new DataGridView();
            textBox_newFood = new TextBox();
            button_insertFood = new Button();
            button_right = new Button();
            button_left = new Button();
            listBox_foodList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_orderedFood).BeginInit();
            SuspendLayout();
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Location = new Point(327, 10);
            label_Category.Name = "label_Category";
            label_Category.Size = new Size(50, 20);
            label_Category.TabIndex = 0;
            label_Category.Text = "label1";
            label_Category.Click += label1_Click;
            // 
            // dataGridView_orderedFood
            // 
            dataGridView_orderedFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_orderedFood.Location = new Point(120, 49);
            dataGridView_orderedFood.Name = "dataGridView_orderedFood";
            dataGridView_orderedFood.RowHeadersWidth = 51;
            dataGridView_orderedFood.Size = new Size(558, 188);
            dataGridView_orderedFood.TabIndex = 1;
            // 
            // textBox_newFood
            // 
            textBox_newFood.Location = new Point(394, 245);
            textBox_newFood.Name = "textBox_newFood";
            textBox_newFood.Size = new Size(125, 27);
            textBox_newFood.TabIndex = 2;
            textBox_newFood.TextChanged += textBox_newFood_TextChanged;
            // 
            // button_insertFood
            // 
            button_insertFood.Location = new Point(224, 243);
            button_insertFood.Name = "button_insertFood";
            button_insertFood.Size = new Size(94, 29);
            button_insertFood.TabIndex = 3;
            button_insertFood.Text = "אישור";
            button_insertFood.UseVisualStyleBackColor = true;
            button_insertFood.Click += button_insertFood_Click;
            // 
            // button_right
            // 
            button_right.Location = new Point(439, 463);
            button_right.Name = "button_right";
            button_right.Size = new Size(94, 29);
            button_right.TabIndex = 5;
            button_right.Text = ">>";
            button_right.UseVisualStyleBackColor = true;
            button_right.Click += button_right_Click;
            // 
            // button_left
            // 
            button_left.Location = new Point(224, 463);
            button_left.Name = "button_left";
            button_left.Size = new Size(94, 29);
            button_left.TabIndex = 6;
            button_left.Text = "<<";
            button_left.UseVisualStyleBackColor = true;
            button_left.Click += button_left_Click;
            // 
            // listBox_foodList
            // 
            listBox_foodList.FormattingEnabled = true;
            listBox_foodList.Location = new Point(214, 295);
            listBox_foodList.Name = "listBox_foodList";
            listBox_foodList.RightToLeft = RightToLeft.Yes;
            listBox_foodList.Size = new Size(377, 144);
            listBox_foodList.TabIndex = 7;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 532);
            Controls.Add(listBox_foodList);
            Controls.Add(button_left);
            Controls.Add(button_right);
            Controls.Add(button_insertFood);
            Controls.Add(textBox_newFood);
            Controls.Add(dataGridView_orderedFood);
            Controls.Add(label_Category);
            Name = "FoodForm";
            Text = "FoodForm";
            FormClosing += FoodForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView_orderedFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Category;
        private DataGridView dataGridView_orderedFood;
        private TextBox textBox_newFood;
        private Button button_insertFood;
        private Button button_right;
        private Button button_left;
        private ListBox listBox_foodList;
    }
}