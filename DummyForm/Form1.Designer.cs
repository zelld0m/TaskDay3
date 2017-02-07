namespace DummyForm
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_search = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.Tb_Delete = new System.Windows.Forms.TextBox();
            this.Tb_Add = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.TB_SelectID = new System.Windows.Forms.TextBox();
            this.Tb_NameChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(171, 232);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(75, 23);
            this.Btn_search.TabIndex = 1;
            this.Btn_search.Text = "Search";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(292, 231);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(159, 206);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(100, 20);
            this.Tb_Search.TabIndex = 3;
            this.Tb_Search.TextChanged += new System.EventHandler(this.Tb_Search_TextChanged);
            // 
            // Tb_Delete
            // 
            this.Tb_Delete.Location = new System.Drawing.Point(282, 206);
            this.Tb_Delete.Name = "Tb_Delete";
            this.Tb_Delete.Size = new System.Drawing.Size(100, 20);
            this.Tb_Delete.TabIndex = 4;
            this.Tb_Delete.TextChanged += new System.EventHandler(this.Tb_Delete_TextChanged);
            // 
            // Tb_Add
            // 
            this.Tb_Add.Location = new System.Drawing.Point(28, 206);
            this.Tb_Add.Name = "Tb_Add";
            this.Tb_Add.Size = new System.Drawing.Size(100, 20);
            this.Tb_Add.TabIndex = 5;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(40, 232);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 6;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(171, 304);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // TB_SelectID
            // 
            this.TB_SelectID.Location = new System.Drawing.Point(28, 273);
            this.TB_SelectID.Name = "TB_SelectID";
            this.TB_SelectID.Size = new System.Drawing.Size(100, 20);
            this.TB_SelectID.TabIndex = 9;
            // 
            // Tb_NameChange
            // 
            this.Tb_NameChange.Location = new System.Drawing.Point(282, 273);
            this.Tb_NameChange.Name = "Tb_NameChange";
            this.Tb_NameChange.Size = new System.Drawing.Size(100, 20);
            this.Tb_NameChange.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_NameChange);
            this.Controls.Add(this.TB_SelectID);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Tb_Add);
            this.Controls.Add(this.Tb_Delete);
            this.Controls.Add(this.Tb_Search);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.TextBox Tb_Delete;
        private System.Windows.Forms.TextBox Tb_Add;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox TB_SelectID;
        private System.Windows.Forms.TextBox Tb_NameChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

