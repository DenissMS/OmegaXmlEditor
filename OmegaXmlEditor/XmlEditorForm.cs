using System;
using System.IO;
using System.Windows.Forms;

namespace OmegaXmlEditor
{
    public partial class XmlEditorForm : Form
    {
        private string _currentSaveFile;
        private readonly XmlEditor _editor;
        private bool _cellChanged, _elementNameChanged, _elementValueChanged, _xmlTextChanged;
        private ExportForm _exportForm;

        private bool IsPathDefined
        {
            get { return !string.IsNullOrEmpty(_currentSaveFile); }
        }
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public XmlEditorForm()
        {
            InitializeComponent();
            _editor = new XmlEditor(tvXmlMap, scXmlEdit);
            btnAdd.Click += AddElement_Click;
            btnRemove.Click += RemoveElement_Click;
        }
        /// <summary>
        /// Добавляет новый элемент в документ.
        /// </summary>
        private void AddElement_Click(object sender, EventArgs e)
        {
            _editor.AddElement();
        }
        /// <summary>
        /// Удаляет выбранный элемент из документа.
        /// </summary>
        private void RemoveElement_Click(object sender, EventArgs e)
        {
            if (_editor.RemoveElement())
            {
                _editor.RefreshElement(tbNodeName, tbElementValue);
            }
        }
        /// <summary>
        /// Вставляет новый элемент внутрь выбранно элемента.
        /// </summary>
        private void InsertElement_Click(object sender, EventArgs e)
        {
            tbElementValue.Enabled = !_editor.InsertElement();
        }
        /// <summary>
        /// Осуществляет проверку на доступность выбранного элемента в XML дереве.
        /// </summary>
        private void cmsTreeMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _editor.CheckSelectedNode(cmsTreeMenu.Items);
        }

