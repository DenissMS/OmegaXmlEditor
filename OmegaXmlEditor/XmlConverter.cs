#region

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
#endregion

namespace OmegaXmlEditor
{
    internal class XmlConverter
    {
        /// <summary>
        /// Символ разделения ячеек таблицы по умолчанию.
        /// </summary>
        private const string DEFAULT_DELIMITER = ",";
        public const string XLS = ".xls", JSON = ".json", CSV = ".csv";
        /// <summary>
        /// Конвертирует заданный XML элемент в формат CSV с заданным разделителем.
        /// </summary>
        /// <param name="element">Экземпляр XML элемента.</param>
        /// <param name="delimiter">Символ разделителя ячеек таблицы.</param>
        /// <returns>Возвращает текст CSV таблицы.</returns>
        public static string ConvertToCsv(XElement element, string delimiter)
        {
            //foreach (var elem in element.Elements())
            //{
            //    List<string> lRow = new List<string>();
            //    foreach (var el in elem.Elements())
            //    {

            //        lRow.Add(el.Value);
            //    }
            //    csv += string.Join(delimiter, lRow);
            //}
            return element.Elements()
                .Select(elem => elem.Elements()
                    .Select(el => el.Value)
                    .ToList())
                .Aggregate(String.Empty, (current, lRow) =>
                    current + String.Join(delimiter, lRow) + "\n");
        }
        /// <summary>
        /// Сохраняет заданый XML элемент по заданному пути с заданным разделителем.
        /// </summary>
        /// <param name="element">Экземпляр XML элемента.</param>
        /// <param name="filePath">Путь сохраняемого файла.</param>
        /// <param name="delimiter">Сивол разделителя ячеек таблицы. По умолчанию используется символ ",".</param>
        public static void SaveAsCsv(XElement element, string filePath, string delimiter = DEFAULT_DELIMITER)
        {
            var csv = ConvertToCsv(element, delimiter);
            SaveText(csv, filePath);
        }
        /// <summary>
        /// Сохраняет заданый XML элемент по заданному пути с заданным разделителем в формате JSON.
        /// </summary>
        /// <param name="element">Экземпляр XML элемента.</param>
        /// <param name="filePath">Путь сохраняемого файла.</param>
        public static void SaveAsJson(XElement element, string filePath)
        {
            var json = JsonConvert.SerializeXNode(element);
            SaveText(json, filePath);
        }
        /// <summary>
        /// Сохраняет заданый XML элемент по заданному пути с заданным разделителем в формате XLS.
        /// </summary>
        /// <param name="element">Экземпляр XML элемента.</param>
        /// <param name="filePath">Путь сохраняемого файла.</param>
        public static void SaveAsXls(XElement element, string filePath)
        {
            Application app = null;
            try
            {
                app = new Application
                {
                    Visible = false,
                    DisplayAlerts = false,
                    SheetsInNewWorkbook = 1
                };
                app.Workbooks.Add(Type.Missing);
                var workbook = app.Workbooks[1];
                var worksheet = (Worksheet) workbook.Worksheets.Item[1];
                var rowIndex = 1;
                foreach (var elem in element.Elements())
                {
                    var colIndex = 1;
                    foreach (var el in elem.Elements())
                    {
                        ((Range) worksheet.Cells[rowIndex, colIndex++]).Value2 = el.Value;
                    }
                    rowIndex++;
                }
                workbook.SaveAs(filePath, XlFileFormat.xlExcel8, Missing.Value,
                    Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange,
                    XlSaveConflictResolution.xlUserResolution, true,
                    Missing.Value, Missing.Value, Missing.Value);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (app != null)
                    app.Quit();
            }       
        }
        /// <summary>
        /// Сохраняет заданый XML текст по заданному пути
        /// </summary>
        /// <param name="text">Текст XML элемента.</param>
        /// <param name="filePath">Путь сохраняемого файла.</param>
        private static void SaveText(string text, string filePath)
        {
            using (Stream s = File.Open(filePath, FileMode.CreateNew))
            using (var sw = new StreamWriter(s))
            {
                sw.Write(text);
            }
        }

        /// <summary>
        /// Сохраняет заданый XML элемент с заданным форматом по заданному пути.
        /// </summary>
        /// <param name="element">Экземпляр XML элемента.</param>
        /// <param name="format">Формат файла.</param>
        /// <param name="filePath">Путь сохраняемого файла.</param>
        public static bool SaveAs(XElement element, FileFormat format, string filePath)
        {
            try
            {
                switch (format)
                {
                    case FileFormat.Csv:
                        SaveAsCsv(element, filePath + CSV);
                        break;
                    case FileFormat.Excel:
                        SaveAsXls(element, filePath + XLS);
                        break;
                    case FileFormat.Json:
                        SaveAsJson(element, filePath + JSON);
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}