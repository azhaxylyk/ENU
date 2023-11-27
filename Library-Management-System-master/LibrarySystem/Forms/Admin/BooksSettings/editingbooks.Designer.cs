namespace LibrarySystem
{
    partial class editingbooks
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label numberOfCopiesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editingbooks));
            this.librarySystemDBDataSet = new LibrarySystem.LibrarySystemDBDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.booksTableAdapter();
            this.tableAdapterManager = new LibrarySystem.LibrarySystemDBDataSetTableAdapters.TableAdapterManager();
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.genretxt = new System.Windows.Forms.TextBox();
            this.noctxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            iSBNLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            numberOfCopiesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.Location = new System.Drawing.Point(31, 53);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(34, 20);
            iSBNLabel.TabIndex = 1;
            iSBNLabel.Text = "ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(31, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(52, 20);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Аты:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(31, 111);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(85, 20);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "Авторы:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(31, 140);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(116, 20);
            locationLabel.TabIndex = 7;
            locationLabel.Text = "Орналасуы:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(31, 169);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(61, 20);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Құны:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genreLabel.Location = new System.Drawing.Point(31, 227);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(63, 20);
            genreLabel.TabIndex = 11;
            genreLabel.Text = "Жанр:";
            // 
            // numberOfCopiesLabel
            // 
            numberOfCopiesLabel.AutoSize = true;
            numberOfCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfCopiesLabel.Location = new System.Drawing.Point(31, 198);
            numberOfCopiesLabel.Name = "numberOfCopiesLabel";
            numberOfCopiesLabel.Size = new System.Drawing.Size(104, 20);
            numberOfCopiesLabel.TabIndex = 13;
            numberOfCopiesLabel.Text = "Копиялар:";
            // 
            // librarySystemDBDataSet
            // 
            this.librarySystemDBDataSet.DataSetName = "LibrarySystemDBDataSet";
            this.librarySystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.librarySystemDBDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibrarySystem.LibrarySystemDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(350, 31);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
            this.booksBindingNavigator.RefreshItems += new System.EventHandler(this.booksBindingNavigator_RefreshItems);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.booksBindingNavigatorSaveItem.Text = "Save Data";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.ISBNtxt.Location = new System.Drawing.Point(169, 50);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(158, 26);
            this.ISBNtxt.TabIndex = 2;
            // 
            // titletxt
            // 
            this.titletxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.titletxt.Location = new System.Drawing.Point(169, 79);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(158, 26);
            this.titletxt.TabIndex = 4;
            // 
            // authortxt
            // 
            this.authortxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.authortxt.Location = new System.Drawing.Point(169, 108);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(158, 26);
            this.authortxt.TabIndex = 6;
            // 
            // locationtxt
            // 
            this.locationtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Location", true));
            this.locationtxt.Location = new System.Drawing.Point(169, 137);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(158, 26);
            this.locationtxt.TabIndex = 8;
            // 
            // pricetxt
            // 
            this.pricetxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricetxt.Location = new System.Drawing.Point(169, 166);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(64, 26);
            this.pricetxt.TabIndex = 10;
            // 
            // genretxt
            // 
            this.genretxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Genre", true));
            this.genretxt.Location = new System.Drawing.Point(169, 224);
            this.genretxt.Name = "genretxt";
            this.genretxt.Size = new System.Drawing.Size(158, 26);
            this.genretxt.TabIndex = 12;
            // 
            // noctxt
            // 
            this.noctxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "NumberOfCopies", true));
            this.noctxt.Location = new System.Drawing.Point(169, 195);
            this.noctxt.Name = "noctxt";
            this.noctxt.Size = new System.Drawing.Size(64, 26);
            this.noctxt.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(22, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Өзгерту";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(229, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Жою";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(21, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 27);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editingbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 364);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.ISBNtxt);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genretxt);
            this.Controls.Add(numberOfCopiesLabel);
            this.Controls.Add(this.noctxt);
            this.Controls.Add(this.booksBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "editingbooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Settings";
            this.Load += new System.EventHandler(this.editingbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibrarySystemDBDataSet librarySystemDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibrarySystemDBDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private LibrarySystemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox genretxt;
        private System.Windows.Forms.TextBox noctxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}