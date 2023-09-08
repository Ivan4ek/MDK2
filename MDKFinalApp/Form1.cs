using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDKFinalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Полный путь к изображению с расширением файла (например, .jpg, .png)
            string imagePath = @"C:\GitProjectMDK\MDKFinalApp\MDKFinalApp\bin\Debug\img1.jpg";

            try
            {
                // Освобождаем ресурсы, связанные с предыдущим изображением (если оно было загружено)
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                // Устанавливаем режим отображения изображения в PictureBox на Zoom
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                // Отобразить изображение в PictureBox
                pictureBox1.Image = new Bitmap(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
    }
}
