namespace LibrarySystem.Forms.Admin.user_settings
{
    partial class editingusers
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label isBlockedLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editingusers));
            this.librarySystemDBDataSet = new LibrarySystem.LibrarySystemDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.TableAdapterManager();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.isBlockedCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            isBlockedLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(45, 43);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(34, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(45, 72);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(52, 20);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "Аты:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(45, 101);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(51, 20);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Тегі:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(45, 130);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(100, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Құпиясөз:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(45, 161);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(53, 20);
            typeLabel.TabIndex = 9;
            typeLabel.Text = "Типі:";
            // 
            // isBlockedLabel
            // 
            isBlockedLabel.AutoSize = true;
            isBlockedLabel.Location = new System.Drawing.Point(45, 191);
            isBlockedLabel.Name = "isBlockedLabel";
            isBlockedLabel.Size = new System.Drawing.Size(132, 20);
            isBlockedLabel.TabIndex = 11;
            isBlockedLabel.Text = "Бұғатталған:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(45, 219);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(98, 20);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(45, 248);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(128, 20);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Мекен-жайы:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(45, 277);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(106, 20);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Эл. почта:";
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
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(538, 31);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(221, 43);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(78, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(221, 72);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(269, 26);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(221, 101);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(269, 26);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(221, 130);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(269, 26);
            this.passwordTextBox.TabIndex = 8;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Type", true));
            this.typeCheckBox.Location = new System.Drawing.Point(221, 159);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(269, 24);
            this.typeCheckBox.TabIndex = 10;
            this.typeCheckBox.Text = "checkBox1";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // isBlockedCheckBox
            // 
            this.isBlockedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "isBlocked", true));
            this.isBlockedCheckBox.Location = new System.Drawing.Point(221, 189);
            this.isBlockedCheckBox.Name = "isBlockedCheckBox";
            this.isBlockedCheckBox.Size = new System.Drawing.Size(269, 24);
            this.isBlockedCheckBox.TabIndex = 12;
            this.isBlockedCheckBox.Text = "checkBox1";
            this.isBlockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(221, 219);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(269, 26);
            this.phoneTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(221, 248);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(269, 26);
            this.addressTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(221, 277);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(269, 26);
            this.emailTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(49, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 30);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(392, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "Жою";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(49, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 26);
            this.button3.TabIndex = 29;
            this.button3.Text = "Өзгерту";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editingusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(isBlockedLabel);
            this.Controls.Add(this.isBlockedCheckBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "editingusers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.editingusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibrarySystemDBDataSet librarySystemDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibrarySystemDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private LibrarySystemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox isBlockedCheckBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}