using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DiagnosisOfRetinal
{
    abstract class DocumentReport
    {
        protected string filePath;

        public DocumentReport(string _directory, string _fileName)
        {
            filePath = _directory + @"\" + _fileName + ".docx";
        }

        public abstract void CreateDocument();
        public abstract void SaveDocument();

        public abstract void InsertParagraph();
        public abstract void InsertImage(FileStream file, Image img);
        //создание таблицы размерности rows на 2
        public abstract void InsertTable(Dictionary<string, string> param);

        public abstract void InsertDataTimeInfo();
        public abstract void InsertDoctorInfo();
        public abstract void InsertPacientInfo();
        public abstract void InsertCenterHeader(string Text);
        public abstract void InsertLeftHeader(string Text);
        public abstract void InsertTopHeader(string Text);
        public abstract void InsertStyledLine(string first, string second);
        public abstract void InsertBreak();

        public abstract void InsertHeaderInfo();
        public abstract void InsertHeadLine();
        public abstract void InsertGlobalParameters();
        public abstract void InsertLocalParameters();
    }
}
