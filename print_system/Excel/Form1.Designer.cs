namespace Excel
{
    partial class Frmexcel
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
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnexcelex = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Location = new System.Drawing.Point(400, 432);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(112, 35);
            this.btnexcel.TabIndex = 1;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            //this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnexcelex
            // 
            this.btnexcelex.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnexcelex.Location = new System.Drawing.Point(540, 433);
            this.btnexcelex.Name = "btnexcelex";
            this.btnexcelex.Size = new System.Drawing.Size(105, 34);
            this.btnexcelex.TabIndex = 2;
            this.btnexcelex.Text = "Excel Ex";
            this.btnexcelex.UseVisualStyleBackColor = true;
           // this.btnexcelex.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnprint.Location = new System.Drawing.Point(282, 436);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(98, 31);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // Frmexcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 580);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexcelex);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frmexcel";
            this.Text = "excel";
            this.Load += new System.EventHandler(this.Frmexcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnexcelex;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

