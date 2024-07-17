namespace ShabatGuest
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_welcome = new Label();
            label_guestInput = new Label();
            textBox_guestName = new TextBox();
            button_login = new Button();
            listView_GuestsList = new ListView();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI", 20F);
            label_welcome.Location = new Point(254, 26);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(225, 46);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "ברוכים הבאים";
            // 
            // label_guestInput
            // 
            label_guestInput.AutoSize = true;
            label_guestInput.Font = new Font("Segoe UI", 15F);
            label_guestInput.Location = new Point(301, 84);
            label_guestInput.Name = "label_guestInput";
            label_guestInput.Size = new Size(178, 35);
            label_guestInput.TabIndex = 1;
            label_guestInput.Text = "הכנס שם אורח";
            // 
            // textBox_guestName
            // 
            textBox_guestName.Font = new Font("Segoe UI", 16F);
            textBox_guestName.Location = new Point(354, 133);
            textBox_guestName.Name = "textBox_guestName";
            textBox_guestName.RightToLeft = RightToLeft.Yes;
            textBox_guestName.Size = new Size(125, 43);
            textBox_guestName.TabIndex = 2;
            // 
            // button_login
            // 
            button_login.Location = new Point(372, 399);
            button_login.Name = "button_login";
            button_login.Size = new Size(107, 39);
            button_login.TabIndex = 4;
            button_login.Text = "אישור";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // listView_GuestsList
            // 
            listView_GuestsList.Location = new Point(254, 182);
            listView_GuestsList.Name = "listView_GuestsList";
            listView_GuestsList.Size = new Size(225, 211);
            listView_GuestsList.TabIndex = 5;
            listView_GuestsList.UseCompatibleStateImageBehavior = false;
            listView_GuestsList.MouseDoubleClick += listView_GuestsList_MouseDoubleClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_GuestsList);
            Controls.Add(button_login);
            Controls.Add(textBox_guestName);
            Controls.Add(label_guestInput);
            Controls.Add(label_welcome);
            Name = "LoginForm";
            Text = "Form1";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome;
        private Label label_guestInput;
        private TextBox textBox_guestName;
        private Button button_login;
        private ListView listView_GuestsList;
    }
}
