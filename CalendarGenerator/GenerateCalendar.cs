/*
 * Group Therapy Calendar PDF Generator
 * Stakeholder: Changes Counseling
 * Developer: Scott Smalley
 * scottsmalley90@gmail.com
 * scottsmalley.net
 */
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System.Collections.Generic;
using System.Diagnostics;

namespace CalendarGenerator
{
    class GenerateCalendar
    {
        private static int PDF_WIDTH = 1024;
        private static int PDF_HEIGHT = 768;
        private static string FONT_TYPE = "Verdana";
        static public void Run(string monthYear, List<string> dates, List<string> cellData)
        {
            PdfDocument document = new PdfDocument();

            document.Info.Title = "Changes Counseling Group Calendar";

            PdfPage page = document.AddPage();
            page.Width = PDF_WIDTH;
            page.Height = PDF_HEIGHT;

            XGraphics gfx = XGraphics.FromPdfPage(page);

            //Calendar Month & Year
            XFont font = new XFont(FONT_TYPE, 32, XFontStyle.Bold);
            gfx.DrawString(monthYear, font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 35, 0, 0), XStringFormats.Center);

            //Appointments Information
            font = new XFont(FONT_TYPE, 10, XFontStyle.Regular);
            gfx.DrawString("Individual Appointments Available until 10:00 PM", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 65, 0, 0), XStringFormats.Center);
            gfx.DrawString("Office Hours Monday - Saturday", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 77, 0, 0), XStringFormats.Center);
            gfx.DrawString("9:00 AM - 7:00 PM", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.125, 89, 0, 0), XStringFormats.Center);

            //Days of the Week
            font = new XFont(FONT_TYPE, 12, XFontStyle.Regular);
            gfx.DrawString("MONDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.083, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("TUESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.249, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("WEDNESDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.415, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("THURSDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.581, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("FRIDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.748, 105, 0, 0), XStringFormats.Center);
            gfx.DrawString("SATURDAY", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.914, 105, 0, 0), XStringFormats.Center);

            //Company Name
            font = new XFont(FONT_TYPE, 40, XFontStyle.Bold);
            gfx.DrawString("CHANGES COUNSELING", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 25, 0, 0), XStringFormats.Center);

            //Address & Website
            font = new XFont(FONT_TYPE, 10, XFontStyle.Regular);
            gfx.DrawString("8221 South 700 East, Sandy, UT 84070", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 60, 0, 0), XStringFormats.Center);
            gfx.DrawString("WWW.CHANGESCOUNSELING.ORG", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.5, 75, 0, 0), XStringFormats.Center);

            //Contact Information
            font = new XFont(FONT_TYPE, 12, XFontStyle.Regular);
            gfx.DrawString("Office: (801) 542-7060", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 25, 0, 0), XStringFormats.Center);
            gfx.DrawString("Text / UA: (801) 987-0225", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 40, 0, 0), XStringFormats.Center);
            gfx.DrawString("Fax: (801) 542-7061", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 55, 0, 0), XStringFormats.Center);
            gfx.DrawString("info@changescounseling.org", font, XBrushes.Black, new XRect(PDF_WIDTH * 0.875, 70, 0, 0), XStringFormats.Center);

            //Date Numbers
            font = new XFont(FONT_TYPE, 12, XFontStyle.Regular);

            int xPosition = 160;
            int yPosition = 125;
            int cellCtr = 0;
            for (int drawCalDatesIdx = 0; drawCalDatesIdx < 30; drawCalDatesIdx++)
            {
                gfx.DrawString(dates[drawCalDatesIdx],
                font,
                XBrushes.Black,
                new XRect(xPosition, yPosition, 0, 0),
                XStringFormats.Center);
                xPosition += xPosition <= 670 ? 170 : 174;
                cellCtr++;
                if (cellCtr % 6 == 0)
                {
                    xPosition = 160;
                    yPosition += 130;
                }
            }

            //Cell Content
            font = new XFont(FONT_TYPE, 10, XFontStyle.Regular);

            XTextFormatter tf = new XTextFormatter(gfx);
            tf.Alignment = XParagraphAlignment.Left;

            xPosition = 5;
            yPosition = 135;
            cellCtr = 0;
            for (int drawCalContentIdx = 0; drawCalContentIdx < 30; drawCalContentIdx++)
            {
                tf.DrawString(cellData[drawCalContentIdx],
                font,
                XBrushes.Black,
                new XRect(xPosition, yPosition, 165, 130),
                XStringFormats.TopLeft);
                xPosition += 170;
                cellCtr++;
                if (cellCtr % 6 == 0)
                {
                    xPosition = 5;
                    yPosition += 130;
                }
            }

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

            string filename = $"{monthYear.Replace(" ", "")}.pdf";
            document.Save(filename);

            Process.Start(filename);
        }
    }
}
