namespace LibrarySystem.Forms.Admin.UserSettings
{
    partial class AddNewUser
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label isBlockedLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.blockCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            isBlockedLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 24);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 20);
            label1.TabIndex = 49;
            label1.Text = "ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(39, 59);
            first_NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(52, 20);
            first_NameLabel.TabIndex = 41;
            first_NameLabel.Text = "Аты:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(39, 93);
            last_NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(51, 20);
            last_NameLabel.TabIndex = 42;
            last_NameLabel.Text = "Тегі:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(39, 128);
            passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(100, 20);
            passwordLabel.TabIndex = 43;
            passwordLabel.Text = "Құпиясөз:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(39, 165);
            typeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(157, 20);
            typeLabel.TabIndex = 44;
            typeLabel.Text = "Админ рұқсаты:";
            // 
            // isBlockedLabel
            // 
            isBlockedLabel.AutoSize = true;
            isBlockedLabel.Location = new System.Drawing.Point(39, 205);
            isBlockedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            isBlockedLabel.Name = "isBlockedLabel";
            isBlockedLabel.Size = new System.Drawing.Size(132, 20);
            isBlockedLabel.TabIndex = 45;
            isBlockedLabel.Text = "Бұғатталған:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(39, 242);
            phoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(98, 20);
            phoneLabel.TabIndex = 46;
            phoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(39, 277);
            addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(128, 20);
            addressLabel.TabIndex = 47;
            addressLabel.Text = "Мекен-жайы:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(39, 312);
            emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(110, 20);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "Эл. пошта:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(170, 312);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(354, 26);
            this.emailTextBox.TabIndex = 58;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(170, 277);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(354, 26);
            this.addressTextBox.TabIndex = 57;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(170, 242);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(354, 26);
            this.phoneTextBox.TabIndex = 56;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(170, 128);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(354, 26);
            this.passwordTextBox.TabIndex = 55;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.Location = new System.Drawing.Point(170, 93);
            this.last_nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(354, 26);
            this.last_nameTextBox.TabIndex = 54;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.Location = new System.Drawing.Point(170, 59);
            this.first_nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(354, 26);
            this.first_nameTextBox.TabIndex = 53;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(170, 21);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(148, 26);
            this.iDTextBox.TabIndex = 52;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeCheckBox.Location = new System.Drawing.Point(255, 159);
            this.typeCheckBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(44, 32);
            this.typeCheckBox.TabIndex = 51;
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // blockCheckBox
            // 
            this.blockCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockCheckBox.Location = new System.Drawing.Point(255, 197);
            this.blockCheckBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.blockCheckBox.Name = "blockCheckBox";
            this.blockCheckBox.Size = new System.Drawing.Size(51, 32);
            this.blockCheckBox.TabIndex = 50;
            this.blockCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 59;
            this.button1.Text = "сақтау";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(42, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 27);
            this.button2.TabIndex = 60;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.blockCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(isBlockedLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(emailLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox blockCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}