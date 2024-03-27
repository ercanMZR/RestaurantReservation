namespace RestaurantReservation.Forms
{
    partial class AddMenu
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
            dgvMenus = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtTitle = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
            SuspendLayout();
            // 
            // dgvMenus
            // 
            dgvMenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenus.Location = new Point(12, 351);
            dgvMenus.Name = "dgvMenus";
            dgvMenus.RowHeadersWidth = 51;
            dgvMenus.Size = new Size(648, 188);
            dgvMenus.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(112, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.Location = new Point(262, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(422, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(371, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(145, 27);
            txtTitle.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 71);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Title:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(371, 132);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(145, 27);
            txtDescription.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 139);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 13;
            label3.Text = "Description:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(371, 195);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(145, 27);
            txtPrice.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 198);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 14;
            label1.Text = "Price:";
            // 
            // AddMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 551);
            Controls.Add(dgvMenus);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Name = "AddMenu";
            Text = "AddMenu";
            Load += AddMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMenus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtTitle;
        private Label label5;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtPrice;
        private Label label1;
    }
}