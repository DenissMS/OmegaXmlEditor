#region
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using ScintillaNET;
#endregion

namespace OmegaXmlEditor
{
    public class XmlEditor
    {
        /// <summary>
        /// Константы, содержащие имена элементов по умолчанию.
        /// </summary>
        private const string DEFAULT_NODE_NAME = "Node",
            ROOT_ELEMENT = "Root",
            DEFAULT_ATTRIBUTE_NAME = "Attr";
        /// <summary>
        /// Объект XML документа.
        /// </summary>
        public XDocument Document;
        /// <summary>
        /// Объект, содержащий текущий элемент документа.
        /// </summary>
        public XElement CurrentElement;
        private string _nodeName = DEFAULT_NODE_NAME;
        /// <summary>
        /// Объект, содержащий текущий аттрибут документа.
        /// </summary>
        public string CurrentAttribute;
        private readonly Scintilla _xmlEdit;
        public readonly Color HoverColor = Color.Lavender, ClickColor = Color.Indigo;
        /// <summary>
        /// Элемент управления, содержащий XML дерево документа.
        /// </summary>
        public TreeView XmlMap;
        /// <summary>
        /// Конструктор класса XmlEditor.
        /// </summary>
        /// <param name="xmlMap">Элемент управления, содержащий XML дерево документа.</param>
        /// <param name="tbXmlEdit">Элемент управления, содержащий XML текст.</param>
        public XmlEditor(TreeView xmlMap, Scintilla tbXmlEdit)
        {
            Document = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement(ROOT_ELEMENT));
            XmlMap = xmlMap;
            _xmlEdit = tbXmlEdit;
            Document.Changed += XmlDocument_Changed;
            _xmlEdit.Text = Document.ToString();
            CurrentElement = Document.Root;
        }
        /// <summary>
        /// Добавляет новый элемент в документ рядом с активным элементом.
        /// </summary>
        /// <returns>Возвращает true, если операция была проведена успешно.</returns>
        public bool AddElement()
        {
            if (XmlMap.SelectedNode.Parent == null) return false;
            var parent = XmlMap.SelectedNode.Parent.Text;
            var name = (parent==ROOT_ELEMENT ? DEFAULT_NODE_NAME : parent) + (XmlMap.SelectedNode.Parent.Nodes.Count + 1);
            XmlMap.SelectedNode.Parent.Nodes.Add(name);
            if (CurrentElement == null || CurrentElement.Parent == null) return false;
            CurrentElement.Parent.Add(new XElement(name));
            return true;
        }
        /// <summary>
        /// Добавляет новый элемент в документ внутрь активного элемента.
        /// </summary>
        /// <returns>Возвращает true, если операция была проведена успешно.</returns>
        public bool InsertElement()
        {
            if (XmlMap.SelectedNode == null) return false;
            var name = _nodeName + (XmlMap.SelectedNode.Nodes.Count + 1);
            XmlMap.SelectedNode.Nodes.Add(name);
            XmlMap.SelectedNode.ExpandAll();
            if (CurrentElement == null) return false;
            CurrentElement.Add(new XElement(name));
            return true;
        }
        /// <summary>
        /// Удаляет активный элемент документа.
        /// </summary>
        /// <returns>Возвращает true, если операция была проведена успешно.</returns>
        public bool RemoveElement()
        {
            if (XmlMap.SelectedNode == null || XmlMap.SelectedNode.Text == ROOT_ELEMENT) return false;
            XmlMap.SelectedNode.Remove();
            if (CurrentElement != null) CurrentElement.Remove();
            return true;
        }
        /// <summary>
        /// Осуществляет проверку на доступность выбранного элемента в XML дереве.
        /// </summary>
        /// <param name="items">Коллекция элементов контекстного меню.</param>
        public void CheckSelectedNode(ToolStripItemCollection items)
        {
            var nodeSelected = XmlMap.SelectedNode != null;
            items[2].Enabled = nodeSelected;
            //items[3].Enabled = nodeSelected;

            if (XmlMap.SelectedNode != null && XmlMap.SelectedNode.Parent == null)
            {
                items[0].Enabled = false;
                items[1].Enabled = false;
            }
            else
            {
                items[0].Enabled = true;
                items[1].Enabled = true;
            }
            if (CurrentElement != null)
            {
                items[2].Enabled = string.IsNullOrEmpty(CurrentElement.Value) || CurrentElement.HasElements;
            }
        }
        /// <summary>
        /// Обновляет название и значение выбранного элемента.
        /// </summary>
        /// <param name="tbNodeName">Элемент управления, содержащий название выбранного элемента.</param>
        /// <param name="tbElementValue">Элемент управления, содержащий значение выбранного элемента.</param>
        public void RefreshElement(TextBox tbNodeName, TextBox tbElementValue)
        {
            if (XmlMap.SelectedNode != null)
            {
                tbNodeName.Text = XmlMap.SelectedNode.Text;
                _nodeName = XmlMap.SelectedNode.Text;
                CurrentElement = Document.Descendants(XmlMap.SelectedNode.Text).FirstOrDefault();

                if (CurrentElement != null)
                {
                    if (CurrentElement.HasElements)
                    {
                        tbElementValue.Enabled = false;
                        tbElementValue.Clear();
                    }
                    else
                    {
                        tbElementValue.Enabled = true;
                        tbElementValue.Text = CurrentElement.Value;
                    }
                }
            }
        }
        /// <summary>
        /// Добавляет новый аттрибут к выбранному элементу.
        /// </summary>
        /// <param name="view">Элемент управления, содержащий таблицу аттрибутов выбранного элемента.</param>
        public void AddAttribute(DataGridView view)
        {
            if (CurrentElement != null)
            {
                var attrCount = CurrentElement.Attributes().Count();
                var attrName = DEFAULT_ATTRIBUTE_NAME + (attrCount + 1);
                var attr = new XAttribute(attrName, string.Empty);
                CurrentElement.Add(attr);
                view.Rows.Add(attrName);
            }
        }
        /// <summary>
        /// Удаляет аттрибут из выбранного элемента.
        /// </summary>
        /// <param name="attrName">Название аттрибута.</param>
        public void RemoveAttribute(string attrName)
        {
            if (CurrentElement != null)
            {
                CurrentElement.Attribute(attrName).Remove();
            }
        }
        /// <summary>
        /// Проверяет, является ли заданное имя допустимым в качестве имени элемента
        /// </summary>
        /// <param name="name">Название элемента</param>
        /// <returns>Возвращает true, если имя подходит для названия элемента</returns>
        private static bool IsNameValid(string name)
        {
            return !Char.IsDigit(name[0]);
            //return !(string.IsNullOrEmpty(XmlMap.SelectedNode.Text) && Char.IsDigit(name[0]));
        }
        /// <summary>
        /// Задает значение активного элемента в XML модели заданным значением текстового поля.
        /// </summary>
        /// <param name="tbElementValue">Элемент управления, который содержит значение элемента.</param>
        public void SetElementValue(TextBox tbElementValue)
        {
            if (CurrentElement != null && XmlMap.SelectedNode != null)
            {
                CurrentElement.Value = tbElementValue.Text;
            }
        }
        /// <summary>
        /// Задает название активного элемента в XML модели заданным значением текстового поля.
        /// </summary>
        /// <param name="tbNodeName">Элемент управления, который содержит название элемента.</param>
        public void SetElementName(TextBox tbNodeName)
        {
            if (XmlMap.SelectedNode == null) return;

            if (CurrentElement != null && IsNameValid(XmlMap.SelectedNode.Text))
            {
                CurrentElement.Name = XmlMap.SelectedNode.Text = tbNodeName.Text;
            }
        }
        /// <summary>
        /// Задает имя указанного аттрибута указанным значением.
        /// </summary>
        /// <param name="attrName">Текущее имя аттрибута.</param>
        /// <param name="newName">Новое имя аттрибута.</param>
        public void SetAtributeName(string attrName, string newName)
        {
            if (IsNameValid(newName))
            {
                if (CurrentElement != null)
                {
                    var attr = CurrentElement.Attribute(attrName);
                    if (attr != null)
                    {
                        attr.Remove();
                        CurrentElement.Add(new XAttribute(newName, attr.Value));
                    }
                }
            }
        }
        /// <summary>
        /// Задает значение указанного аттрибута указанным значением.
        /// </summary>
        /// <param name="attrName">Имя аттрибута.</param>
        /// <param name="newValue">Новое значение аттрибута.</param>
        public void SetAttributeValue(string attrName, string newValue)
        {
            if (CurrentElement != null)
            {
                var attr = CurrentElement.Attribute(attrName);
                attr.Value = newValue;
            }
        }
        /// <summary>
        /// Обновляет XML модель, распознавая указанный XML текст.
        /// </summary>
        /// <param name="xmlText">XML текст документа.</param>
        /// <returns>Если XML документ обновлен, возвращает true.</returns>
        public bool ParseXmlDocument(string xmlText)
        {
            try
            {
                Document = XDocument.Parse(xmlText);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Обновляет XML модель, распознавая указанный XML текст и обновляет XML дерево документа.
        /// </summary>
        /// <param name="xml">XML текст документа.</param>
        /// <returns>Если XML документ обновлен, возвращает true.</returns>
        public bool UpdateXmlDocument(string xml)
        {
            try
            {
                var currentElement = CurrentElement;
                Document = XDocument.Parse(xml);
                if (currentElement != null)
                    CurrentElement = Document.Descendants(currentElement.Name).FirstOrDefault();
                Document.Changed += XmlDocument_Changed;
                var selectedNode = XmlMap.SelectedNode;
                XmlMap.Nodes.Clear();
                UpdateTree(Document.Root, XmlMap.Nodes);
                XmlMap.ExpandAll();
                XmlMap.SelectedNode = selectedNode;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Обновляет XML дерево.
        /// </summary>
        /// <param name="element">Обновляемый элемент документа.</param>
        /// <param name="node">Коллекция элементов XML дерева.</param>
        public void UpdateTree(XElement element, TreeNodeCollection node)
        {
            node.Add(element.Name.ToString());
            foreach (var child in element.Elements())
            {
                if (child.HasElements) UpdateTree(child, node[node.Count - 1].Nodes);
                else node[node.Count - 1].Nodes.Add(child.Name.ToString());
            }
        }
        /// <summary>
        /// Обновляет содержимое XML текста при изменении XML модели.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void XmlDocument_Changed(object sender, EventArgs e)
        {
            _xmlEdit.Text = Document.ToString();
        }
    }
}