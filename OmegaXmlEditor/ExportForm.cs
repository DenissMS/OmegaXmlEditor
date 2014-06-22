using System;
using System.Windows.Forms;
using System.Xml.Linq;
using OmegaXmlEditor.Properties;

namespace OmegaXmlEditor
{
    public partial class ExportForm : Form
    {
        private FileFormat _exportFormat;
        /// <summary>
        /// Экспортируемый элемент XML документа.
        /// </summary>
        private readonly XElement _element;
        /// <summary>
        /// Символ разделения ячеек таблицы.
        /// </summary>
        private const string DELIMITER = ",";
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="element">Экспортируемый элемент XML документа.</param>
        public ExportForm(XElement element)
        {
            _element = element;
            InitializeComponent();
        }
        /// <summary>
        /// Показывает предпросмотр документа (если доступен) при выборе формата экспорта.
        /// </summary>
        private void Format_CheckedChanged(object sender, EventArgs e)
        {
            var previewText = string.Empty;
            rtbPreview.Enabled = true;
            rtbPreview.Text = string.Empty;

            switch (((RadioButton)sender).Name)
            {
                case "rbCsv": _exportFormat = FileFormat.Csv;
                    previewText = XmlConverter.ConvertToCsv(_element, DELIMITER);
                    break;
                case "rbXlsx": _exportFormat = FileFormat.Excel;
                    break;
                case "rbJson": _exportFormat = FileFormat.Json;
                    previewText = Newtonsoft.Json.JsonConvert.SerializeXNode(_element);
                    break;
            }
            if (string.IsNullOrEmpty(previewText))
            {
                rtbPreview.Text = Resources.NotSupportedForPreview;
                rtbPreview.Enabled = false;
            }
            else
            {
                rtbPreview.Text = previewText;
            }
        }
        /// <summary>
        /// Закрывает форму.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Сохраняет документ в выбранном формате и закрывает форму.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XmlConverter.SaveAs(_element, _exportFormat, tbFilePath.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show(Resources.SaveError, Resources.Error);
            }
        }
        /// <summary>
        /// Устанавливает путь сохранения файла.
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fileExtension = string.Empty;

            var sfd = new SaveFileDialog
            {
                Filter = "Все файлы (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;
            tbFilePath.Text = sfd.FileName + fileExtension;
        }
    }
}
