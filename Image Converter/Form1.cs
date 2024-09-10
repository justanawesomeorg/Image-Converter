using ImageMagick;

namespace Image_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Ficheiro de imagem(*.BMP;*.JPG;*.WEBP;*.AVIF;*.PNG;*.TIF)|*.BMP;*.JPG;*.WEBP;*.AVIF;*.PNG;*.TIF|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File_TB.Text = ofd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JPEG_RB.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(File_TB.Text))
            {
                MessageBox.Show("Não selecionou nenhum ficheiro.\nPor favor selecione um!");
                return;
            }

            MagickFormat finalFormat;
            if (JPEG_RB.Checked)
            {
                finalFormat = MagickFormat.Jpeg;
            }
            else if (PNG_RB.Checked)
            {
                finalFormat = MagickFormat.Png;
            }
            else if (AVIF_RB.Checked)
            {
                finalFormat = MagickFormat.Avif;
            }
            else if (WEBP_RB.Checked)
            {
                finalFormat = MagickFormat.WebP;
            }
            else if (BMP_RB.Checked)
            {
                finalFormat = MagickFormat.Bmp;
            }
            else if (TIFF_RB.Checked)
            {
                finalFormat = MagickFormat.Tif;
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum formato.\nPor Favor selecione um primeiro!");
                return;
            }

            Parallel.Invoke(() =>
            {
                using MagickImage img = new(File_TB.Text);
                img.Progress += Img_Progress;
                img.Write(File_TB.Text.Replace("." + File_TB.Text.Split('.').Last(), "." + finalFormat.ToString()), finalFormat);
                img.Progress -= Img_Progress;
            });
        }

        private void Img_Progress(object? sender, ProgressEventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = e.Progress.ToInt32();
        }
    }
}
