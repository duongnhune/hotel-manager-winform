//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Syncfusion.DocIO;
//using Syncfusion.DocIO.DLS;
//using System.Threading.Tasks;

//namespace BLL
//{
//    public class MyReports
//    {
//        public void exportDocument(string mDe, string mHoc, List<BaiThi> baiThis)
//        {
//            WordDocument document = new WordDocument();
//            //Adding a new section to the document.
//            WSection section = document.AddSection() as WSection;
//            //Set Margin of the section
//            section.PageSetup.Margins.All = 72;
//            //Set page size of the section
//            section.PageSetup.PageSize = new SizeF(612, 792);

//            //Create Paragraph styles
//            WParagraphStyle style = document.AddParagraphStyle("Normal") as WParagraphStyle;
//            style.CharacterFormat.FontName = "Calibri";
//            style.CharacterFormat.FontSize = 11f;
//            style.ParagraphFormat.BeforeSpacing = 0;
//            style.ParagraphFormat.AfterSpacing = 8;
//            style.ParagraphFormat.LineSpacing = 13.8f;

//            style = document.AddParagraphStyle("Heading 1") as WParagraphStyle;
//            style.ApplyBaseStyle("Normal");
//            style.CharacterFormat.FontName = "Calibri Light";
//            style.CharacterFormat.FontSize = 16f;
//            style.CharacterFormat.TextColor = Color.FromArgb(46, 116, 181);
//            style.ParagraphFormat.BeforeSpacing = 12;
//            style.ParagraphFormat.AfterSpacing = 0;
//            style.ParagraphFormat.Keep = true;
//            style.ParagraphFormat.KeepFollow = true;
//            style.ParagraphFormat.OutlineLevel = OutlineLevel.Level1;

//            IWParagraph paragraph = section.HeadersFooters.Header.AddParagraph();


//            paragraph.ApplyStyle("Normal");
//            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;
//            WTextRange textRange = paragraph.AppendText("Trường đại học Công nghiệp Thực phẩm TP HCM") as WTextRange;
//            textRange.CharacterFormat.FontSize = 12f;
//            textRange.CharacterFormat.FontName = "Calibri";
//            textRange.CharacterFormat.TextColor = Color.Blue;

//            //Appends paragraph.
//            paragraph = section.AddParagraph();
//            paragraph.ApplyStyle("Heading 1");
//            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
//            textRange = paragraph.AppendText("Bài thi") as WTextRange;
//            textRange.CharacterFormat.FontSize = 18f;
//            textRange.CharacterFormat.TextColor = Color.Black;
//            textRange.CharacterFormat.FontName = "Times New Roman";


//            //Appends paragraph.
//            paragraph = section.AddParagraph();
//            paragraph.ApplyStyle("Heading 1");
//            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
//            textRange = paragraph.AppendText(mHoc) as WTextRange;
//            textRange.CharacterFormat.FontSize = 18f;
//            textRange.CharacterFormat.TextColor = Color.Black;
//            textRange.CharacterFormat.FontName = "Times New Roman";

//            //Appends paragraph.
//            paragraph = section.AddParagraph();
//            paragraph.BreakCharacterFormat.FontSize = 14f;
//            textRange = paragraph.AppendText("Mã đề: " + mDe) as WTextRange;
//            textRange.CharacterFormat.FontSize = 14f;
//            textRange.CharacterFormat.Bold = true;

//            paragraph = section.AddParagraph();
//            paragraph.ParagraphFormat.AfterSpacing = 0;
//            paragraph.ParagraphFormat.LineSpacing = 14f;
//            paragraph.BreakCharacterFormat.FontSize = 14f;
//            paragraph.BreakCharacterFormat.FontName = "Times New Roman";
//            int i = 1;
//            foreach (var item in baiThis)
//            {
//                string rsDung = "";
//                string rsSai = "";
//                if (item.TrangThai.Trim().Equals("Đúng"))
//                    rsDung = item.CauTraLoi;
//                else if (item.TrangThai.Trim().Equals("Sai"))
//                    rsSai = item.CauTraLoi;

//                textRange = paragraph.AppendText("\r\r") as WTextRange;

//                textRange = paragraph.AppendText("Câu hỏi " + i + ": " + item.NganHangCauHoi.CauHoi + "\r") as WTextRange;
//                textRange.CharacterFormat.FontSize = 14f;
//                textRange.CharacterFormat.Bold = true;
//                textRange.CharacterFormat.FontName = "Times New Roman";


//                textRange = paragraph.AppendText("A: " + item.NganHangCauHoi.DapAnA + "\r") as WTextRange;
//                textRange.CharacterFormat.FontSize = 14f;
//                textRange.CharacterFormat.FontName = "Times New Roman";
//                if (rsDung.Trim().Equals("A"))
//                    textRange.CharacterFormat.TextColor = Color.Green;
//                else if (rsSai.Trim().Equals("A"))
//                    textRange.CharacterFormat.TextColor = Color.Red;
//                else textRange.CharacterFormat.TextColor = Color.Black;

//                textRange = paragraph.AppendText("B: " + item.NganHangCauHoi.DapAnB + "\r") as WTextRange;
//                textRange.CharacterFormat.FontSize = 14f;
//                textRange.CharacterFormat.FontName = "Times New Roman";
//                if (rsDung.Trim().Equals("B"))
//                    textRange.CharacterFormat.TextColor = Color.Green;
//                else if (rsSai.Trim().Equals("B"))
//                    textRange.CharacterFormat.TextColor = Color.Red;
//                else textRange.CharacterFormat.TextColor = Color.Black;

//                textRange = paragraph.AppendText("C: " + item.NganHangCauHoi.DapAnC + "\r") as WTextRange;
//                textRange.CharacterFormat.FontSize = 14f;
//                textRange.CharacterFormat.FontName = "Times New Roman";
//                if (rsDung.Trim().Equals("C"))
//                    textRange.CharacterFormat.TextColor = Color.Green;
//                else if (rsSai.Trim().Equals("C"))
//                    textRange.CharacterFormat.TextColor = Color.Red;
//                else textRange.CharacterFormat.TextColor = Color.Black;

//                textRange = paragraph.AppendText("D: " + item.NganHangCauHoi.DapAnD + "\r") as WTextRange;
//                textRange.CharacterFormat.FontSize = 14f;
//                textRange.CharacterFormat.FontName = "Times New Roman";
//                if (rsDung.Trim().Equals("D"))
//                    textRange.CharacterFormat.TextColor = Color.Green;
//                else if (rsSai.Trim().Equals("D"))
//                    textRange.CharacterFormat.TextColor = Color.Red;
//                else textRange.CharacterFormat.TextColor = Color.Black;
//                i++;
//            }

//            //Appends paragraph.
//            section.AddParagraph();

//            //Saves the Word document
//            document.Save(SaveFileDocx());
//        }
//        private static string SaveFileDocx()
//        {
//            string result = string.Empty;

//            SaveFileDialog saveFileDialog = new SaveFileDialog();
//            saveFileDialog.Filter = "Word Documents| *.docx";
//            saveFileDialog.AddExtension = true;
//            saveFileDialog.DefaultExt = ".docx";

//            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.CheckPathExists)
//            {
//                //workbook.SaveAs(saveFileDialog.FileName);
//                result = saveFileDialog.FileName;
//            }

//            return result;
//        }

//    }
//}
