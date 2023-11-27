namespace LibrarySystem
{
    partial class UserSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label isBlockedLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.librarySystemDBDataSet = new LibrarySystem.LibrarySystemDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            isBlockedLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(37, 55);
            first_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(52, 20);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "Аты:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(37, 85);
            last_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(51, 20);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Тегі:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(37, 115);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(100, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Құпиясөз:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(37, 147);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(157, 20);
            typeLabel.TabIndex = 9;
            typeLabel.Text = "Админ рұқсаты:";
            // 
            // isBlockedLabel
            // 
            isBlockedLabel.AutoSize = true;
            isBlockedLabel.Location = new System.Drawing.Point(37, 182);
            isBlockedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            isBlockedLabel.Name = "isBlockedLabel";
            isBlockedLabel.Size = new System.Drawing.Size(132, 20);
            isBlockedLabel.TabIndex = 11;
            isBlockedLabel.Text = "Бұғатталған:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(37, 214);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(98, 20);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(37, 244);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(128, 20);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Мекен-жайы:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(37, 274);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(110, 20);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Эл. пошта:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 25);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 20);
            label1.TabIndex = 24;
            label1.Text = "ID:";
            // 
            // librarySystemDBDataSet
            // 
            this.librarySystemDBDataSet.DataSetName = "LibrarySystemDBDataSet";
            this.librarySystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.librarySystemDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibrarySystem.LibrarySystemDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(41, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(295, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Жою";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(41, 312);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 30);
            this.button3.TabIndex = 22;
            this.button3.Text = "Өзгерту";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Type", true));
            this.typeCheckBox.Location = new System.Drawing.Point(205, 172);
            this.typeCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(34, 28);
            this.typeCheckBox.TabIndex = 26;
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Type", true));
            this.checkBox1.Location = new System.Drawing.Point(205, 144);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 28);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(205, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 26);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 26);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 26);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(205, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 26);
            this.textBox4.TabIndex = 38;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(205, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 26);
            this.textBox5.TabIndex = 39;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(205, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 26);
            this.textBox6.TabIndex = 40;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
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
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibrarySystemDBDataSet librarySystemDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibrarySystemDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private LibrarySystemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}