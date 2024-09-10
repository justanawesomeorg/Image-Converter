namespace Image_Converter
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
            label1 = new Label();
            label2 = new Label();
            File_TB = new TextBox();
            button1 = new Button();
            label3 = new Label();
            JPEG_RB = new RadioButton();
            PNG_RB = new RadioButton();
            WEBP_RB = new RadioButton();
            AVIF_RB = new RadioButton();
            BMP_RB = new RadioButton();
            TIFF_RB = new RadioButton();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 26);
            label1.TabIndex = 0;
            label1.Text = "Image Converter";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Imagem a converter";
            // 
            // File_TB
            // 
            File_TB.Location = new Point(12, 73);
            File_TB.Name = "File_TB";
            File_TB.ReadOnly = true;
            File_TB.Size = new Size(418, 23);
            File_TB.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 102);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 3;
            button1.Text = "📂 Abrir imagem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(418, 26);
            label3.TabIndex = 4;
            label3.Text = "Formato Final";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // JPEG_RB
            // 
            JPEG_RB.AutoSize = true;
            JPEG_RB.Location = new Point(105, 181);
            JPEG_RB.Name = "JPEG_RB";
            JPEG_RB.Size = new Size(50, 19);
            JPEG_RB.TabIndex = 5;
            JPEG_RB.TabStop = true;
            JPEG_RB.Text = "JPEG";
            JPEG_RB.UseVisualStyleBackColor = true;
            // 
            // PNG_RB
            // 
            PNG_RB.AutoSize = true;
            PNG_RB.Location = new Point(105, 206);
            PNG_RB.Name = "PNG_RB";
            PNG_RB.Size = new Size(49, 19);
            PNG_RB.TabIndex = 6;
            PNG_RB.TabStop = true;
            PNG_RB.Text = "PNG";
            PNG_RB.UseVisualStyleBackColor = true;
            // 
            // WEBP_RB
            // 
            WEBP_RB.AutoSize = true;
            WEBP_RB.Location = new Point(194, 206);
            WEBP_RB.Name = "WEBP_RB";
            WEBP_RB.Size = new Size(56, 19);
            WEBP_RB.TabIndex = 7;
            WEBP_RB.TabStop = true;
            WEBP_RB.Text = "WEBP";
            WEBP_RB.UseVisualStyleBackColor = true;
            // 
            // AVIF_RB
            // 
            AVIF_RB.AutoSize = true;
            AVIF_RB.Location = new Point(194, 181);
            AVIF_RB.Name = "AVIF_RB";
            AVIF_RB.Size = new Size(48, 19);
            AVIF_RB.TabIndex = 8;
            AVIF_RB.TabStop = true;
            AVIF_RB.Text = "AVIF";
            AVIF_RB.UseVisualStyleBackColor = true;
            // 
            // BMP_RB
            // 
            BMP_RB.AutoSize = true;
            BMP_RB.Location = new Point(287, 181);
            BMP_RB.Name = "BMP_RB";
            BMP_RB.Size = new Size(50, 19);
            BMP_RB.TabIndex = 9;
            BMP_RB.TabStop = true;
            BMP_RB.Text = "BMP";
            BMP_RB.UseVisualStyleBackColor = true;
            // 
            // TIFF_RB
            // 
            TIFF_RB.AutoSize = true;
            TIFF_RB.Location = new Point(287, 206);
            TIFF_RB.Name = "TIFF_RB";
            TIFF_RB.Size = new Size(46, 19);
            TIFF_RB.TabIndex = 10;
            TIFF_RB.TabStop = true;
            TIFF_RB.Text = "TIFF";
            TIFF_RB.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 239);
            button2.Name = "button2";
            button2.Size = new Size(418, 41);
            button2.TabIndex = 11;
            button2.Text = "Converter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 286);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(418, 23);
            progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 321);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(TIFF_RB);
            Controls.Add(BMP_RB);
            Controls.Add(AVIF_RB);
            Controls.Add(WEBP_RB);
            Controls.Add(PNG_RB);
            Controls.Add(JPEG_RB);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(File_TB);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Image Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox File_TB;
        private Button button1;
        private Label label3;
        private RadioButton JPEG_RB;
        private RadioButton PNG_RB;
        private RadioButton WEBP_RB;
        private RadioButton AVIF_RB;
        private RadioButton BMP_RB;
        private RadioButton TIFF_RB;
        private Button button2;
        private ProgressBar progressBar1;
    }
}
