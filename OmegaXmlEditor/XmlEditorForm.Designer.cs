namespace OmegaXmlEditor
{
     partial class XmlEditorForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            this.tvXmlMap = new System.Windows.Forms.TreeView();
            this.cmsTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miInsertElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNodeName = new System.Windows.Forms.TextBox();
            this.lblElementName = new System.Windows.Forms.Label();
            this.lblDocumentStructure = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbElementValue = new System.Windows.Forms.TextBox();
            this.lblElementValue = new System.Windows.Forms.Label();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.dgvElementAttributes = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAttr = new System.Windows.Forms.Button();
            this.btnRemoveAttr = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scXmlEdit = new ScintillaNET.Scintilla();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmsTreeMenu.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementAttributes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scXmlEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tvXmlMap
            // 
            this.tvXmlMap.ContextMenuStrip = this.cmsTreeMenu;
            this.tvXmlMap.HideSelection = false;
            this.tvXmlMap.Location = new System.Drawing.Point(12, 60);
            this.tvXmlMap.Name = "tvXmlMap";
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.tvXmlMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvXmlMap.Size = new System.Drawing.Size(195, 465);
            this.tvXmlMap.TabIndex = 0;
            this.tvXmlMap.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvXmlMap_NodeMouseClick);
            // 
            // cmsTreeMenu
            // 
            this.cmsTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddToolStripMenuItem,
            this.miRemoveToolStripMenuItem,
            this.miInsertElementToolStripMenuItem});
            this.cmsTreeMenu.Name = "cmsTreeMenu";
            this.cmsTreeMenu.Size = new System.Drawing.Size(172, 70);
            this.cmsTreeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTreeMenu_Opening);
            // 
            // miAddToolStripMenuItem
            // 
            this.miAddToolStripMenuItem.Name = "miAddToolStripMenuItem";
            this.miAddToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.miAddToolStripMenuItem.Text = "Добавить";
            this.miAddToolStripMenuItem.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // miRemoveToolStripMenuItem
            // 
            this.miRemoveToolStripMenuItem.Name = "miRemoveToolStripMenuItem";
            this.miRemoveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.miRemoveToolStripMenuItem.Text = "Удалить";
            this.miRemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveElement_Click);
            // 
            // miInsertElementToolStripMenuItem
            // 
            this.miInsertElementToolStripMenuItem.Name = "miInsertElementToolStripMenuItem";
            this.miInsertElementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.miInsertElementToolStripMenuItem.Text = "Вставить элемент";
            this.miInsertElementToolStripMenuItem.Click += new System.EventHandler(this.InsertElement_Click);
            // 
            // tbNodeName
            // 
            this.tbNodeName.Location = new System.Drawing.Point(730, 60);
            this.tbNodeName.Name = "tbNodeName";
            this.tbNodeName.Size = new System.Drawing.Size(195, 20);
            this.tbNodeName.TabIndex = 1;
            this.tbNodeName.TextChanged += new System.EventHandler(this.tbNodeName_TextChanged);
            this.tbNodeName.Leave += new System.EventHandler(this.tbNodeName_Leave);
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Location = new System.Drawing.Point(727, 41);
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(112, 13);
            this.lblElementName.TabIndex = 2;
            this.lblElementName.Text = "Название элемента:";
            // 
            // lblDocumentStructure
            // 
            this.lblDocumentStructure.AutoSize = true;
            this.lblDocumentStructure.Location = new System.Drawing.Point(12, 36);
            this.lblDocumentStructure.Name = "lblDocumentStructure";
            this.lblDocumentStructure.Size = new System.Drawing.Size(86, 13);
            this.lblDocumentStructure.TabIndex = 3;
            this.lblDocumentStructure.Text = "Структура XML:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(246, 31);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // tbElementValue
            // 
            this.tbElementValue.Location = new System.Drawing.Point(730, 109);
            this.tbElementValue.Name = "tbElementValue";
            this.tbElementValue.Size = new System.Drawing.Size(195, 20);
            this.tbElementValue.TabIndex = 8;
            this.tbElementValue.TextChanged += new System.EventHandler(this.tbElementValue_TextChanged);
            this.tbElementValue.Leave += new System.EventHandler(this.tbElementValue_Leave);
            // 
            // lblElementValue
            // 
            this.lblElementValue.AutoSize = true;
            this.lblElementValue.Location = new System.Drawing.Point(727, 93);
            this.lblElementValue.Name = "lblElementValue";
            this.lblElementValue.Size = new System.Drawing.Size(110, 13);
            this.lblElementValue.TabIndex = 9;
            this.lblElementValue.Text = "Значение элемента:";
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.dgvElementAttributes);
            this.gbAttributes.Controls.Add(this.btnAddAttr);
            this.gbAttributes.Controls.Add(this.btnRemoveAttr);
            this.gbAttributes.Location = new System.Drawing.Point(730, 137);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(195, 388);
            this.gbAttributes.TabIndex = 10;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Аттрибуты";
            // 
            // dgvElementAttributes
            // 
            this.dgvElementAttributes.AllowUserToAddRows = false;
            this.dgvElementAttributes.AllowUserToDeleteRows = false;
            this.dgvElementAttributes.AllowUserToResizeColumns = false;
            this.dgvElementAttributes.AllowUserToResizeRows = false;
            this.dgvElementAttributes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvElementAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvElementAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cValue});
            this.dgvElementAttributes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvElementAttributes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvElementAttributes.Location = new System.Drawing.Point(7, 20);
            this.dgvElementAttributes.MultiSelect = false;
            this.dgvElementAttributes.Name = "dgvElementAttributes";
            this.dgvElementAttributes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvElementAttributes.RowHeadersVisible = false;
            this.dgvElementAttributes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvElementAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElementAttributes.Size = new System.Drawing.Size(182, 333);
            this.dgvElementAttributes.TabIndex = 2;
            this.dgvElementAttributes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_CellEndEdit);
            this.dgvElementAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_CellValueChanged);
            this.dgvElementAttributes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_RowEnter);
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            // 
            // cValue
            // 
            this.cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cValue.HeaderText = "Value";
            this.cValue.Name = "cValue";
            // 
            // btnAddAttr
            // 
            this.btnAddAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAttr.Location = new System.Drawing.Point(6, 359);
            this.btnAddAttr.Name = "btnAddAttr";
            this.btnAddAttr.Size = new System.Drawing.Size(89, 23);
            this.btnAddAttr.TabIndex = 1;
            this.btnAddAttr.Text = "Добавить";
            this.btnAddAttr.UseVisualStyleBackColor = true;
            this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
            // 
            // btnRemoveAttr
            // 
            this.btnRemoveAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAttr.Location = new System.Drawing.Point(100, 359);
            this.btnRemoveAttr.Name = "btnRemoveAttr";
            this.btnRemoveAttr.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveAttr.TabIndex = 0;
            this.btnRemoveAttr.Text = "Удалить";
            this.btnRemoveAttr.UseVisualStyleBackColor = true;
            this.btnRemoveAttr.Click += new System.EventHandler(this.btnRemoveAttr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // scXmlEdit
            // 
            this.scXmlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scXmlEdit.ConfigurationManager.Language = "xml";
            this.scXmlEdit.Folding.Flags = ScintillaNET.FoldFlag.Box;
            this.scXmlEdit.Indentation.ShowGuides = true;
            this.scXmlEdit.Indentation.SmartIndentType = ScintillaNET.SmartIndent.Simple;
            this.scXmlEdit.Lexing.Lexer = ScintillaNET.Lexer.Xml;
            this.scXmlEdit.Lexing.LexerName = "xml";
            this.scXmlEdit.Lexing.LineCommentPrefix = "";
            this.scXmlEdit.Lexing.StreamCommentPrefix = "";
            this.scXmlEdit.Lexing.StreamCommentSufix = "";
            this.scXmlEdit.LineWrapping.Mode = ScintillaNET.LineWrappingMode.Char;
            this.scXmlEdit.Location = new System.Drawing.Point(213, 60);
            this.scXmlEdit.Margins.Left = 0;
            this.scXmlEdit.Margins.Margin0.Width = 30;
            this.scXmlEdit.Margins.Margin1.Width = 0;
            this.scXmlEdit.Margins.Margin2.Width = 20;
            this.scXmlEdit.Name = "scXmlEdit";
            this.scXmlEdit.Selection.Mode = ScintillaNET.SelectionMode.Rectangle;
            this.scXmlEdit.Size = new System.Drawing.Size(511, 465);
            this.scXmlEdit.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.scXmlEdit.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scXmlEdit.TabIndex = 13;
            this.scXmlEdit.Whitespace.Mode = ScintillaNET.WhitespaceMode.VisibleAfterIndent;
            this.scXmlEdit.TextChanged += new System.EventHandler(this.scXmlEdit_TextChanged);
            this.scXmlEdit.Leave += new System.EventHandler(this.scXmlEdit_Leave);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(175, 31);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(65, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Вставить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.InsertElement_Click);
            // 
            // XmlEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 537);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.scXmlEdit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.lblElementValue);
            this.Controls.Add(this.tbElementValue);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDocumentStructure);
            this.Controls.Add(this.lblElementName);
            this.Controls.Add(this.tbNodeName);
            this.Controls.Add(this.tvXmlMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XmlEditorForm";
            this.Text = "Omega XML Editor";
            this.cmsTreeMenu.ResumeLayout(false);
            this.gbAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementAttributes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scXmlEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvXmlMap;
        private System.Windows.Forms.TextBox tbNodeName;
        private System.Windows.Forms.Label lblElementName;
        private System.Windows.Forms.Label lblDocumentStructure;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ContextMenuStrip cmsTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem miAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miInsertElementToolStripMenuItem;
        private System.Windows.Forms.TextBox tbElementValue;
        private System.Windows.Forms.Label lblElementValue;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.Button btnAddAttr;
        private System.Windows.Forms.Button btnRemoveAttr;
        private System.Windows.Forms.DataGridView dgvElementAttributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private ScintillaNET.Scintilla scXmlEdit;
        private System.Windows.Forms.Button btnInsert;
    }

     partial class ПродолжениеXmlEditorForm
     {
         /// <summary>
         /// Требуется переменная конструктора.
         /// </summary>
         private System.ComponentModel.IContainer components = null;

         /// <summary>
         /// Освободить все используемые ресурсы.
         /// </summary>
         /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
             {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }

         #region Код, автоматически созданный конструктором форм Windows

         /// <summary>
         /// Обязательный метод для поддержки конструктора - не изменяйте
         /// содержимое данного метода при помощи редактора кода.
         /// </summary>
         private void InitializeComponent()
         {
             this.components = new System.ComponentModel.Container();
             System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
             this.tvXmlMap = new System.Windows.Forms.TreeView();
             this.cmsTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
             this.miAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.miRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.miInsertElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.tbNodeName = new System.Windows.Forms.TextBox();
             this.lblElementName = new System.Windows.Forms.Label();
             this.lblDocumentStructure = new System.Windows.Forms.Label();
             this.btnAdd = new System.Windows.Forms.Button();
             this.btnRemove = new System.Windows.Forms.Button();
             this.tbElementValue = new System.Windows.Forms.TextBox();
             this.lblElementValue = new System.Windows.Forms.Label();
             this.gbAttributes = new System.Windows.Forms.GroupBox();
             this.dgvElementAttributes = new System.Windows.Forms.DataGridView();
             this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
             this.btnAddAttr = new System.Windows.Forms.Button();
             this.btnRemoveAttr = new System.Windows.Forms.Button();
             this.menuStrip1 = new System.Windows.Forms.MenuStrip();
             this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
             this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.scXmlEdit = new ScintillaNET.Scintilla();
             this.btnInsert = new System.Windows.Forms.Button();
             this.cmsTreeMenu.SuspendLayout();
             this.gbAttributes.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.dgvElementAttributes)).BeginInit();
             this.menuStrip1.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.scXmlEdit)).BeginInit();
             this.SuspendLayout();
             // 
             // tvXmlMap
             // 
             this.tvXmlMap.ContextMenuStrip = this.cmsTreeMenu;
             this.tvXmlMap.HideSelection = false;
             this.tvXmlMap.Location = new System.Drawing.Point(12, 60);
             this.tvXmlMap.Name = "tvXmlMap";
             treeNode1.Name = "Root";
             treeNode1.Text = "Root";
             this.tvXmlMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
             this.tvXmlMap.Size = new System.Drawing.Size(195, 465);
             this.tvXmlMap.TabIndex = 0;
             this.tvXmlMap.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvXmlMap_NodeMouseClick);
             // 
             // cmsTreeMenu
             // 
             this.cmsTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddToolStripMenuItem,
            this.miRemoveToolStripMenuItem,
            this.miInsertElementToolStripMenuItem});
             this.cmsTreeMenu.Name = "cmsTreeMenu";
             this.cmsTreeMenu.Size = new System.Drawing.Size(172, 70);
             this.cmsTreeMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTreeMenu_Opening);
             // 
             // miAddToolStripMenuItem
             // 
             this.miAddToolStripMenuItem.Name = "miAddToolStripMenuItem";
             this.miAddToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
             this.miAddToolStripMenuItem.Text = "Добавить";
             this.miAddToolStripMenuItem.Click += new System.EventHandler(this.AddElement_Click);
             // 
             // miRemoveToolStripMenuItem
             // 
             this.miRemoveToolStripMenuItem.Name = "miRemoveToolStripMenuItem";
             this.miRemoveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
             this.miRemoveToolStripMenuItem.Text = "Удалить";
             this.miRemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveElement_Click);
             // 
             // miInsertElementToolStripMenuItem
             // 
             this.miInsertElementToolStripMenuItem.Name = "miInsertElementToolStripMenuItem";
             this.miInsertElementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
             this.miInsertElementToolStripMenuItem.Text = "Вставить элемент";
             this.miInsertElementToolStripMenuItem.Click += new System.EventHandler(this.InsertElement_Click);
             // 
             // tbNodeName
             // 
             this.tbNodeName.Location = new System.Drawing.Point(730, 60);
             this.tbNodeName.Name = "tbNodeName";
             this.tbNodeName.Size = new System.Drawing.Size(195, 20);
             this.tbNodeName.TabIndex = 1;
             this.tbNodeName.TextChanged += new System.EventHandler(this.tbNodeName_TextChanged);
             this.tbNodeName.Leave += new System.EventHandler(this.tbNodeName_Leave);
             // 
             // lblElementName
             // 
             this.lblElementName.AutoSize = true;
             this.lblElementName.Location = new System.Drawing.Point(727, 41);
             this.lblElementName.Name = "lblElementName";
             this.lblElementName.Size = new System.Drawing.Size(112, 13);
             this.lblElementName.TabIndex = 2;
             this.lblElementName.Text = "Название элемента:";
             // 
             // lblDocumentStructure
             // 
             this.lblDocumentStructure.AutoSize = true;
             this.lblDocumentStructure.Location = new System.Drawing.Point(12, 36);
             this.lblDocumentStructure.Name = "lblDocumentStructure";
             this.lblDocumentStructure.Size = new System.Drawing.Size(86, 13);
             this.lblDocumentStructure.TabIndex = 3;
             this.lblDocumentStructure.Text = "Структура XML:";
             // 
             // btnAdd
             // 
             this.btnAdd.Location = new System.Drawing.Point(104, 31);
             this.btnAdd.Name = "btnAdd";
             this.btnAdd.Size = new System.Drawing.Size(65, 23);
             this.btnAdd.TabIndex = 4;
             this.btnAdd.Text = "Добавить";
             this.btnAdd.UseVisualStyleBackColor = true;
             // 
             // btnRemove
             // 
             this.btnRemove.Location = new System.Drawing.Point(246, 31);
             this.btnRemove.Name = "btnRemove";
             this.btnRemove.Size = new System.Drawing.Size(65, 23);
             this.btnRemove.TabIndex = 5;
             this.btnRemove.Text = "Удалить";
             this.btnRemove.UseVisualStyleBackColor = true;
             // 
             // tbElementValue
             // 
             this.tbElementValue.Location = new System.Drawing.Point(730, 109);
             this.tbElementValue.Name = "tbElementValue";
             this.tbElementValue.Size = new System.Drawing.Size(195, 20);
             this.tbElementValue.TabIndex = 8;
             this.tbElementValue.TextChanged += new System.EventHandler(this.tbElementValue_TextChanged);
             this.tbElementValue.Leave += new System.EventHandler(this.tbElementValue_Leave);
             // 
             // lblElementValue
             // 
             this.lblElementValue.AutoSize = true;
             this.lblElementValue.Location = new System.Drawing.Point(727, 93);
             this.lblElementValue.Name = "lblElementValue";
             this.lblElementValue.Size = new System.Drawing.Size(110, 13);
             this.lblElementValue.TabIndex = 9;
             this.lblElementValue.Text = "Значение элемента:";
             // 
             // gbAttributes
             // 
             this.gbAttributes.Controls.Add(this.dgvElementAttributes);
             this.gbAttributes.Controls.Add(this.btnAddAttr);
             this.gbAttributes.Controls.Add(this.btnRemoveAttr);
             this.gbAttributes.Location = new System.Drawing.Point(730, 137);
             this.gbAttributes.Name = "gbAttributes";
             this.gbAttributes.Size = new System.Drawing.Size(195, 388);
             this.gbAttributes.TabIndex = 10;
             this.gbAttributes.TabStop = false;
             this.gbAttributes.Text = "Аттрибуты";
             // 
             // dgvElementAttributes
             // 
             this.dgvElementAttributes.AllowUserToAddRows = false;
             this.dgvElementAttributes.AllowUserToDeleteRows = false;
             this.dgvElementAttributes.AllowUserToResizeColumns = false;
             this.dgvElementAttributes.AllowUserToResizeRows = false;
             this.dgvElementAttributes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
             this.dgvElementAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
             this.dgvElementAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cValue});
             this.dgvElementAttributes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
             this.dgvElementAttributes.GridColor = System.Drawing.SystemColors.Control;
             this.dgvElementAttributes.Location = new System.Drawing.Point(7, 20);
             this.dgvElementAttributes.MultiSelect = false;
             this.dgvElementAttributes.Name = "dgvElementAttributes";
             this.dgvElementAttributes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
             this.dgvElementAttributes.RowHeadersVisible = false;
             this.dgvElementAttributes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
             this.dgvElementAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
             this.dgvElementAttributes.Size = new System.Drawing.Size(182, 333);
             this.dgvElementAttributes.TabIndex = 2;
             this.dgvElementAttributes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_CellEndEdit);
             this.dgvElementAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_CellValueChanged);
             this.dgvElementAttributes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementAttributes_RowEnter);
             // 
             // cName
             // 
             this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
             this.cName.HeaderText = "Name";
             this.cName.Name = "cName";
             // 
             // cValue
             // 
             this.cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
             this.cValue.HeaderText = "Value";
             this.cValue.Name = "cValue";
             // 
             // btnAddAttr
             // 
             this.btnAddAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
             this.btnAddAttr.Location = new System.Drawing.Point(6, 359);
             this.btnAddAttr.Name = "btnAddAttr";
             this.btnAddAttr.Size = new System.Drawing.Size(89, 23);
             this.btnAddAttr.TabIndex = 1;
             this.btnAddAttr.Text = "Добавить";
             this.btnAddAttr.UseVisualStyleBackColor = true;
             this.btnAddAttr.Click += new System.EventHandler(this.btnAddAttr_Click);
             // 
             // btnRemoveAttr
             // 
             this.btnRemoveAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
             this.btnRemoveAttr.Location = new System.Drawing.Point(100, 359);
             this.btnRemoveAttr.Name = "btnRemoveAttr";
             this.btnRemoveAttr.Size = new System.Drawing.Size(89, 23);
             this.btnRemoveAttr.TabIndex = 0;
             this.btnRemoveAttr.Text = "Удалить";
             this.btnRemoveAttr.UseVisualStyleBackColor = true;
             this.btnRemoveAttr.Click += new System.EventHandler(this.btnRemoveAttr_Click);
             // 
             // menuStrip1
             // 
             this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
             this.menuStrip1.Location = new System.Drawing.Point(0, 0);
             this.menuStrip1.Name = "menuStrip1";
             this.menuStrip1.Size = new System.Drawing.Size(937, 24);
             this.menuStrip1.TabIndex = 11;
             this.menuStrip1.Text = "menuStrip1";
             // 
             // toolStripMenuItem1
             // 
             this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.выходToolStripMenuItem});
             this.toolStripMenuItem1.Name = "toolStripMenuItem1";
             this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
             this.toolStripMenuItem1.Text = "Файл";
             // 
             // OpenToolStripMenuItem
             // 
             this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
             this.OpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
             this.OpenToolStripMenuItem.Text = "Открыть";
             this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
             // 
             // SaveToolStripMenuItem
             // 
             this.SaveToolStripMenuItem.Enabled = false;
             this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
             this.SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
             this.SaveToolStripMenuItem.Text = "Сохранить";
             this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
             // 
             // SaveAsToolStripMenuItem
             // 
             this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
             this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
             this.SaveAsToolStripMenuItem.Text = "Сохранить как...";
             this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
             // 
             // экспортToolStripMenuItem
             // 
             this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
             this.экспортToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
             this.экспортToolStripMenuItem.Text = "Экспорт";
             this.экспортToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
             // 
             // выходToolStripMenuItem
             // 
             this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
             this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
             this.выходToolStripMenuItem.Text = "Выход";
             this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
             // 
             // scXmlEdit
             // 
             this.scXmlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             this.scXmlEdit.ConfigurationManager.Language = "xml";
             this.scXmlEdit.Folding.Flags = ScintillaNET.FoldFlag.Box;
             this.scXmlEdit.Indentation.ShowGuides = true;
             this.scXmlEdit.Indentation.SmartIndentType = ScintillaNET.SmartIndent.Simple;
             this.scXmlEdit.Lexing.Lexer = ScintillaNET.Lexer.Xml;
             this.scXmlEdit.Lexing.LexerName = "xml";
             this.scXmlEdit.Lexing.LineCommentPrefix = "";
             this.scXmlEdit.Lexing.StreamCommentPrefix = "";
             this.scXmlEdit.Lexing.StreamCommentSufix = "";
             this.scXmlEdit.LineWrapping.Mode = ScintillaNET.LineWrappingMode.Char;
             this.scXmlEdit.Location = new System.Drawing.Point(213, 60);
             this.scXmlEdit.Margins.Left = 0;
             this.scXmlEdit.Margins.Margin0.Width = 30;
             this.scXmlEdit.Margins.Margin1.Width = 0;
             this.scXmlEdit.Margins.Margin2.Width = 20;
             this.scXmlEdit.Name = "scXmlEdit";
             this.scXmlEdit.Selection.Mode = ScintillaNET.SelectionMode.Rectangle;
             this.scXmlEdit.Size = new System.Drawing.Size(511, 465);
             this.scXmlEdit.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
             this.scXmlEdit.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
             this.scXmlEdit.TabIndex = 13;
             this.scXmlEdit.Whitespace.Mode = ScintillaNET.WhitespaceMode.VisibleAfterIndent;
             this.scXmlEdit.TextChanged += new System.EventHandler(this.scXmlEdit_TextChanged);
             this.scXmlEdit.Leave += new System.EventHandler(this.scXmlEdit_Leave);
             // 
             // btnInsert
             // 
             this.btnInsert.Location = new System.Drawing.Point(175, 31);
             this.btnInsert.Name = "btnInsert";
             this.btnInsert.Size = new System.Drawing.Size(65, 23);
             this.btnInsert.TabIndex = 14;
             this.btnInsert.Text = "Вставить";
             this.btnInsert.UseVisualStyleBackColor = true;
             this.btnInsert.Click += new System.EventHandler(this.InsertElement_Click);
             // 
             // ПродолжениеXmlEditorForm
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(937, 537);
             this.Controls.Add(this.btnInsert);
             this.Controls.Add(this.scXmlEdit);
             this.Controls.Add(this.menuStrip1);
             this.Controls.Add(this.gbAttributes);
             this.Controls.Add(this.lblElementValue);
             this.Controls.Add(this.tbElementValue);
             this.Controls.Add(this.btnRemove);
             this.Controls.Add(this.btnAdd);
             this.Controls.Add(this.lblDocumentStructure);
             this.Controls.Add(this.lblElementName);
             this.Controls.Add(this.tbNodeName);
             this.Controls.Add(this.tvXmlMap);
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
             this.MainMenuStrip = this.menuStrip1;
             this.Name = "ПродолжениеXmlEditorForm";
             this.Text = "Omega XML Editor";
             this.cmsTreeMenu.ResumeLayout(false);
             this.gbAttributes.ResumeLayout(false);
             ((System.ComponentModel.ISupportInitialize)(this.dgvElementAttributes)).EndInit();
             this.menuStrip1.ResumeLayout(false);
             this.menuStrip1.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.scXmlEdit)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         #endregion

         private System.Windows.Forms.TreeView tvXmlMap;
         private System.Windows.Forms.TextBox tbNodeName;
         private System.Windows.Forms.Label lblElementName;
         private System.Windows.Forms.Label lblDocumentStructure;
         private System.Windows.Forms.Button btnAdd;
         private System.Windows.Forms.Button btnRemove;
         private System.Windows.Forms.ContextMenuStrip cmsTreeMenu;
         private System.Windows.Forms.ToolStripMenuItem miAddToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem miRemoveToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem miInsertElementToolStripMenuItem;
         private System.Windows.Forms.TextBox tbElementValue;
         private System.Windows.Forms.Label lblElementValue;
         private System.Windows.Forms.GroupBox gbAttributes;
         private System.Windows.Forms.Button btnAddAttr;
         private System.Windows.Forms.Button btnRemoveAttr;
         private System.Windows.Forms.DataGridView dgvElementAttributes;
         private System.Windows.Forms.DataGridViewTextBoxColumn cName;
         private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
         private System.Windows.Forms.MenuStrip menuStrip1;
         private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
         private ScintillaNET.Scintilla scXmlEdit;
         private System.Windows.Forms.Button btnInsert;
     }
}

