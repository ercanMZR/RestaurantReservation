namespace RestaurantReservation.Forms
{
    partial class AddOrder
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbReservCustomer = new ComboBox();
            cmbMenus = new ComboBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            dtmOrderDate = new DateTimePicker();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "ReservDate-Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Menus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 193);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "OrderDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 272);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantity";
            // 
            // cmbReservCustomer
            // 
            cmbReservCustomer.FormattingEnabled = true;
            cmbReservCustomer.Location = new Point(289, 38);
            cmbReservCustomer.Name = "cmbReservCustomer";
            cmbReservCustomer.Size = new Size(151, 28);
            cmbReservCustomer.TabIndex = 1;
            // 
            // cmbMenus
            // 
            cmbMenus.FormattingEnabled = true;
            cmbMenus.Location = new Point(289, 114);
            cmbMenus.Name = "cmbMenus";
            cmbMenus.Size = new Size(151, 28);
            cmbMenus.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(517, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 254);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(346, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1029, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtmOrderDate
            // 
            dtmOrderDate.Location = new Point(289, 193);
            dtmOrderDate.Name = "dtmOrderDate";
            dtmOrderDate.Size = new Size(151, 27);
            dtmOrderDate.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(289, 265);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 27);
            txtQuantity.TabIndex = 5;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 544);
            Controls.Add(txtQuantity);
            Controls.Add(dtmOrderDate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(cmbMenus);
            Controls.Add(cmbReservCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += AddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbReservCustomer;
        private ComboBox cmbMenus;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private DateTimePicker dtmOrderDate;
        private TextBox txtQuantity;
    }
}