namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_of_document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_off = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveFile = new System.Windows.Forms.ToolStripButton();
            this.ExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportToJSON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddDocument = new System.Windows.Forms.ToolStripButton();
            this.RedactionDocument = new System.Windows.Forms.ToolStripButton();
            this.DeleteDocument = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_of_document,
            this.number_of_document,
            this.date_on,
            this.agent,
            this.Document,
            this.date_off,
            this.sum_on,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 648);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_of_document
            // 
            this.ID_of_document.HeaderText = "№ з/п";
            this.ID_of_document.Name = "ID_of_document";
            this.ID_of_document.ReadOnly = true;
            this.ID_of_document.Width = 50;
            // 
            // number_of_document
            // 
            this.number_of_document.HeaderText = "№ договору";
            this.number_of_document.Name = "number_of_document";
            this.number_of_document.ReadOnly = true;
            this.number_of_document.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // date_on
            // 
            this.date_on.HeaderText = "Дата договору";
            this.date_on.Name = "date_on";
            this.date_on.ReadOnly = true;
            this.date_on.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // agent
            // 
            this.agent.HeaderText = "Контрагент";
            this.agent.Name = "agent";
            this.agent.ReadOnly = true;
            this.agent.Width = 200;
            // 
            // Document
            // 
            this.Document.HeaderText = "Дата початку договору";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            // 
            // date_off
            // 
            this.date_off.HeaderText = "Дата закінчення";
            this.date_off.Name = "date_off";
            this.date_off.ReadOnly = true;
            this.date_off.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sum_on
            // 
            this.sum_on.HeaderText = "Сума, грн";
            this.sum_on.Name = "sum_on";
            this.sum_on.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Предмет договору";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFile,
            this.ExportToExcel,
            this.toolStripSeparator3,
            this.ImportToJSON,
            this.toolStripSeparator1,
            this.AddDocument,
            this.RedactionDocument,
            this.DeleteDocument,
            this.toolStripSeparator2,
            this.Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 85);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // SaveFile
            // 
            this.SaveFile.AutoSize = false;
            this.SaveFile.AutoToolTip = false;
            this.SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(64, 64);
            this.SaveFile.Text = "Зберегти у файл";
            this.SaveFile.ToolTipText = "Зберегти файл";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.AutoSize = false;
            this.ExportToExcel.AutoToolTip = false;
            this.ExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcel.Image")));
            this.ExportToExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(67, 67);
            this.ExportToExcel.Text = "Експорт у Excel";
            this.ExportToExcel.ToolTipText = "Експорт у Excel";
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 85);
            // 
            // ImportToJSON
            // 
            this.ImportToJSON.AutoSize = false;
            this.ImportToJSON.AutoToolTip = false;
            this.ImportToJSON.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImportToJSON.Image = ((System.Drawing.Image)(resources.GetObject("ImportToJSON.Image")));
            this.ImportToJSON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImportToJSON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportToJSON.Name = "ImportToJSON";
            this.ImportToJSON.Size = new System.Drawing.Size(67, 67);
            this.ImportToJSON.Text = "Імпортувати з JSON";
            this.ImportToJSON.ToolTipText = "Імпортувати з JSON";
            this.ImportToJSON.Click += new System.EventHandler(this.ImportToJSON_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 85);
            // 
            // AddDocument
            // 
            this.AddDocument.AutoSize = false;
            this.AddDocument.AutoToolTip = false;
            this.AddDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddDocument.Image = ((System.Drawing.Image)(resources.GetObject("AddDocument.Image")));
            this.AddDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDocument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDocument.Name = "AddDocument";
            this.AddDocument.Size = new System.Drawing.Size(67, 67);
            this.AddDocument.Text = "Додати документ";
            this.AddDocument.ToolTipText = "Додати документ";
            this.AddDocument.Click += new System.EventHandler(this.AddDocument_Click);
            // 
            // RedactionDocument
            // 
            this.RedactionDocument.AutoSize = false;
            this.RedactionDocument.AutoToolTip = false;
            this.RedactionDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedactionDocument.Image = ((System.Drawing.Image)(resources.GetObject("RedactionDocument.Image")));
            this.RedactionDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RedactionDocument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RedactionDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedactionDocument.Name = "RedactionDocument";
            this.RedactionDocument.Size = new System.Drawing.Size(64, 64);
            this.RedactionDocument.Text = "Редагувати запис";
            this.RedactionDocument.ToolTipText = "Редагувати";
            this.RedactionDocument.Click += new System.EventHandler(this.RedactionDocument_Click);
            // 
            // DeleteDocument
            // 
            this.DeleteDocument.AutoSize = false;
            this.DeleteDocument.AutoToolTip = false;
            this.DeleteDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteDocument.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDocument.Image")));
            this.DeleteDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteDocument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteDocument.Name = "DeleteDocument";
            this.DeleteDocument.Size = new System.Drawing.Size(64, 67);
            this.DeleteDocument.Text = "Видалити запис";
            this.DeleteDocument.ToolTipText = "Видалити запис";
            this.DeleteDocument.Click += new System.EventHandler(this.DeleteDocument_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 85);
            // 
            // Exit
            // 
            this.Exit.AutoSize = false;
            this.Exit.AutoToolTip = false;
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 67);
            this.Exit.Text = "Вийти";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.ToolTipText = "Вийти";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 736);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Перелік укладених договорів";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExportToExcel;
        private System.Windows.Forms.ToolStripButton AddDocument;
        private System.Windows.Forms.ToolStripButton RedactionDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeleteDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveFile;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_of_document;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_document;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_off;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ImportToJSON;
    }
}

