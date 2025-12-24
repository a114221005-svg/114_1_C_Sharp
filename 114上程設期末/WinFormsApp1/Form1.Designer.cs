namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            computerLabel = new Label();
            playerLabel = new Label();
            scissor = new Button();
            paper = new Button();
            rock = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            playerPictureBox = new PictureBox();
            computerPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 136);
            computerLabel.Location = new Point(133, 35);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(156, 56);
            computerLabel.TabIndex = 0;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 136);
            playerLabel.Location = new Point(511, 35);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(156, 56);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "玩家出";
            // 
            // scissor
            // 
            scissor.Location = new Point(605, 296);
            scissor.Name = "scissor";
            scissor.Size = new Size(112, 34);
            scissor.TabIndex = 3;
            scissor.Text = "剪刀";
            scissor.UseVisualStyleBackColor = true;
            scissor.Click += scissorButton_Click;
            // 
            // paper
            // 
            paper.Location = new Point(340, 296);
            paper.Name = "paper";
            paper.Size = new Size(112, 34);
            paper.TabIndex = 4;
            paper.Text = "布";
            paper.UseVisualStyleBackColor = true;
            paper.Click += paperButton_Click;
            // 
            // rock
            // 
            rock.Location = new Point(116, 296);
            rock.Name = "rock";
            rock.Size = new Size(112, 34);
            rock.TabIndex = 5;
            rock.Text = "石頭";
            rock.UseVisualStyleBackColor = true;
            rock.Click += stoneButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(237, 359);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(325, 54);
            exitButton.TabIndex = 6;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoEllipsis = true;
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.Transparent;
            resultLabel.CausesValidation = false;
            resultLabel.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 136);
            resultLabel.ForeColor = Color.Black;
            resultLabel.Location = new Point(331, 222);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(167, 56);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "             ";
            resultLabel.Click += resultLabel_Click;
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = Properties.Resources.布;
            playerPictureBox.Location = new Point(527, 128);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(129, 90);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 8;
            playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            computerPictureBox.Image = Properties.Resources.石頭__2_;
            computerPictureBox.Location = new Point(143, 126);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(135, 92);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 9;
            computerPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(resultLabel);
            Controls.Add(exitButton);
            Controls.Add(rock);
            Controls.Add(paper);
            Controls.Add(scissor);
            Controls.Add(playerLabel);
            Controls.Add(computerLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label computerLabel;
        private Label playerLabel;
        private Button scissor;
        private Button paper;
        private Button rock;
        private Button exitButton;
        private Label resultLabel;
        private PictureBox playerPictureBox;
        private PictureBox computerPictureBox;
                }
}
