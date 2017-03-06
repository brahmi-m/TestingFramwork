using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using System.IO;
using System.Data;



namespace DemoQA.Environment
{
    class ExcelLib
    {
        class DataCollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }

        static List<DataCollection> data = new List<DataCollection>();

        public static DataTable ExcelToDataTable(string path,string sheetName)
        {
            FileStream stream = File.Open(path,FileMode.Open,FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            excelReader.IsFirstRowAsColumnNames = true;

            DataSet result = excelReader.AsDataSet();

            DataTableCollection table = result.Tables;

            DataTable resultTable = table[sheetName];

            return resultTable;
        }

        public static void DataTableToCollection(string path, string sheetName)
        {
            DataTable table = ExcelToDataTable(path, sheetName);
            for (int rows = 0; rows < table.Rows.Count; rows++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = rows,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[rows - 1][col].ToString()
                    };
                    data.Add(dtTable);
                }
            }
        }

        public static string ReadData(int RowNumber,string ColNumber)
        {
            try
            {
                string cellData = (from colData in data
                                   where colData.colName == ColNumber && colData.rowNumber == RowNumber
                                   select colData.colValue).SingleOrDefault();

                return cellData;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public static void WriteData()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

    }
}
