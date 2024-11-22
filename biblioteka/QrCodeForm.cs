using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class QrCodeForm : Form
    {
        public QrCodeForm(string bookJson)
        {
            InitializeComponent();
            GenerateQRCode(bookJson);
        }
        private void GenerateQRCode(string text)
        {
            try
            {
                // Создаем генератор QR-кода
                var writer = new ZXing.BarcodeWriter
                {
                    Format = ZXing.BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Height = 300,
                        Width = 300,
                        Margin = 1,
                        CharacterSet = "UTF-8" // Устанавливаем кодировку UTF-8
                    }
                };

                // Генерируем QR-код
                var qrCode = writer.Write(text);

                // Отображаем QR-код на PictureBox
                var pictureBox = new PictureBox
                {
                    Image = qrCode,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.CenterImage
                };

                Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка генерации QR-кода: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}