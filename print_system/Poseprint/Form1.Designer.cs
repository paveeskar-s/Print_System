namespace Poseprint
{
    partial class PoseForm
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
            this.btnposeprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnposeprint
            // 
            this.btnposeprint.Location = new System.Drawing.Point(334, 263);
            this.btnposeprint.Name = "btnposeprint";
            this.btnposeprint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnposeprint.Size = new System.Drawing.Size(129, 38);
            this.btnposeprint.TabIndex = 1;
            this.btnposeprint.Text = "Poseprint";
            this.btnposeprint.UseVisualStyleBackColor = true;
            this.btnposeprint.Click += new System.EventHandler(this.btnposeprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnposeprint);
            this.Name = "PoseForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnposeprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

