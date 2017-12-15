namespace BillSystem.Forms
{
    partial class UnitOfMeasurement
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
            this.UOM_DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.UOM_DeleteBtn = new System.Windows.Forms.Button();
            this.UOM_OkBtn = new System.Windows.Forms.Button();
            this.UOM_CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UOM_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UOM_DataGrid
            // 
            this.UOM_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UOM_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UOM_DataGrid.Location = new System.Drawing.Point(12, 41);
            this.UOM_DataGrid.Name = "UOM_DataGrid";
            this.UOM_DataGrid.Size = new System.Drawing.Size(235, 252);
            this.UOM_DataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit of Measurements :";
            // 
            // UOM_DeleteBtn
            // 
            this.UOM_DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UOM_DeleteBtn.Location = new System.Drawing.Point(253, 53);
            this.UOM_DeleteBtn.Name = "UOM_DeleteBtn";
            this.UOM_DeleteBtn.Size = new System.Drawing.Size(119, 23);
            this.UOM_DeleteBtn.TabIndex = 2;
            this.UOM_DeleteBtn.Text = "Delete Items";
            this.UOM_DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UOM_OkBtn
            // 
            this.UOM_OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UOM_OkBtn.Location = new System.Drawing.Point(176, 309);
            this.UOM_OkBtn.Name = "UOM_OkBtn";
            this.UOM_OkBtn.Size = new System.Drawing.Size(95, 23);
            this.UOM_OkBtn.TabIndex = 3;
            this.UOM_OkBtn.Text = "OK";
            this.UOM_OkBtn.UseVisualStyleBackColor = true;
            // 
            // UOM_CancelBtn
            // 
            this.UOM_CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UOM_CancelBtn.Location = new System.Drawing.Point(277, 309);
            this.UOM_CancelBtn.Name = "UOM_CancelBtn";
            this.UOM_CancelBtn.Size = new System.Drawing.Size(95, 23);
            this.UOM_CancelBtn.TabIndex = 4;
            this.UOM_CancelBtn.Text = "Cancel";
            this.UOM_CancelBtn.UseVisualStyleBackColor = true;
            // 
            // UnitOfMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 344);
            this.Controls.Add(this.UOM_CancelBtn);
            this.Controls.Add(this.UOM_OkBtn);
            this.Controls.Add(this.UOM_DeleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UOM_DataGrid);
            this.Name = "UnitOfMeasurement";
            this.Text = "UnitOfMeasurement";
            ((System.ComponentModel.ISupportInitialize)(this.UOM_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UOM_DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UOM_DeleteBtn;
        private System.Windows.Forms.Button UOM_OkBtn;
        private System.Windows.Forms.Button UOM_CancelBtn;
    }
}