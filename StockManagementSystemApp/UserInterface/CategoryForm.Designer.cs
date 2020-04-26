namespace StockManagementSystemApp
{
    partial class CategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryList = new System.Windows.Forms.GroupBox();
            this.categoryItemListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.categoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(310, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 35);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveCategoryClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(184, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 32);
            this.nameTextBox.TabIndex = 2;
            // 
            // categoryList
            // 
            this.categoryList.Controls.Add(this.categoryItemListView);
            this.categoryList.Location = new System.Drawing.Point(13, 198);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(417, 421);
            this.categoryList.TabIndex = 3;
            this.categoryList.TabStop = false;
            this.categoryList.Text = "Categry List";
            // 
            // categoryItemListView
            // 
            this.categoryItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.categoryItemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryItemListView.FullRowSelect = true;
            this.categoryItemListView.GridLines = true;
            this.categoryItemListView.HoverSelection = true;
            this.categoryItemListView.Location = new System.Drawing.Point(3, 28);
            this.categoryItemListView.Name = "categoryItemListView";
            this.categoryItemListView.Size = new System.Drawing.Size(411, 390);
            this.categoryItemListView.TabIndex = 0;
            this.categoryItemListView.UseCompatibleStateImageBehavior = false;
            this.categoryItemListView.View = System.Windows.Forms.View.Details;
            this.categoryItemListView.DoubleClick += new System.EventHandler(this.UpdateByDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sl.";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Location = new System.Drawing.Point(5, 9);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(0, 24);
            this.hiddenLabel.TabIndex = 4;
            this.hiddenLabel.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(204, 91);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateCategoryClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 631);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.hiddenLabel);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Consolas", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CategoryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Form";
            this.Load += new System.EventHandler(this.CategoryFormLoad);
            this.categoryList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox categoryList;
        private System.Windows.Forms.ListView categoryItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.Button updateButton;
    }
}