        /// <summary>
        /// Задает новый активный элемент документа.
        /// </summary>
        private void tvXmlMap_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvXmlMap.SelectedNode = e.Node;
            _editor.RefreshElement(tbNodeName, tbElementValue);
            RefreshAttributes();
        }
        /// <summary>
        /// Обновляет аттрибуты активного элемента.
        /// </summary>
        public void RefreshAttributes()
        {
            dgvElementAttributes.Rows.Clear();
            if (_editor.CurrentElement != null)
            {
                foreach (var attr in _editor.CurrentElement.Attributes())
                {
                    dgvElementAttributes.Rows.Add(attr.Name, attr.Value);
                }
            }
        }
        /// <summary>
        /// Если название элемента изменено, обновляет элемент.
        /// </summary>
        private void tbNodeName_Leave(object sender, EventArgs e)
        {
            if (_elementNameChanged)
            {
                _editor.SetElementName(tbNodeName);
                _elementNameChanged = false;
            }
        }
        /// <summary>
        /// Если значение элемента изменено, обновляет элемент.
        /// </summary>
        private void tbElementValue_Leave(object sender, EventArgs e)
        {
            if (_elementValueChanged)
            {
                _editor.SetElementValue(tbElementValue);
                _elementValueChanged = false;
            }
        }
        /// <summary>
        /// Добавляет новый аттрибут в активный элемент.
        /// </summary>
        private void btnAddAttr_Click(object sender, EventArgs e)
        {
            _editor.AddAttribute(dgvElementAttributes);
        }
        /// <summary>
        /// Удаляет выделенный аттрибут активного элемента.
        /// </summary>
        private void btnRemoveAttr_Click(object sender, EventArgs e)
        {
            if (dgvElementAttributes.SelectedRows.Count == 0) return;
            var selectedRow = dgvElementAttributes.SelectedRows[0];
            _editor.RemoveAttribute(selectedRow.Cells[0].Value.ToString());
            dgvElementAttributes.Rows.RemoveAt(selectedRow.Index);
        }
        /// <summary>
        /// Задает активный аттрибут.
        /// </summary>
        private void dgvElementAttributes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _editor.CurrentAttribute = dgvElementAttributes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        /// <summary>
        /// Если название или значение аттрибута было изменено, обновляет аттрибут.
        /// </summary>
        private void dgvElementAttributes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_cellChanged)
            {
                var selectedRow = dgvElementAttributes.Rows[e.RowIndex];
                var attrName = selectedRow.Cells[0].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    _editor.SetAtributeName(_editor.CurrentAttribute, attrName);
                }
                else
                {
                    _editor.SetAttributeValue(attrName, selectedRow.Cells[1].Value.ToString());
                }
                _cellChanged = false;
            }
        }
        /// <summary>
        /// Обновляет состояние изменения в таблице аттрибутов.
        /// </summary>
        private void dgvElementAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _cellChanged = true;
        }
        /// <summary>
        /// Обновляет состояние изменения имени элемента.
        /// </summary>
        private void tbNodeName_TextChanged(object sender, EventArgs e)
        {
            _elementNameChanged = true;
        }
        /// <summary>
        /// Обновляет состояние изменения значение элемента.
        /// </summary>
        private void tbElementValue_TextChanged(object sender, EventArgs e)
        {
            _elementValueChanged = true;
        }
        /// <summary>
        /// Сохраняет текущий документ, если задана директория.
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentSaveFile))
            {
                SaveFile();
            }
            else
            {
                SaveFile(_currentSaveFile);
            }
        }
        /// <summary>
        /// Сохраняет текущий документ в файл.
        /// </summary>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        /// <summary>
        /// Выходит из программы.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Сохраняет файл по заданному пути.
        /// </summary>
        /// <param name="path">Путь сохранения.</param>
        private void SaveFile(string path = null)
        {
            try
            {
                if (path == null)
                {
                    var sfd = new SaveFileDialog
                    {
                        Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
                        FilterIndex = 2,
                        RestoreDirectory = true
                    };

                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    _currentSaveFile = sfd.FileName;

                }
                using (Stream s = File.Open(_currentSaveFile, FileMode.Create))
                using (var strw = new StreamWriter(s, System.Text.Encoding.UTF8))
                {
                    _editor.Document.Save(strw); 
                }
                SaveToolStripMenuItem.Enabled = IsPathDefined;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        /// <summary>
        /// Начинает процесс открытия XML документа, отображая диалоговое окно открытия файла.
        /// </summary>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new OpenFileDialog
                {
                    Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var s = File.Open(sfd.FileName, FileMode.Open))
                using (var sr = new StreamReader(s))
                {
                    var xml = sr.ReadToEnd();
                    _editor.ParseXmlDocument(xml);
                    scXmlEdit.Text = xml;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
        /// <summary>
        /// Инициализирует и отображает форму экспорта документа.
        /// </summary>
        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _exportForm = new ExportForm(_editor.CurrentElement);
            _exportForm.Show();
        }
        /// <summary>
        /// Выполняет обновление документа, если содержимое XML текста было изменено.
        /// </summary>
        private void scXmlEdit_Leave(object sender, EventArgs e)
        {
            if (_xmlTextChanged)
            {
                _editor.UpdateXmlDocument(scXmlEdit.Text);
                _xmlTextChanged = false;
            }
        }
        /// <summary>
        /// Обновляет состоение изменения XML текста.
        /// </summary>
        private void scXmlEdit_TextChanged(object sender, EventArgs e)
        {
            _xmlTextChanged = true;
        }
    }

    public partial class ПродолжениеXmlEditorForm : Form
    {
        private string _currentSaveFile;
        private readonly XmlEditor _editor;
        private bool _cellChanged, _elementNameChanged, _elementValueChanged, _xmlTextChanged;
        private ExportForm _exportForm;

        private bool IsPathDefined
        {
            get { return !string.IsNullOrEmpty(_currentSaveFile); }
        }
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ПродолжениеXmlEditorForm()
        {
            InitializeComponent();
            _editor = new XmlEditor(tvXmlMap, scXmlEdit);
            btnAdd.Click += AddElement_Click;
            btnRemove.Click += RemoveElement_Click;
        }
        /// <summary>
        /// Добавляет новый элемент в документ.
        /// </summary>
        private void AddElement_Click(object sender, EventArgs e)
        {
            _editor.AddElement();
        }
        /// <summary>
        /// Удаляет выбранный элемент из документа.
        /// </summary>
        private void RemoveElement_Click(object sender, EventArgs e)
        {
            if (_editor.RemoveElement())
            {
                _editor.RefreshElement(tbNodeName, tbElementValue);
            }
        }
        /// <summary>
        /// Вставляет новый элемент внутрь выбранно элемента.
        /// </summary>
        private void InsertElement_Click(object sender, EventArgs e)
        {
            tbElementValue.Enabled = !_editor.InsertElement();
        }
        /// <summary>
        /// Осуществляет проверку на доступность выбранного элемента в XML дереве.
        /// </summary>
        private void cmsTreeMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _editor.CheckSelectedNode(cmsTreeMenu.Items);
        }

        /// <summary>
        /// Задает новый активный элемент документа.
        /// </summary>
        private void tvXmlMap_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvXmlMap.SelectedNode = e.Node;
            _editor.RefreshElement(tbNodeName, tbElementValue);
            RefreshAttributes();
        }
        /// <summary>
        /// Обновляет аттрибуты активного элемента.
        /// </summary>
        public void RefreshAttributes()
        {
            dgvElementAttributes.Rows.Clear();
            if (_editor.CurrentElement != null)
            {
                foreach (var attr in _editor.CurrentElement.Attributes())
                {
                    dgvElementAttributes.Rows.Add(attr.Name, attr.Value);
                }
            }
        }
        /// <summary>
        /// Если название элемента изменено, обновляет элемент.
        /// </summary>
        private void tbNodeName_Leave(object sender, EventArgs e)
        {
            if (_elementNameChanged)
            {
                _editor.SetElementName(tbNodeName);
                _elementNameChanged = false;
            }
        }
        /// <summary>
        /// Если значение элемента изменено, обновляет элемент.
        /// </summary>
        private void tbElementValue_Leave(object sender, EventArgs e)
        {
            if (_elementValueChanged)
            {
                _editor.SetElementValue(tbElementValue);
                _elementValueChanged = false;
            }
        }
        /// <summary>
        /// Добавляет новый аттрибут в активный элемент.
        /// </summary>
        private void btnAddAttr_Click(object sender, EventArgs e)
        {
            _editor.AddAttribute(dgvElementAttributes);
        }
        /// <summary>
        /// Удаляет выделенный аттрибут активного элемента.
        /// </summary>
        private void btnRemoveAttr_Click(object sender, EventArgs e)
        {
            if (dgvElementAttributes.SelectedRows.Count == 0) return;
            var selectedRow = dgvElementAttributes.SelectedRows[0];
            _editor.RemoveAttribute(selectedRow.Cells[0].Value.ToString());
            dgvElementAttributes.Rows.RemoveAt(selectedRow.Index);
        }
        /// <summary>
        /// Задает активный аттрибут.
        /// </summary>
        private void dgvElementAttributes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _editor.CurrentAttribute = dgvElementAttributes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        /// <summary>
        /// Если название или значение аттрибута было изменено, обновляет аттрибут.
        /// </summary>
        private void dgvElementAttributes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_cellChanged)
            {
                var selectedRow = dgvElementAttributes.Rows[e.RowIndex];
                var attrName = selectedRow.Cells[0].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    _editor.SetAtributeName(_editor.CurrentAttribute, attrName);
                }
                else
                {
                    _editor.SetAttributeValue(attrName, selectedRow.Cells[1].Value.ToString());
                }
                _cellChanged = false;
            }
        }
        /// <summary>
        /// Обновляет состояние изменения в таблице аттрибутов.
        /// </summary>
        private void dgvElementAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _cellChanged = true;
        }
        /// <summary>
        /// Обновляет состояние изменения имени элемента.
        /// </summary>
        private void tbNodeName_TextChanged(object sender, EventArgs e)
        {
            _elementNameChanged = true;
        }
        /// <summary>
        /// Обновляет состояние изменения значение элемента.
        /// </summary>
        private void tbElementValue_TextChanged(object sender, EventArgs e)
        {
            _elementValueChanged = true;
        }
        /// <summary>
        /// Сохраняет текущий документ, если задана директория.
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentSaveFile))
            {
                SaveFile();
            }
            else
            {
                SaveFile(_currentSaveFile);
            }
        }
        /// <summary>
        /// Сохраняет текущий документ в файл.
        /// </summary>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        /// <summary>
        /// Выходит из программы.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Сохраняет файл по заданному пути.
        /// </summary>
        /// <param name="path">Путь сохранения.</param>
        private void SaveFile(string path = null)
        {
            try
            {
                if (path == null)
                {
                    var sfd = new SaveFileDialog
                    {
                        Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
                        FilterIndex = 2,
                        RestoreDirectory = true
                    };

                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    _currentSaveFile = sfd.FileName;

                }
                using (Stream s = File.Open(_currentSaveFile, FileMode.Create))
                using (var strw = new StreamWriter(s, System.Text.Encoding.UTF8))
                {
                    _editor.Document.Save(strw);
                }
                SaveToolStripMenuItem.Enabled = IsPathDefined;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        /// <summary>
        /// Начинает процесс открытия XML документа, отображая диалоговое окно открытия файла.
        /// </summary>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new OpenFileDialog
                {
                    Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var s = File.Open(sfd.FileName, FileMode.Open))
                using (var sr = new StreamReader(s))
                {
                    var xml = sr.ReadToEnd();
                    _editor.ParseXmlDocument(xml);
                    scXmlEdit.Text = xml;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
        /// <summary>
        /// Инициализирует и отображает форму экспорта документа.
        /// </summary>
        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _exportForm = new ExportForm(_editor.CurrentElement);
            _exportForm.Show();
        }
        /// <summary>
        /// Выполняет обновление документа, если содержимое XML текста было изменено.
        /// </summary>
        private void scXmlEdit_Leave(object sender, EventArgs e)
        {
            if (_xmlTextChanged)
            {
                _editor.UpdateXmlDocument(scXmlEdit.Text);
                _xmlTextChanged = false;
            }
        }
        /// <summary>
        /// Обновляет состоение изменения XML текста.
        /// </summary>
        private void scXmlEdit_TextChanged(object sender, EventArgs e)
        {
            _xmlTextChanged = true;
        }
    }
}
