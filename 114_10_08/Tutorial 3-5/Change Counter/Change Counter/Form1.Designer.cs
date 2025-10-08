namespace Change_Counter
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計產生的程式碼

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿以程式碼編輯器修改此方法內容。
        /// </summary>
        private void InitializeComponent()
        {
            // 建立說明標籤，顯示操作提示
            this.instructionLabel = new System.Windows.Forms.Label();
            // 建立五分硬幣圖片元件
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            // 建立十分硬幣圖片元件
            this.tenCentsPictureBox = new System.Windows.Forms.PictureBox();
            // 建立二十五分硬幣圖片元件
            this.twentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            // 建立五十分硬幣圖片元件
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            // 建立離開按鈕
            this.exitButton = new System.Windows.Forms.Button();
            // 建立顯示總金額的標籤
            this.totalLabel = new System.Windows.Forms.Label();
            // 建立總計說明標籤
            this.outputDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            // 設定說明標籤屬性，顯示「請點選硬幣」
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(150, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(110, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "請點選硬幣";
            // 
            // fiveCentsPictureBox
            // 
            // 設定五分硬幣圖片元件屬性與事件
            this.fiveCentsPictureBox.Image = global::Change_Counter.Properties.Resources._5cents;
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(12, 37);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiveCentsPictureBox.TabIndex = 1;
            this.fiveCentsPictureBox.TabStop = false;
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);
            // 
            // tenCentsPictureBox
            // 
            // 設定十分硬幣圖片元件屬性與事件
            this.tenCentsPictureBox.Image = global::Change_Counter.Properties.Resources._10cents;
            this.tenCentsPictureBox.Location = new System.Drawing.Point(144, 37);
            this.tenCentsPictureBox.Name = "tenCentsPictureBox";
            this.tenCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.tenCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tenCentsPictureBox.TabIndex = 2;
            this.tenCentsPictureBox.TabStop = false;
            this.tenCentsPictureBox.Click += new System.EventHandler(this.tenCentsPictureBox_Click);
            // 
            // twentyFiveCentsPictureBox
            // 
            // 設定二十五分硬幣圖片元件屬性與事件
            this.twentyFiveCentsPictureBox.Image = global::Change_Counter.Properties.Resources._25cents;
            this.twentyFiveCentsPictureBox.Location = new System.Drawing.Point(12, 224);
            this.twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            this.twentyFiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.twentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twentyFiveCentsPictureBox.TabIndex = 3;
            this.twentyFiveCentsPictureBox.TabStop = false;
            this.twentyFiveCentsPictureBox.Click += new System.EventHandler(this.twentyFiveCentsPictureBox_Click);
            // 
            // fiftyCentsPictureBox
            // 
            // 設定五十分硬幣圖片元件屬性與事件
            this.fiftyCentsPictureBox.Image = global::Change_Counter.Properties.Resources._50cents;
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(144, 224);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiftyCentsPictureBox.TabIndex = 4;
            this.fiftyCentsPictureBox.TabStop = false;
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);
            // 
            // exitButton
            // 
            // 設定離開按鈕屬性與事件
            this.exitButton.Location = new System.Drawing.Point(180, 430);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalLabel
            // 
            // 設定顯示總金額的標籤屬性
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(291, 206);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescription
            // 
            // 設定總計說明標籤屬性
            this.outputDescription.AutoSize = true;
            this.outputDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescription.Location = new System.Drawing.Point(319, 179);
            this.outputDescription.Name = "outputDescription";
            this.outputDescription.Size = new System.Drawing.Size(44, 16);
            this.outputDescription.TabIndex = 7;
            this.outputDescription.Text = "總計";
            // 
            // Form1
            // 
            // 設定主視窗屬性
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 465);
            this.Controls.Add(this.outputDescription);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.twentyFiveCentsPictureBox);
            this.Controls.Add(this.tenCentsPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "零錢計數器";
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 視窗元件宣告區
        private System.Windows.Forms.Label instructionLabel;         // 操作說明標籤
        private System.Windows.Forms.PictureBox fiveCentsPictureBox; // 五分硬幣圖片
        private System.Windows.Forms.PictureBox tenCentsPictureBox;  // 十分硬幣圖片
        private System.Windows.Forms.PictureBox twentyFiveCentsPictureBox; // 二十五分硬幣圖片
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox; // 五十分硬幣圖片
        private System.Windows.Forms.Button exitButton;              // 離開按鈕
        private System.Windows.Forms.Label totalLabel;               // 顯示總金額標籤
        private System.Windows.Forms.Label outputDescription;        // 總計說明標籤
    }
}

