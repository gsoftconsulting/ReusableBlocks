using ReusableBlocks.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Readers
{
    public class ExcelListReaderBlock : IListReader<ArrayList>, IDisposable
    {
        private Microsoft.Office.Interop.Excel.Application excelApp;
        private Microsoft.Office.Interop.Excel.Workbooks workBooks;
        private Microsoft.Office.Interop.Excel.Workbook workBook;
        private Microsoft.Office.Interop.Excel.Worksheet workSheet;
        
        public ExcelListReaderBlock(String filePath)
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            workBooks = excelApp.Workbooks;
            workBook = workBooks.Open(filePath, @ReadOnly:true, Editable:false);
            workSheet = workBook.Sheets.Item[1];
        }

        public IList<ArrayList> Read()
        {
            workSheet.Rows.ClearFormats();

            Microsoft.Office.Interop.Excel.Range range = workSheet.UsedRange;
            int columnCount = range.Columns.Count;
            int rowCount = range.Rows.Count;
            List<ArrayList> cells = new List<ArrayList>(rowCount);

            for (int rowIndex = 1; rowIndex <= rowCount; rowIndex++)
            {
                  ArrayList content = ReadRow(rowIndex, columnCount);
                  if (content != null && content.Count > 0)
                      cells.Add(content);
            }

            return cells;
        }

        private ArrayList ReadRow(int rowIndex, int columnCount)
        {
            ArrayList list = new ArrayList(columnCount);

            for (int colIndex=0; colIndex < columnCount; colIndex++)
            {
                String column = ((int)'A' + colIndex).ToString();
                Microsoft.Office.Interop.Excel.Range r = workSheet.Range[column + rowIndex];
                list.Add(r.Text);
            }

            return list;
        }

        private Boolean disposedValue; 

        protected virtual void Dispose(Boolean disposing)
        {
            if (!disposedValue)
            {
                workBook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                workBooks.Close();
                excelApp.Quit();
            }

            disposedValue = true;
        }

        public void Dispose()
        {
            // Do not change this code.  Put cleanup code in Dispose(Boolean disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
