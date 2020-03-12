using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace PoldyCv
{
    public partial class pdfdeneme : Form
    {

        public pdfdeneme()
        {
            InitializeComponent();
        }
        public string TurkceKarakter(string text)
        {

            text = text.Replace("İ", "\u0130");

            text = text.Replace("ı", "\u0131");

            text = text.Replace("Ş", "\u015e");

            text = text.Replace("ş", "\u015f");

            text = text.Replace("Ğ", "\u011e");

            text = text.Replace("ğ", "\u011f");

            text = text.Replace("Ö", "\u00d6");

            text = text.Replace("ö", "\u00f6");

            text = text.Replace("ç", "\u00e7");

            text = text.Replace("Ç", "\u00c7");

            text = text.Replace("ü", "\u00fc");

            text = text.Replace("Ü", "\u00dc");

            return text;
        }
        
    private void pdfdeneme_Load(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();

            PdfWriter.GetInstance(document, new FileStream(@"C:\deneme.pdf", FileMode.Create));

            BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            iTextSharp.text.Font font = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);



            if (document.IsOpen() == false)
            {

                document.Open();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\info.png");
                img.ScalePercent(40f);
                document.Add(img);
                string text ="Kisi Ad : Adem \n" +
                    "Kisi Soyad : Kesim \n" +
                    "Kisi Ünvan : Yazılımcı";
           
                

                text = TurkceKarakter(text);
                document.Add(new Paragraph(text, font));

                document.Add(img);

                document.Close();

            }
        }
    }
}
