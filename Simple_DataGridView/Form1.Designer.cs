namespace Simple_DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCx = new System.Windows.Forms.TextBox();
            this.tbCy = new System.Windows.Forms.TextBox();
            this.tbTrans = new System.Windows.Forms.TextBox();
            this.chtResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 12);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(268, 129);
            this.dgvResult.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("굴림", 7F);
            this.btnRemove.Location = new System.Drawing.Point(161, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("굴림", 7F);
            this.btnClear.Location = new System.Drawing.Point(97, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCx
            // 
            this.tbCx.Location = new System.Drawing.Point(33, 149);
            this.tbCx.Name = "tbCx";
            this.tbCx.Size = new System.Drawing.Size(58, 21);
            this.tbCx.TabIndex = 3;
            // 
            // tbCy
            // 
            this.tbCy.Location = new System.Drawing.Point(97, 149);
            this.tbCy.Name = "tbCy";
            this.tbCy.Size = new System.Drawing.Size(58, 21);
            this.tbCy.TabIndex = 4;
            // 
            // tbTrans
            // 
            this.tbTrans.Location = new System.Drawing.Point(161, 149);
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.Size = new System.Drawing.Size(58, 21);
            this.tbTrans.TabIndex = 5;
            // 
            // chtResult
            // 
            legend1.Name = "Legend1";
            this.chtResult.Legends.Add(legend1);
            this.chtResult.Location = new System.Drawing.Point(286, 12);
            this.chtResult.Name = "chtResult";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtResult.Series.Add(series1);
            this.chtResult.Size = new System.Drawing.Size(241, 187);
            this.chtResult.TabIndex = 6;
            this.chtResult.Text = "chart1";
            this.chtResult.Click += new System.EventHandler(this.chtResult_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("굴림", 7F);
            this.btnDraw.Location = new System.Drawing.Point(225, 176);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(55, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 209);
            this.Controls.Add(this.chtResult);
            this.Controls.Add(this.tbTrans);
            this.Controls.Add(this.tbCy);
            this.Controls.Add(this.tbCx);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCx;
        private System.Windows.Forms.TextBox tbCy;
        private System.Windows.Forms.TextBox tbTrans;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtResult;
        private System.Windows.Forms.Button btnDraw;
    }
}

