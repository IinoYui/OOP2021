
namespace Exercise1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbKW = new System.Windows.Forms.TextBox();
            this.KW = new System.Windows.Forms.Label();
            this.btREadAllLines = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(53, 120);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(672, 409);
            this.tbOutput.TabIndex = 12;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(53, 53);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(77, 42);
            this.btOpen.TabIndex = 22;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbKW
            // 
            this.tbKW.Location = new System.Drawing.Point(161, 72);
            this.tbKW.Multiline = true;
            this.tbKW.Name = "tbKW";
            this.tbKW.Size = new System.Drawing.Size(120, 23);
            this.tbKW.TabIndex = 23;
            this.tbKW.TextChanged += new System.EventHandler(this.tbKW_TextChanged);
            // 
            // KW
            // 
            this.KW.AutoSize = true;
            this.KW.Location = new System.Drawing.Point(159, 53);
            this.KW.Name = "KW";
            this.KW.Size = new System.Drawing.Size(53, 12);
            this.KW.TabIndex = 24;
            this.KW.Text = "キーワード";
            // 
            // btREadAllLines
            // 
            this.btREadAllLines.Location = new System.Drawing.Point(364, 53);
            this.btREadAllLines.Name = "btREadAllLines";
            this.btREadAllLines.Size = new System.Drawing.Size(122, 42);
            this.btREadAllLines.TabIndex = 25;
            this.btREadAllLines.Text = "ReadAllLines";
            this.btREadAllLines.UseVisualStyleBackColor = true;
            this.btREadAllLines.Click += new System.EventHandler(this.btREadAllLines_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(518, 53);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(122, 42);
            this.btReadLines.TabIndex = 26;
            this.btReadLines.Text = "ReadLines";
            this.btReadLines.UseVisualStyleBackColor = true;
            this.btReadLines.Click += new System.EventHandler(this.btReadLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btREadAllLines);
            this.Controls.Add(this.KW);
            this.Controls.Add(this.tbKW);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbKW;
        private System.Windows.Forms.Label KW;
        private System.Windows.Forms.Button btREadAllLines;
        private System.Windows.Forms.Button btReadLines;
    }
}

