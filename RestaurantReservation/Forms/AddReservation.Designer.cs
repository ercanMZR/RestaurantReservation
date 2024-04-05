namespace RestaurantReservation.Forms
{
    partial class AddReservation
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
            cmbCustomers = new ComboBox();
            label2 = new Label();
            dateTimeReservation = new DateTimePicker();
            label3 = new Label();
            txtNotes = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(12, 58);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(250, 28);
            cmbCustomers.TabIndex = 1;
            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Reservation Date";
            // 
            // dateTimeReservation
            // 
            dateTimeReservation.Location = new Point(12, 160);
            dateTimeReservation.Name = "dateTimeReservation";
            dateTimeReservation.Size = new Size(250, 27);
            dateTimeReservation.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(12, 260);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 27);
            txtNotes.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(168, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(864, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(644, 232);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 604);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtNotes);
            Controls.Add(label3);
            Controls.Add(dateTimeReservation);
            Controls.Add(label2);
            Controls.Add(cmbCustomers);
            Controls.Add(label1);
            Name = "AddReservation";
            Text = "AddReservation";
            Load += AddReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCustomers;
        private Label label2;
        private DateTimePicker dateTimeReservation;
        private Label label3;
        private TextBox txtNotes;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}