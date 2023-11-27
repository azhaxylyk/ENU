namespace LibrarySystem.Forms.User
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.button2 = new System.Windows.Forms.Button();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requestdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.duedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.borrowCheckBox = new System.Windows.Forms.CheckBox();
            this.buyCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(25, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 33);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(164, 111);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(259, 22);
            this.isbnTextBox.TabIndex = 24;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(164, 70);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(259, 22);
            this.idTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Кітап ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Қолданушы ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Типі:";
            // 
            // requestdateTimePicker
            // 
            this.requestdateTimePicker.Location = new System.Drawing.Point(164, 156);
            this.requestdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.requestdateTimePicker.Name = "requestdateTimePicker";
            this.requestdateTimePicker.Size = new System.Drawing.Size(259, 22);
            this.requestdateTimePicker.TabIndex = 31;
            // 
            // duedateTimePicker
            // 
            this.duedateTimePicker.Location = new System.Drawing.Point(164, 209);
            this.duedateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.duedateTimePicker.Name = "duedateTimePicker";
            this.duedateTimePicker.Size = new System.Drawing.Size(259, 22);
            this.duedateTimePicker.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Сұраныс күні:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Мерзімнің өту:";
            // 
            // borrowCheckBox
            // 
            this.borrowCheckBox.AutoSize = true;
            this.borrowCheckBox.Location = new System.Drawing.Point(164, 31);
            this.borrowCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.borrowCheckBox.Name = "borrowCheckBox";
            this.borrowCheckBox.Size = new System.Drawing.Size(82, 20);
            this.borrowCheckBox.TabIndex = 35;
            this.borrowCheckBox.Text = "Жалдау";
            this.borrowCheckBox.UseVisualStyleBackColor = true;
            // 
            // buyCheckBox
            // 
            this.buyCheckBox.AutoSize = true;
            this.buyCheckBox.Location = new System.Drawing.Point(317, 31);
            this.buyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyCheckBox.Name = "buyCheckBox";
            this.buyCheckBox.Size = new System.Drawing.Size(97, 20);
            this.buyCheckBox.TabIndex = 36;
            this.buyCheckBox.Text = "Сатып алу";
            this.buyCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Аяқтау";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buyCheckBox);
            this.Controls.Add(this.borrowCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.duedateTimePicker);
            this.Controls.Add(this.requestdateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker requestdateTimePicker;
        private System.Windows.Forms.DateTimePicker duedateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox borrowCheckBox;
        private System.Windows.Forms.CheckBox buyCheckBox;
        private System.Windows.Forms.Button button1;
    }
}