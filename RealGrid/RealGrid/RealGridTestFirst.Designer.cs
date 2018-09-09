namespace RealGrid {
    partial class EnumsAndComboBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonSelectTest = new System.Windows.Forms.Button();
            this.buttonSelectTest2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(978, 599);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 38);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1085, 573);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTest.Location = new System.Drawing.Point(853, 599);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(119, 38);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "&Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonSelectTest
            // 
            this.buttonSelectTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectTest.Location = new System.Drawing.Point(728, 599);
            this.buttonSelectTest.Name = "buttonSelectTest";
            this.buttonSelectTest.Size = new System.Drawing.Size(119, 38);
            this.buttonSelectTest.TabIndex = 3;
            this.buttonSelectTest.Text = "&Select Test";
            this.buttonSelectTest.UseVisualStyleBackColor = true;
            this.buttonSelectTest.Click += new System.EventHandler(this.buttonSelectTest_Click);
            // 
            // buttonSelectTest2
            // 
            this.buttonSelectTest2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectTest2.Location = new System.Drawing.Point(603, 599);
            this.buttonSelectTest2.Name = "buttonSelectTest2";
            this.buttonSelectTest2.Size = new System.Drawing.Size(119, 38);
            this.buttonSelectTest2.TabIndex = 4;
            this.buttonSelectTest2.Text = "&Select Test";
            this.buttonSelectTest2.UseVisualStyleBackColor = true;
            this.buttonSelectTest2.Click += new System.EventHandler(this.buttonSelectTest2_Click);
            // 
            // EnumsAndComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 649);
            this.Controls.Add(this.buttonSelectTest2);
            this.Controls.Add(this.buttonSelectTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonClose);
            this.Name = "EnumsAndComboBox";
            this.Text = "Real Grid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonSelectTest;
        private System.Windows.Forms.Button buttonSelectTest2;
    }
}

