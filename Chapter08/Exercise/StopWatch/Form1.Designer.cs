
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.Startbt = new System.Windows.Forms.Button();
            this.Stopbt = new System.Windows.Forms.Button();
            this.Resetbt = new System.Windows.Forms.Button();
            this.Lapbt = new System.Windows.Forms.Button();
            this.tmdisp = new System.Windows.Forms.Timer(this.components);
            this.ldTimerDisp = new System.Windows.Forms.Label();
            this.ldLapDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Startbt
            // 
            this.Startbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Startbt.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbt.ForeColor = System.Drawing.Color.Blue;
            this.Startbt.Location = new System.Drawing.Point(12, 94);
            this.Startbt.Name = "Startbt";
            this.Startbt.Size = new System.Drawing.Size(133, 43);
            this.Startbt.TabIndex = 0;
            this.Startbt.Text = "START";
            this.Startbt.UseVisualStyleBackColor = false;
            this.Startbt.Click += new System.EventHandler(this.Startbt_Click);
            // 
            // Stopbt
            // 
            this.Stopbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Stopbt.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopbt.ForeColor = System.Drawing.Color.Green;
            this.Stopbt.Location = new System.Drawing.Point(12, 143);
            this.Stopbt.Name = "Stopbt";
            this.Stopbt.Size = new System.Drawing.Size(133, 43);
            this.Stopbt.TabIndex = 0;
            this.Stopbt.Text = "STOP";
            this.Stopbt.UseVisualStyleBackColor = false;
            this.Stopbt.Click += new System.EventHandler(this.Stopbt_Click);
            // 
            // Resetbt
            // 
            this.Resetbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Resetbt.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbt.ForeColor = System.Drawing.Color.ForestGreen;
            this.Resetbt.Location = new System.Drawing.Point(151, 94);
            this.Resetbt.Name = "Resetbt";
            this.Resetbt.Size = new System.Drawing.Size(133, 43);
            this.Resetbt.TabIndex = 0;
            this.Resetbt.Text = "RESET";
            this.Resetbt.UseVisualStyleBackColor = false;
            this.Resetbt.Click += new System.EventHandler(this.Resetbt_Click);
            // 
            // Lapbt
            // 
            this.Lapbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Lapbt.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lapbt.ForeColor = System.Drawing.Color.Blue;
            this.Lapbt.Location = new System.Drawing.Point(151, 143);
            this.Lapbt.Name = "Lapbt";
            this.Lapbt.Size = new System.Drawing.Size(133, 43);
            this.Lapbt.TabIndex = 0;
            this.Lapbt.Text = "LAP→";
            this.Lapbt.UseVisualStyleBackColor = false;
            this.Lapbt.Click += new System.EventHandler(this.Lapbt_Click);
            // 
            // tmdisp
            // 
            this.tmdisp.Tick += new System.EventHandler(this.tmdisp_Tick);
            // 
            // ldTimerDisp
            // 
            this.ldTimerDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ldTimerDisp.Font = new System.Drawing.Font("Jokerman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldTimerDisp.ForeColor = System.Drawing.Color.Magenta;
            this.ldTimerDisp.Location = new System.Drawing.Point(12, 9);
            this.ldTimerDisp.Name = "ldTimerDisp";
            this.ldTimerDisp.Size = new System.Drawing.Size(272, 65);
            this.ldTimerDisp.TabIndex = 1;
            // 
            // ldLapDisp
            // 
            this.ldLapDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ldLapDisp.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldLapDisp.ForeColor = System.Drawing.Color.Gold;
            this.ldLapDisp.FormattingEnabled = true;
            this.ldLapDisp.ItemHeight = 20;
            this.ldLapDisp.Location = new System.Drawing.Point(290, 9);
            this.ldLapDisp.Name = "ldLapDisp";
            this.ldLapDisp.Size = new System.Drawing.Size(144, 184);
            this.ldLapDisp.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(445, 207);
            this.Controls.Add(this.ldLapDisp);
            this.Controls.Add(this.ldTimerDisp);
            this.Controls.Add(this.Lapbt);
            this.Controls.Add(this.Resetbt);
            this.Controls.Add(this.Stopbt);
            this.Controls.Add(this.Startbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Startbt;
        private System.Windows.Forms.Button Stopbt;
        private System.Windows.Forms.Button Resetbt;
        private System.Windows.Forms.Button Lapbt;
        private System.Windows.Forms.Timer tmdisp;
        private System.Windows.Forms.Label ldTimerDisp;
        private System.Windows.Forms.ListBox ldLapDisp;
    }
}

