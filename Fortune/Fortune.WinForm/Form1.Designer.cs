namespace Fortune.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiScore = new System.Windows.Forms.TextBox();
            this.uiCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiName
            // 
            this.uiName.Location = new System.Drawing.Point(14, 24);
            this.uiName.Name = "uiName";
            this.uiName.Size = new System.Drawing.Size(258, 21);
            this.uiName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入你的名字：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "得分：";
            // 
            // uiScore
            // 
            this.uiScore.Location = new System.Drawing.Point(14, 67);
            this.uiScore.Name = "uiScore";
            this.uiScore.ReadOnly = true;
            this.uiScore.Size = new System.Drawing.Size(258, 21);
            this.uiScore.TabIndex = 4;
            // 
            // uiCalc
            // 
            this.uiCalc.Location = new System.Drawing.Point(197, 94);
            this.uiCalc.Name = "uiCalc";
            this.uiCalc.Size = new System.Drawing.Size(75, 23);
            this.uiCalc.TabIndex = 5;
            this.uiCalc.Text = "计算(&C)";
            this.uiCalc.UseVisualStyleBackColor = true;
            this.uiCalc.Click += new System.EventHandler(this.uiCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.uiCalc);
            this.Controls.Add(this.uiScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "取名算命大师";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiScore;
        private System.Windows.Forms.Button uiCalc;
    }
}

