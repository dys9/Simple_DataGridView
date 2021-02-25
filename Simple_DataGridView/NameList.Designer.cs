namespace Simple_DataGridView
{
    partial class NameList
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
            this.Legends = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Legends)).BeginInit();
            this.SuspendLayout();
            // 
            // Legends
            // 
            this.Legends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Legends.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Legends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Legends.Location = new System.Drawing.Point(12, 12);
            this.Legends.Name = "Legends";
            this.Legends.RowTemplate.Height = 23;
            this.Legends.Size = new System.Drawing.Size(260, 150);
            this.Legends.TabIndex = 0;
            // 
            // NameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Legends);
            this.Name = "NameList";
            this.Text = "NameList";
            ((System.ComponentModel.ISupportInitialize)(this.Legends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Legends;
    }
}