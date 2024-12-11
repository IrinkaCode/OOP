// Word

using Word = Microsoft.Office.Interop.Word;
Word.Application wordApp= new Word.Application();
//Word.Document worddoc = wordApp.Documents.Add();
Word.Document wordDoc = wordApp.Documents.Open(@"C:\Users\pil02\first.docx");
Word.Paragraph para1 = wordDoc.Paragraphs.Add();
//para1.Range.Text = "Это первый текстовый блок. \n";
//Word.Paragraph pars1 = wordDoc.Paragraphs.Add();

//para2.Range.Text = "Это второй текстовый блок. \n";
//Word.Paragraph pars2 = wordDoc.Paragraphs.Add();

//para3.Range.Text = "Это третий текстовый блок";
//Word.Paragraph pars3 = wordDoc.Paragraphs.Add();

//Word.Paragraph paragraph = worddoc.Paragraphs.Add();
//paragraph.Range.Text = "Hello, world!";

//Word.Range range = wordDoc.Content;
//range.Find.Execute("Это второй текстовый блок.", ReplaceWith: "Замененный параграф");

//range.Font.Name = "Arial";
//range.Font.Size = 14;
//range.Font.Bold = 1;
//range.Font.Color = Word.WdColor.wdColorRed;

//Word.Paragraph heading = wordDoc.Paragraphs.Add();
//heading.Range.Font.Name = "Times New Roman";
//heading.Range.Font.Size = 18;
//heading.Range.Font.Color = Word.WdColor.wdColorBrightGreen;
//heading.Range.Text = "Замененный продукт";

wordDoc.SaveAs(@"C:\Users\pil02\first.docx");
wordDoc.Close();
wordApp.Quit();





