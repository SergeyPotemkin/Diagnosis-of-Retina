/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)

   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;


namespace DiagnosisOfRetinal
{
    class docx_Report : DocumentReport
    {
        private byte[] document;

        public docx_Report(string _directory, string _fileName) 
            : base(_directory, _fileName)
        {
            
        }

        public override void SaveDocument()
        {
            try
            {
                using (MemoryStream mem = new MemoryStream())
                {
                    mem.Write(document, 0, document.Length);
                    using (FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Create))
                    {
                        mem.WriteTo(fileStream);
                    }
                }
            }
            catch { MessageBox.Show("Сохрнаить файл не удалось. Возможно, директория больше не существует."); }

        }

        public override void CreateDocument()
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
            }

            byte[] byteArray = File.ReadAllBytes(filePath);
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(byteArray, 0, (int)byteArray.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))

                document = mem.ToArray();
            }

        }

        //создает пустой документ .docx
        //public override void CreateDocument(string directory, string fileName)
        //{
        //    string filepath = directory + @"\" + fileName + ".docx";
        //    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
        //    {
        //        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

        //        mainPart.Document = new Document();
        //        Body body = mainPart.Document.AppendChild(new Body());
        //        Paragraph para = body.AppendChild(new Paragraph());
        //        Run run = para.AppendChild(new Run());
        //        //run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));
        //    }
        //}

        public override void InsertBreak()
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Paragraph para = new Paragraph();
                    //Run run = new Run();

                    //run.AppendChild(new Break());
                    //para.AppendChild(run);
                    body.AppendChild(para);
                }
                document = mem.ToArray();
            }
        }

        public override void InsertCenterHeader(string Text)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Paragraph para = new Paragraph();
                    Run run = new Run();
                    Text text = new Text(Text);

                    setParaFont(run, para, JustificationValues.Center, "28", UnderlineValues.None);

                    run.AppendChild(text);
                    para.AppendChild(run);
                    body.AppendChild(para);
                }
                document = mem.ToArray();
            }
        }

        public override void InsertStyledLine(string first, string second)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Paragraph para = new Paragraph();
                    Run run = new Run();
                    Text text = new Text(first) { Space = SpaceProcessingModeValues.Preserve };
                    setParaFont(run, para, JustificationValues.Left, "28", UnderlineValues.None);
                    run.AppendChild(text);
                    para.AppendChild(run);

                    run = new Run();
                    text = new Text(second);
                    setParaFont(run, para, JustificationValues.Left, "28", UnderlineValues.Single);
                    run.AppendChild(text);
                    para.AppendChild(run);
                    body.AppendChild(para);
                }
                document = mem.ToArray();
            }
        }

        private void setParaFont(Run run, Paragraph para, JustificationValues just, string size, UnderlineValues under)
        {
            ParagraphProperties pRp = new ParagraphProperties();
            Justification justification = new Justification() { Val = just };
            pRp.Append(justification);

            RunProperties rp = new RunProperties();
            RunFonts runFonts = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman", ComplexScript = "Times New Roman" };
            FontSize fontSize = new FontSize() { Val = size };
            Underline underline = new Underline() { Val = under };
            rp.Append(runFonts);
            rp.Append(fontSize);
            rp.Append(underline);

            run.AppendChild(rp);
            para.AppendChild(pRp);
        }

        public override void InsertLeftHeader(string Text)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Paragraph para = new Paragraph();
                    Run run = new Run();
                    Text text = new Text(Text);

                    setParaFont(run, para, JustificationValues.Left, "32", UnderlineValues.None);

                    run.AppendChild(text);
                    para.AppendChild(run);
                    body.AppendChild(para);
                }
                document = mem.ToArray();
            }
        }

        public override void InsertTopHeader(string Text)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Paragraph para = new Paragraph();
                    Run run = new Run();
                    Text text = new Text(Text);

                    setParaFont(run, para, JustificationValues.Center, "32", UnderlineValues.None);

                    run.AppendChild(text);
                    para.AppendChild(run);
                    body.AppendChild(para);
                }
                document = mem.ToArray();
            }
        }

        public override void InsertDataTimeInfo()
        {
            throw new NotImplementedException();
        }

        public override void InsertDoctorInfo()
        {
            throw new NotImplementedException();
        }

        public override void InsertGlobalParameters()
        {
            throw new NotImplementedException();
        }

        public override void InsertHeaderInfo()
        {
            throw new NotImplementedException();
        }

        public override void InsertHeadLine()
        {
            throw new NotImplementedException();
        }

        public override void InsertImage(FileStream file, Image img)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    MainDocumentPart mainPart = wordDoc.MainDocumentPart;
                    ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);

                    imagePart.FeedData(file);

                    long imageWidthEMU = 990000L * 6;
                    long devide = (long)((img.Width* 914400L) / imageWidthEMU);
                    long imageHeightEMU = (long)((img.Height * 914400L) / devide);

                    var element =
     new Drawing(
         new DW.Inline(
             new DW.Extent { Cx = imageWidthEMU, Cy = imageHeightEMU },
             new DW.EffectExtent()
             {
                 LeftEdge = 0L,
                 TopEdge = 0L,
                 RightEdge = 0L,
                 BottomEdge = 0L
             },
             new DW.DocProperties()
             {
                 Id = (UInt32Value)1U,
                 Name = "Picture 1"
             },
             new DW.NonVisualGraphicFrameDrawingProperties(
                 new A.GraphicFrameLocks() { NoChangeAspect = true }),
             new A.Graphic(
                 new A.GraphicData(
                     new PIC.Picture(
                         new PIC.NonVisualPictureProperties(
                             new PIC.NonVisualDrawingProperties()
                             {
                                 Id = (UInt32Value)0U,
                                 Name = "New Bitmap Image.jpg"
                             },
                             new PIC.NonVisualPictureDrawingProperties()),
                         new PIC.BlipFill(
                             new A.Blip(
                                 new A.BlipExtensionList(
                                     new A.BlipExtension()
                                     {
                                         Uri =
                                            "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                     })
                             )
                             {
                                 Embed = mainPart.GetIdOfPart(imagePart),
                                 CompressionState =
                                 A.BlipCompressionValues.Print
                             },
                             new A.Stretch(
                                 new A.FillRectangle())),
                         new PIC.ShapeProperties(
                             new A.Transform2D(
                                 new A.Offset() { X = 0L, Y = 0L },
                                 new A.Extents() { Cx = imageWidthEMU, Cy = imageHeightEMU }),
                             new A.PresetGeometry(
                                 new A.AdjustValueList()
                             )
                             { Preset = A.ShapeTypeValues.Rectangle }))
                 )
                 { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
         )
         {
             DistanceFromTop = (UInt32Value)0U,
             DistanceFromBottom = (UInt32Value)0U,
             DistanceFromLeft = (UInt32Value)0U,
             DistanceFromRight = (UInt32Value)0U,
             EditId = "50D07946"
         });

                    // Append the reference to body, the element should be in a Run.
                    wordDoc.MainDocumentPart.Document.Body.AppendChild(new Paragraph(new Run(element)));
                }
                document = mem.ToArray();
            }
        }

        public override void InsertLocalParameters()
        {
            throw new NotImplementedException();
        }

        public override void InsertPacientInfo()
        {
            throw new NotImplementedException();
        }

        public override void InsertParagraph()
        {
            throw new NotImplementedException();
        }

        public override void InsertTable(Dictionary<string, string> param)
        {
            using (MemoryStream mem = new MemoryStream())
            {
                mem.Write(document, 0, (int)document.Length);
                using (WordprocessingDocument wordDoc =
                    WordprocessingDocument.Open(mem, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Table table = new Table();

                    TableProperties tblProp = new TableProperties(
                        new TableBorders(
                            new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 },
                            new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 },
                            new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 },
                            new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 },
                            new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 },
                            new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 5 }
                        )
                    );
                    table.AppendChild<TableProperties>(tblProp);

                    for (int i=0; i< param.Count; i++)
                    {
                        TableRow tr = new TableRow();

                            TableCell tc1 = new TableCell();
                            tc1.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "3500" }));
                            tc1.Append(new Paragraph(new Run(new Text(param.Keys.ToList()[i]))));
                            tr.Append(tc1);
                            TableCell tc2 = new TableCell();
                            tc2.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "3000" }));
                            tc2.Append(new Paragraph(new Run(new Text(param.Values.ToList()[i]))));
                            tr.Append(tc2);

                        table.Append(tr);
                    }
                    body.Append(table);
                }
                document = mem.ToArray();
            }
        }
    }
}
