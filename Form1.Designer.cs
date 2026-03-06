namespace Assessment
{
    partial class Form1
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
            AddBtn = new Button();
            SortBox = new ComboBox();
            label1 = new Label();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            TxtName = new TextBox();
            TxtAddress = new TextBox();
            TxtPhone = new TextBox();
            TxtEmail = new TextBox();
            SubmitBtn = new Button();
            BackBtn = new Button();
            DataGridViewClient = new DataGridView();
            TestLbl1 = new Label();
            TestLbl2 = new Label();
            TestLbl3 = new Label();
            UpdateCell = new Label();
            DdCatagory = new ComboBox();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewClient).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(644, 99);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SortBox
            // 
            SortBox.AutoCompleteCustomSource.AddRange(new string[] { "ClientID", "Name", "Category" });
            SortBox.FormattingEnabled = true;
            SortBox.Items.AddRange(new object[] { "ClientID", "ClientName", "ProductCatagory" });
            SortBox.Location = new Point(179, 100);
            SortBox.Name = "SortBox";
            SortBox.Size = new Size(74, 23);
            SortBox.TabIndex = 3;
            SortBox.Text = "select";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(75, 99);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 4;
            label1.Text = "Search By:";
            label1.Click += label1_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(259, 100);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(188, 23);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "Search Input";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(453, 101);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(178, 42);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Name";
            TxtName.Size = new Size(61, 23);
            TxtName.TabIndex = 8;
            TxtName.Visible = false;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(253, 42);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "Address";
            TxtAddress.Size = new Size(62, 23);
            TxtAddress.TabIndex = 9;
            TxtAddress.Visible = false;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(327, 42);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.PlaceholderText = "Phone number";
            TxtPhone.Size = new Size(66, 23);
            TxtPhone.TabIndex = 10;
            TxtPhone.Visible = false;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(404, 42);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(66, 23);
            TxtEmail.TabIndex = 11;
            TxtEmail.Visible = false;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(644, 42);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(75, 23);
            SubmitBtn.TabIndex = 13;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Visible = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(564, 42);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 14;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Visible = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // DataGridViewClient
            // 
            DataGridViewClient.AllowUserToOrderColumns = true;
            DataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewClient.Location = new Point(75, 143);
            DataGridViewClient.Name = "DataGridViewClient";
            DataGridViewClient.Size = new Size(644, 271);
            DataGridViewClient.TabIndex = 15;
            DataGridViewClient.CellEndEdit += DataGridViewClient_CellClick;
            // 
            // TestLbl1
            // 
            TestLbl1.AutoSize = true;
            TestLbl1.Location = new Point(8, 8);
            TestLbl1.Name = "TestLbl1";
            TestLbl1.Size = new Size(38, 15);
            TestLbl1.TabIndex = 17;
            TestLbl1.Text = "label2";
            TestLbl1.Visible = false;
            // 
            // TestLbl2
            // 
            TestLbl2.AutoSize = true;
            TestLbl2.Location = new Point(8, 32);
            TestLbl2.Name = "TestLbl2";
            TestLbl2.Size = new Size(38, 15);
            TestLbl2.TabIndex = 18;
            TestLbl2.Text = "label2";
            TestLbl2.Visible = false;
            // 
            // TestLbl3
            // 
            TestLbl3.AutoSize = true;
            TestLbl3.Location = new Point(8, 59);
            TestLbl3.Name = "TestLbl3";
            TestLbl3.Size = new Size(38, 15);
            TestLbl3.TabIndex = 19;
            TestLbl3.Text = "label2";
            TestLbl3.Visible = false;
            // 
            // UpdateCell
            // 
            UpdateCell.AutoSize = true;
            UpdateCell.Location = new Point(71, 9);
            UpdateCell.Name = "UpdateCell";
            UpdateCell.Size = new Size(38, 15);
            UpdateCell.TabIndex = 20;
            UpdateCell.Text = "label2";
            UpdateCell.Visible = false;
            // 
            // DdCatagory
            // 
            DdCatagory.AutoCompleteCustomSource.AddRange(new string[] { "ClientID", "Name", "Category" });
            DdCatagory.FormattingEnabled = true;
            DdCatagory.Items.AddRange(new object[] { "Game", "Food", "Electronics", "Metal" });
            DdCatagory.Location = new Point(484, 42);
            DdCatagory.Name = "DdCatagory";
            DdCatagory.Size = new Size(74, 23);
            DdCatagory.TabIndex = 21;
            DdCatagory.Text = "select";
            DdCatagory.Visible = false;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(534, 100);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 22;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 523);
            Controls.Add(resetBtn);
            Controls.Add(DdCatagory);
            Controls.Add(UpdateCell);
            Controls.Add(TestLbl3);
            Controls.Add(TestLbl2);
            Controls.Add(TestLbl1);
            Controls.Add(DataGridViewClient);
            Controls.Add(BackBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(TxtEmail);
            Controls.Add(TxtPhone);
            Controls.Add(TxtAddress);
            Controls.Add(TxtName);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Controls.Add(SortBox);
            Controls.Add(AddBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private ComboBox SortBox;
        private Label label1;
        private TextBox SearchBox;
        private Button SearchBtn;
        private TextBox TxtName;
        private TextBox TxtAddress;
        private TextBox TxtPhone;
        private TextBox TxtEmail;
        private Button SubmitBtn;
        private Button BackBtn;
        private DataGridView DataGridViewClient;
        private Label TestLbl1;
        private Label TestLbl2;
        private Label TestLbl3;
        private Label UpdateCell;
        private ComboBox DdCatagory;
        private Button resetBtn;
    }
}
