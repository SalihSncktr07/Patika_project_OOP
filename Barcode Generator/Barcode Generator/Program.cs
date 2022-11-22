using System;
using System.Drawing;
using ZXing;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne yapmak istiyorsunuz?");
            Console.WriteLine("1 - Barkod okutmak");
            Console.WriteLine("2 - Barkod oluşturmak");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BarcodeReader();
            }
            else if (choice == 2)
            {
                BarcodeWriter();
            }
            else
            {
                Console.WriteLine("Lütfen 1 veya 2 arasında bir seçim yapınız!");
            }
        }

        static string SelectFile()
        {
            Console.Write("Dosya yolunu giriniz:");
            string filePath = Console.ReadLine();
            return filePath;
        }

        static void BarcodeReader()
        {
            var filePath = SelectFile();
            BarcodeReader barcodeReader = new BarcodeReader();
            var barcodeBitmap = (Bitmap)Image.FromFile(filePath);
            var result = barcodeReader.Decode(barcodeBitmap);

            if (result != null)
            {

                Console.WriteLine($"Barkod üzerinde bulunan kod = {result.Text}");
            }
        }

        static string SetBarcodeLocation()
        {
            string extension = ".png";

            Console.WriteLine("Dosya ismi giriniz:");
            string fileName = Console.ReadLine();

            string filePath = SelectFile();
            string fullPath = filePath + "/" + fileName + extension;
            return fullPath;
        }

        static void BarcodeWriter()
        {
            Console.WriteLine("Barkod içeriği giriniz:");
            string content = Console.ReadLine();

            string fullPath = SetBarcodeLocation();

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Write(content).Save(fullPath);
        }
    }
}