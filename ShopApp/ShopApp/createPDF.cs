using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ShopApp
{
    class createPDF
    {
        static Document doc;

        public createPDF()
        {
            doc = new Document();
        }

        //create pdf file
        public void filePdfStandart()
        {
            
            PdfWriter.GetInstance(doc, new FileStream("NewPdf.pdf", FileMode.Create));
        }

        public void filePdfWithName(string name)
        {
            //create pdf file
            PdfWriter.GetInstance(doc, new FileStream(name, FileMode.Create));
        }
        //set title on pdf file
        public void setTitle(string title)
        {
            doc.Open();
            Font myFont = new Font(Font.FontFamily.COURIER, 16, Font.ITALIC);
            doc.Add(new Paragraph(title, myFont));

            doc.Add((new Paragraph("\n\n", myFont)));

        }

        //close pdf file
        public void CloseReport()
        {
            doc.Close();
        }

        //Create file with all information about all clients
        public void clientsToPdf(Client[] clients)
        {
            doc.Open();
            Font myFont = new Font(Font.FontFamily.COURIER, 8, Font.NORMAL);

            for (int i = 0; i < clients.Length; i++)
            {               
                doc.Add(new Paragraph("Name: " + clients[i].GetSetName, myFont));
                doc.Add(new Paragraph("ID: " + clients[i].GetSetId.ToString(), myFont));
                doc.Add(new Paragraph("Adress: " + clients[i].GetSetAddress, myFont));
                doc.Add(new Paragraph("Telephone: " + clients[i].GetSetTel, myFont));
                doc.Add((new Paragraph("\n", myFont)));
            }
        }
    }
}
