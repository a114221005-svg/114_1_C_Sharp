namespace _24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            carfFacePictureBox = new Button();
            carfBakePictureBox = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.Backface_Red;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(325, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(325, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 242);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // carfFacePictureBox
            // 
            carfFacePictureBox.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            carfFacePictureBox.Location = new Point(491, 357);
            carfFacePictureBox.Name = "carfFacePictureBox";
            carfFacePictureBox.Size = new Size(168, 56);
            carfFacePictureBox.TabIndex = 2;
            carfFacePictureBox.Text = "顯示正面";
            carfFacePictureBox.UseVisualStyleBackColor = true;
            carfFacePictureBox.Click += carfFacePictureBox_Click;
            // 
            // carfBakePictureBox
            // 
            carfBakePictureBox.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            carfBakePictureBox.Location = new Point(131, 357);
            carfBakePictureBox.Name = "carfBakePictureBox";
            carfBakePictureBox.Size = new Size(168, 56);
            carfBakePictureBox.TabIndex = 3;
            carfBakePictureBox.Text = "顯示背面";
            carfBakePictureBox.UseVisualStyleBackColor = true;
            carfBakePictureBox.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(carfBakePictureBox);
            Controls.Add(carfFacePictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button carfFacePictureBox;
        private Button carfBakePictureBox;
    }
}
