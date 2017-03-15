namespace PartCopy
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udEnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.AllowDrop = true;
            this.txtSource.Location = new System.Drawing.Point(53, 6);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(732, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSource_DragDrop);
            this.txtSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            this.txtSource.DragOver += new System.Windows.Forms.DragEventHandler(this.txt_DragOver);
            // 
            // txtDest
            // 
            this.txtDest.AllowDrop = true;
            this.txtDest.Location = new System.Drawing.Point(53, 39);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(732, 20);
            this.txtDest.TabIndex = 0;
            this.txtDest.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDest_DragDrop);
            this.txtDest.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_DragEnter);
            this.txtDest.DragOver += new System.Windows.Forms.DragEventHandler(this.txt_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Dest:";
            // 
            // udStart
            // 
            this.udStart.Location = new System.Drawing.Point(53, 102);
            this.udStart.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udStart.Name = "udStart";
            this.udStart.Size = new System.Drawing.Size(274, 20);
            this.udStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "S&tart:";
            // 
            // udEnd
            // 
            this.udEnd.Location = new System.Drawing.Point(53, 128);
            this.udEnd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.udEnd.Name = "udEnd";
            this.udEnd.Size = new System.Drawing.Size(274, 20);
            this.udEnd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "&End:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(53, 186);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(274, 25);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(680, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnClose;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 223);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.udEnd);
            this.Controls.Add(this.udStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "PartCopy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClose;
    }
}

