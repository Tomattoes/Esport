namespace LKS_SA_AhmadIrwansyah
{
    partial class Admin_TransferPlayer
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
            this.button_book = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NS_2 = new System.Windows.Forms.Label();
            this.NS_1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esemkaEsportDataSet4 = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet4();
            this.teamTableAdapter = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet4TableAdapters.teamTableAdapter();
            this.esemkaEsportDataSet5 = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet5();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet5TableAdapters.playerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.esemkaEsportDataSet6 = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet6();
            this.playerTableAdapter1 = new LKS_SA_AhmadIrwansyah.EsemkaEsportDataSet6TableAdapters.playerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button_book
            // 
            this.button_book.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_book.FlatAppearance.BorderSize = 0;
            this.button_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_book.ForeColor = System.Drawing.Color.White;
            this.button_book.Location = new System.Drawing.Point(949, 637);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(149, 34);
            this.button_book.TabIndex = 25;
            this.button_book.Text = "Add/Edit Player";
            this.button_book.UseVisualStyleBackColor = false;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(728, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(370, 416);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NS_2
            // 
            this.NS_2.AutoSize = true;
            this.NS_2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NS_2.ForeColor = System.Drawing.Color.White;
            this.NS_2.Location = new System.Drawing.Point(484, 51);
            this.NS_2.Name = "NS_2";
            this.NS_2.Size = new System.Drawing.Size(229, 34);
            this.NS_2.TabIndex = 18;
            this.NS_2.Text = "Transfer Player";
            // 
            // NS_1
            // 
            this.NS_1.AutoSize = true;
            this.NS_1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NS_1.ForeColor = System.Drawing.Color.White;
            this.NS_1.Location = new System.Drawing.Point(202, 140);
            this.NS_1.Name = "NS_1";
            this.NS_1.Size = new System.Drawing.Size(173, 34);
            this.NS_1.TabIndex = 17;
            this.NS_1.Text = "Free Player";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(101, 45);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 40);
            this.button_back.TabIndex = 16;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LKS_SA_AhmadIrwansyah.Properties.Resources.Left;
            this.pictureBox3.Location = new System.Drawing.Point(517, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LKS_SA_AhmadIrwansyah.Properties.Resources.Right;
            this.pictureBox1.Location = new System.Drawing.Point(517, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamBindingSource;
            this.comboBox1.DisplayMember = "team_name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(728, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 37);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.esemkaEsportDataSet4;
            // 
            // esemkaEsportDataSet4
            // 
            this.esemkaEsportDataSet4.DataSetName = "EsemkaEsportDataSet4";
            this.esemkaEsportDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // esemkaEsportDataSet5
            // 
            this.esemkaEsportDataSet5.DataSetName = "EsemkaEsportDataSet5";
            this.esemkaEsportDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "player";
            this.playerBindingSource.DataSource = this.esemkaEsportDataSet5;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(101, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(370, 416);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataMember = "player";
            this.playerBindingSource1.DataSource = this.esemkaEsportDataSet6;
            // 
            // esemkaEsportDataSet6
            // 
            this.esemkaEsportDataSet6.DataSetName = "EsemkaEsportDataSet6";
            this.esemkaEsportDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter1
            // 
            this.playerTableAdapter1.ClearBeforeFill = true;
            // 
            // Admin_TransferPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NS_2);
            this.Controls.Add(this.NS_1);
            this.Controls.Add(this.button_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_TransferPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_TransferPlayer";
            this.Load += new System.EventHandler(this.Admin_TransferPlayer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esemkaEsportDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NS_2;
        private System.Windows.Forms.Label NS_1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private EsemkaEsportDataSet4 esemkaEsportDataSet4;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private EsemkaEsportDataSet4TableAdapters.teamTableAdapter teamTableAdapter;
        private EsemkaEsportDataSet5 esemkaEsportDataSet5;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private EsemkaEsportDataSet5TableAdapters.playerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private EsemkaEsportDataSet6 esemkaEsportDataSet6;
        private System.Windows.Forms.BindingSource playerBindingSource1;
        private EsemkaEsportDataSet6TableAdapters.playerTableAdapter playerTableAdapter1;
    }
}