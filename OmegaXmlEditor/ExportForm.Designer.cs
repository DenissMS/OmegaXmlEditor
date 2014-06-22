namespace OmegaXmlEditor
{
   partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.rbXls = new System.Windows.Forms.RadioButton();
            this.rbCsv = new System.Windows.Forms.RadioButton();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbPreview.SuspendLayout();
            this.gbFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(317, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(397, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.rtbPreview);
            this.gbPreview.Location = new System.Drawing.Point(185, 44);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(286, 219);
            this.gbPreview.TabIndex = 2;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Предпросмотр";
            // 
            // rtbPreview
            // 
            this.rtbPreview.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPreview.Location = new System.Drawing.Point(7, 20);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.Size = new System.Drawing.Size(273, 193);
            this.rtbPreview.TabIndex = 0;
            this.rtbPreview.Text = "";
            // 
            // gbFormat
            // 
            this.gbFormat.Controls.Add(this.rbJson);
            this.gbFormat.Controls.Add(this.rbXls);
            this.gbFormat.Controls.Add(this.rbCsv);
            this.gbFormat.Location = new System.Drawing.Point(12, 44);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(167, 219);
            this.gbFormat.TabIndex = 3;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "Формат";
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Location = new System.Drawing.Point(7, 66);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(81, 17);
            this.rbJson.TabIndex = 2;
            this.rbJson.TabStop = true;
            this.rbJson.Text = "JSON(.json)";
            this.rbJson.UseVisualStyleBackColor = true;
            this.rbJson.CheckedChanged += new System.EventHandler(this.Format_CheckedChanged);
            // 
            // rbXls
            // 
            this.rbXls.AutoSize = true;
            this.rbXls.Location = new System.Drawing.Point(7, 43);
            this.rbXls.Name = "rbXls";
            this.rbXls.Size = new System.Drawing.Size(89, 17);
            this.rbXls.TabIndex = 1;
            this.rbXls.TabStop = true;
            this.rbXls.Text = "Таблица(.xls)";
            this.rbXls.UseVisualStyleBackColor = true;
            this.rbXls.CheckedChanged += new System.EventHandler(this.Format_CheckedChanged);
            // 
            // rbCsv
            // 
            this.rbCsv.AutoSize = true;
            this.rbCsv.Location = new System.Drawing.Point(7, 20);
            this.rbCsv.Name = "rbCsv";
            this.rbCsv.Size = new System.Drawing.Size(94, 17);
            this.rbCsv.TabIndex = 0;
            this.rbCsv.TabStop = true;
            this.rbCsv.Text = "Таблица(.csv)";
            this.rbCsv.UseVisualStyleBackColor = true;
            this.rbCsv.CheckedChanged += new System.EventHandler(this.Format_CheckedChanged);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(94, 14);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(296, 20);
            this.tbFilePath.TabIndex = 4;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(11, 17);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(77, 13);
            this.lblFilePath.TabIndex = 5;
            this.lblFilePath.Text = "Путь к файлу:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(396, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Обзор...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.gbFormat);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExportForm";
            this.Text = "Экспорт документа";
            this.gbPreview.ResumeLayout(false);
            this.gbFormat.ResumeLayout(false);
            this.gbFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.RadioButton rbXls;
        private System.Windows.Forms.RadioButton rbCsv;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbPreview;
    }
}