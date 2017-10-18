namespace WindowsFormsApplication1
{
    partial class TümKitaplar
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
            this.DataKitapView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataKitapView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataKitapView
            // 
            this.DataKitapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKitapView.Location = new System.Drawing.Point(0, 55);
            this.DataKitapView.Name = "DataKitapView";
            this.DataKitapView.Size = new System.Drawing.Size(576, 215);
            this.DataKitapView.TabIndex = 3;
            // 
            // TümKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 310);
            this.Controls.Add(this.DataKitapView);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TümKitaplar";
            this.Text = "TümKitaplar";
            this.Load += new System.EventHandler(this.TümKitaplar_Load);
            this.Controls.SetChildIndex(this.DataKitapView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataKitapView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataKitapView;
    }
}