namespace Trabajo_Final_Integrador
{
    partial class FormsMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            cntxMenuStripDelete = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxCategory = new ComboBox();
            btnAscDesc = new Button();
            btnNew = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnDelete = new Button();
            lblFilterCategory = new Label();
            lblNew = new Label();
            lblAscDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            cntxMenuStripDelete.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ContextMenuStrip = cntxMenuStripDelete;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1238, 492);
            dataGridView.TabIndex = 0;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // cntxMenuStripDelete
            // 
            cntxMenuStripDelete.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            cntxMenuStripDelete.Name = "cntxMenuStripDelete";
            cntxMenuStripDelete.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // cmbBoxCategory
            // 
            cmbBoxCategory.FormattingEnabled = true;
            cmbBoxCategory.Location = new Point(203, 28);
            cmbBoxCategory.Name = "cmbBoxCategory";
            cmbBoxCategory.Size = new Size(120, 23);
            cmbBoxCategory.TabIndex = 1;
            cmbBoxCategory.SelectedIndexChanged += cmbBoxCategory_SelectedIndexChanged;
            // 
            // btnAscDesc
            // 
            btnAscDesc.Location = new Point(12, 28);
            btnAscDesc.Name = "btnAscDesc";
            btnAscDesc.Size = new Size(92, 23);
            btnAscDesc.TabIndex = 2;
            btnAscDesc.Text = "Descendente";
            btnAscDesc.UseVisualStyleBackColor = true;
            btnAscDesc.Click += btnAscDesc_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(110, 27);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(77, 23);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblFilterCategory);
            panel1.Controls.Add(lblNew);
            panel1.Controls.Add(lblAscDesc);
            panel1.Controls.Add(btnAscDesc);
            panel1.Controls.Add(cmbBoxCategory);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 492);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 64);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 10);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 11;
            label1.Text = "Borrar Producto";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 28);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(203, 9);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(91, 15);
            lblFilterCategory.TabIndex = 9;
            lblFilterCategory.Text = "Filtrar Categoria";
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Location = new Point(110, 10);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(87, 15);
            lblNew.TabIndex = 8;
            lblNew.Text = "Crear Producto";
            // 
            // lblAscDesc
            // 
            lblAscDesc.AutoSize = true;
            lblAscDesc.Location = new Point(12, 10);
            lblAscDesc.Name = "lblAscDesc";
            lblAscDesc.Size = new Size(50, 15);
            lblAscDesc.TabIndex = 7;
            lblAscDesc.Text = "Ordenar";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 556);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Name = "FrmMain";
            Text = "Pantalla Principal";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            cntxMenuStripDelete.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox cmbBoxCategory;
        private Button btnAscDesc;
        private Button btnNew;
        private ContextMenuStrip cntxMenuStripDelete;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel1;
        private Label lblFilterCategory;
        private Label lblNew;
        private Label lblAscDesc;
        private Label label1;
        private Button btnDelete;
    }
}