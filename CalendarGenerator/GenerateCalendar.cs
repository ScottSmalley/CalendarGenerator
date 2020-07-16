/*
 * Changes Counseling Monthly Group Calendar
 * Using .NET 4.7 and PDFSharp libraries.
 * Developed by Scott Smalley
 * 
 * INFO
 * scottsmalley90@gmail.com
 */
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarGenerator
{
    class GenerateCalendar
    {
        private static int PDF_WIDTH = 1024;
        private static int PDF_HEIGHT = 768;
        static public void Run(List<string> data)
        {
            PdfDocument document = new PdfDocument();

            document.Info.Title = "Changes Counseling Group Calendar";

            PdfPage page = document.AddPage();
            page.Width = PDF_WIDTH;
            page.Height = PDF_HEIGHT;

            XGraphics gfx = XGraphics.FromPdfPage(page);

            //Calendar Month & Year
            XFont font = new XFont("Verdana", 32, XFontStyle.Bold);
            gfx.DrawString("July 2020", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 35, 0, 0), XStringFormats.Center);

            //Appointments Information
            font = new XFont("Verdana", 10, XFontStyle.Regular);
            gfx.DrawString("Individual Appointments Available until 10:00 PM", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 65, 0, 0), XStringFormats.Center);
            gfx.DrawString("Office Hours Monday - Saturday", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 77, 0, 0), XStringFormats.Center);
            gfx.DrawString("9:00 AM - 7:00 PM", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 89, 0, 0), XStringFormats.Center);

            //Days of the Week
            font = new XFont("Verdana", 12, XFontStyle.Regular);
            gfx.DrawString("MONDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("TUESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("WEDNESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.415, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("THURSDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.581, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("FRIDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.748, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("SATURDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.914, 105, 0, 0), XStringFormats.Center);

            //Company Name
            font = new XFont("Verdana", 40, XFontStyle.Bold);
            gfx.DrawString("CHANGES COUNSELING", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 25, 0, 0), XStringFormats.Center);

            //Address & Website
            font = new XFont("Verdana", 10, XFontStyle.Regular);
            gfx.DrawString("8221 South 700 East, Sandy, UT 84070", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 60, 0, 0), XStringFormats.Center);
            gfx.DrawString("WWW.CHANGESCOUNSELING.ORG", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 75, 0, 0), XStringFormats.Center);

            //Contact Information
            font = new XFont("Verdana", 12, XFontStyle.Regular);
            gfx.DrawString("Office: (801) 542-7060", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 25, 0, 0), XStringFormats.Center);
            gfx.DrawString("Text / UA: (801) 987-0225", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 40, 0, 0), XStringFormats.Center);
            gfx.DrawString("Fax: (801) 542-7061", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 55, 0, 0), XStringFormats.Center);
            gfx.DrawString("info@changescounseling.org", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 70, 0, 0), XStringFormats.Center);

            //Date Numbers
            font = new XFont("Verdana", 12, XFontStyle.Regular);

            //1st Row
            gfx.DrawString("29", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.156, 125, 0, 0), XStringFormats.Center);
            gfx.DrawString("30", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.322, 125, 0, 0), XStringFormats.Center);
            gfx.DrawString("1", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.488, 125, 0, 0), XStringFormats.Center);
            gfx.DrawString("2", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.654, 125, 0, 0), XStringFormats.Center);
            gfx.DrawString("3", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.820, 125, 0, 0), XStringFormats.Center);
            gfx.DrawString("4", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.99, 125, 0, 0), XStringFormats.Center);

            //2nd Row
            gfx.DrawString("6", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.156, 255, 0, 0), XStringFormats.Center);
            gfx.DrawString("7", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.322, 255, 0, 0), XStringFormats.Center);
            gfx.DrawString("8", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.488, 255, 0, 0), XStringFormats.Center);
            gfx.DrawString("9", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.654, 255, 0, 0), XStringFormats.Center);
            gfx.DrawString("10", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.820, 255, 0, 0), XStringFormats.Center);
            gfx.DrawString("11", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.99, 255, 0, 0), XStringFormats.Center);

            //3rd Row
            gfx.DrawString("13", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.156, 385, 0, 0), XStringFormats.Center);
            gfx.DrawString("14", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.322, 385, 0, 0), XStringFormats.Center);
            gfx.DrawString("15", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.488, 385, 0, 0), XStringFormats.Center);
            gfx.DrawString("16", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.654, 385, 0, 0), XStringFormats.Center);
            gfx.DrawString("17", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.820, 385, 0, 0), XStringFormats.Center);
            gfx.DrawString("18", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.99, 385, 0, 0), XStringFormats.Center);

            //4th Row
            gfx.DrawString("20", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.156, 515, 0, 0), XStringFormats.Center);
            gfx.DrawString("21", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.322, 515, 0, 0), XStringFormats.Center);
            gfx.DrawString("22", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.488, 515, 0, 0), XStringFormats.Center);
            gfx.DrawString("23", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.654, 515, 0, 0), XStringFormats.Center);
            gfx.DrawString("24", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.820, 515, 0, 0), XStringFormats.Center);
            gfx.DrawString("25", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.99, 515, 0, 0), XStringFormats.Center);

            //5th Row
            gfx.DrawString("27", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.156, 645, 0, 0), XStringFormats.Center);
            gfx.DrawString("28", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.322, 645, 0, 0), XStringFormats.Center);
            gfx.DrawString("29", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.488, 645, 0, 0), XStringFormats.Center);
            gfx.DrawString("30", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.654, 645, 0, 0), XStringFormats.Center);
            gfx.DrawString("31", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.820, 645, 0, 0), XStringFormats.Center);
            gfx.DrawString("1", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.99, 645, 0, 0), XStringFormats.Center);

            //Cell Content
            font = new XFont("Verdana", 10, XFontStyle.Regular);

            ////1st Row
            //gfx.DrawString("0000000000000000000000000000000", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 135, 0, 0), XStringFormats.Center);
            //gfx.DrawString("10:00 am Thinking Error Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 145, 0, 0), XStringFormats.Center);
            //gfx.DrawString($"10:00 am Thinking Error Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 155, 0, 0), XStringFormats.Center);
            //gfx.DrawString($"10:00 am Thinking Error Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 165, 0, 0), XStringFormats.Center);

            //gfx.DrawString("_____10:00 am-4 Thinking Error", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 145, 0, 0), XStringFormats.Center);
            //gfx.DrawString("___________Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 155, 0, 0), XStringFormats.Center);
            //gfx.DrawString("__11:00 am-3 Prime for Life #1", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 165, 0, 0), XStringFormats.Center);
            //gfx.DrawString("_______4:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 175, 0, 0), XStringFormats.Center);
            //gfx.DrawString("______________________DV Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 185, 0, 0), XStringFormats.Center);
            //gfx.DrawString("_______5:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 195, 0, 0), XStringFormats.Center);
            //gfx.DrawString("_____________________A&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 205, 0, 0), XStringFormats.Center);

            gfx.DrawString("     10:00 am-4 Thinking Error", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 265, 0, 0), XStringFormats.Center);
            gfx.DrawString("           Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 275, 0, 0), XStringFormats.Center);
            gfx.DrawString("  11:00 am-3 Prime for Life #1", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 285, 0, 0), XStringFormats.Center);
            gfx.DrawString("       4:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 295, 0, 0), XStringFormats.Center);
            gfx.DrawString("                      DV Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 305, 0, 0), XStringFormats.Center);
            gfx.DrawString("       5:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 315, 0, 0), XStringFormats.Center);
            gfx.DrawString("                     A&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 325, 0, 0), XStringFormats.Center);

            gfx.DrawString("10:00 am-4 Thinking Error     ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 395, 0, 0), XStringFormats.Center);
            gfx.DrawString("Basics 6hr Workshop           ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 405, 0, 0), XStringFormats.Center);
            gfx.DrawString("11:00 am-3 Prime for Life #1  ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 415, 0, 0), XStringFormats.Center);
            gfx.DrawString("4:00 pm Men's & Women's       ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 425, 0, 0), XStringFormats.Center);
            gfx.DrawString("DV Group                      ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 435, 0, 0), XStringFormats.Center);
            gfx.DrawString("5:00 pm Men's & Women's       ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 445, 0, 0), XStringFormats.Center);
            gfx.DrawString("A&D Group                     ", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 455, 0, 0), XStringFormats.Center);


            gfx.DrawString("10:00 am-4 Thinking Error", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 525, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("Basics 6hr Workshop", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 535, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("11:00 am-3 Prime for Life #1", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 545, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("4:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 555, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("DV Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 565, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("5:00 pm Men's & Women's", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 575, 0, 0), XStringFormats.BaseLineLeft);
            gfx.DrawString("\t\t\t\tA&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 585, 0, 0), XStringFormats.BaseLineLeft);


            XTextFormatter tf = new XTextFormatter(gfx);
            tf.Alignment = XParagraphAlignment.Left;

            //tf.DrawString("5:00 pm Men's & Women's \n A&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 655, 170, 130), XStringFormats.TopLeft);

            tf.DrawString("10:00 am-4 Thinking Error Basics 6hr Workshop\n11:00 am-3 Prime for Life #1\n4:00 pm Men's & Women's\nDV Group\n5:00 pm Men's & Women's\nA&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 145, 170, 130), XStringFormats.TopLeft);
            tf.DrawString("11111111111111111111111111111111\n11:00 am-3 Prime for Life #1\n4:00 pm Men's & Women's\nDV Group\n5:00 pm Men's & Women's\nA&D Group", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.75, 300, 170, 130), XStringFormats.TopLeft);

            //XRect dataCell = new XRect(0, 525, 170, 130);
            //gfx.DrawString("10:00 am-4 Thinking Error", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 395, 0, 0), XStringFormats.Center);

            /*
            gfx.DrawString("MONDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("TUESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("WEDNESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.415, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("THURSDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.581, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("FRIDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.748, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("SATURDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.914, 105, 0, 0), XStringFormats.Center);
             */


            //Calendar Grid Lines
            XPen pen = new XPen(XColor.FromKnownColor(XKnownColor.Black));

            //Header is 118px in Y so we have evenly spaced cells (170x130)
            //VERTICAL LINES
            gfx.DrawLine(pen, 0, 118, 0, PDF_HEIGHT);
            gfx.DrawLine(pen, 170, 118, 170, PDF_HEIGHT);
            gfx.DrawLine(pen, 340, 118, 340, PDF_HEIGHT);
            gfx.DrawLine(pen, 510, 118, 510, PDF_HEIGHT);
            gfx.DrawLine(pen, 680, 118, 680, PDF_HEIGHT);
            gfx.DrawLine(pen, 850, 118, 850, PDF_HEIGHT);
            gfx.DrawLine(pen, 1024, 118, 1024, PDF_HEIGHT);

            //HORIZONTAL LINES
            gfx.DrawLine(pen, 0, 118, PDF_WIDTH, 118);
            gfx.DrawLine(pen, 0, 248, PDF_WIDTH, 248);
            gfx.DrawLine(pen, 0, 378, PDF_WIDTH, 378);
            gfx.DrawLine(pen, 0, 508, PDF_WIDTH, 508);
            gfx.DrawLine(pen, 0, 638, PDF_WIDTH, 638);
            gfx.DrawLine(pen, 0, 768, PDF_WIDTH, 768);

            const string filename = "StandInName.pdf";
            document.Save(filename);

            Process.Start(filename);

            //NOTE: at 10pt font, Could fit 31 characters per line in original calendar.
        }
    }
}
