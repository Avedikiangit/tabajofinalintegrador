namespace Trabajo_Final_Integrador
{
    partial class FormsEdit
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
            lblCategoryEdit = new Label();
            lblDescriptionEdit = new Label();
            lblPriceEdit = new Label();
            lblTitleEdit = new Label();
            lblIdEdit = new Label();
            txtBoxIdEdit = new TextBox();
            btnCancelEdit = new Button();
            btnAcceptEdit = new Button();
            txtBoxCategoryEdit = new TextBox();
            txtBoxDescriptionEdit = new TextBox();
            txtBoxPriceEdit = new TextBox();
            txtBoxTitleEdit = new TextBox();
            SuspendLayout();
            // 
            // lblCategoryEdit
            // 
            lblCategoryEdit.AutoSize = true;
            lblCategoryEdit.Location = new Point(51, 213);
            lblCategoryEdit.Name = "lblCategoryEdit";
            lblCategoryEdit.Size = new Size(61, 15);
            lblCategoryEdit.TabIndex = 47;
            lblCategoryEdit.Text = "Categoria:";
            // 
            // lblDescriptionEdit
            // 
            lblDescriptionEdit.AutoSize = true;
            lblDescriptionEdit.Location = new Point(51, 166);
            lblDescriptionEdit.Name = "lblDescriptionEdit";
            lblDescriptionEdit.Size = new Size(72, 15);
            lblDescriptionEdit.TabIndex = 46;
            lblDescriptionEdit.Text = "Descripcion:";
            // 
            // lblPriceEdit
            // 
            lblPriceEdit.AutoSize = true;
            lblPriceEdit.Location = new Point(51, 118);
            lblPriceEdit.Name = "lblPriceEdit";
            lblPriceEdit.Size = new Size(43, 15);
            lblPriceEdit.TabIndex = 45;
            lblPriceEdit.Text = "Precio:";
            // 
            // lblTitleEdit
            // 
            lblTitleEdit.AutoSize = true;
            lblTitleEdit.Location = new Point(51, 73);
            lblTitleEdit.Name = "lblTitleEdit";
            lblTitleEdit.Size = new Size(40, 15);
            lblTitleEdit.TabIndex = 44;
            lblTitleEdit.Text = "Titulo:";
            // 
            // lblIdEdit
            // 
            lblIdEdit.AutoSize = true;
            lblIdEdit.Location = new Point(53, 29);
            lblIdEdit.Name = "lblIdEdit";
            lblIdEdit.Size = new Size(21, 15);
            lblIdEdit.TabIndex = 43;
            lblIdEdit.Text = "ID:";
            // 
            // txtBoxIdEdit
            // 
            txtBoxIdEdit.Location = new Point(53, 47);
            txtBoxIdEdit.Name = "txtBoxIdEdit";
            txtBoxIdEdit.ReadOnly = true;
            txtBoxIdEdit.Size = new Size(147, 23);
            txtBoxIdEdit.TabIndex = 42;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.Gold;
            btnCancelEdit.Location = new Point(143, 271);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(83, 23);
            btnCancelEdit.TabIndex = 41;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnAcceptEdit
            // 
            btnAcceptEdit.BackColor = Color.Gold;
            btnAcceptEdit.Location = new Point(37, 271);
            btnAcceptEdit.Name = "btnAcceptEdit";
            btnAcceptEdit.Size = new Size(83, 23);
            btnAcceptEdit.TabIndex = 40;
            btnAcceptEdit.Text = "Aceptar";
            btnAcceptEdit.UseVisualStyleBackColor = false;
            btnAcceptEdit.Click += btnAcceptEdit_Click;
            // 
            // txtBoxCategoryEdit
            // 
            txtBoxCategoryEdit.Location = new Point(51, 231);
            txtBoxCategoryEdit.Name = "txtBoxCategoryEdit";
            txtBoxCategoryEdit.Size = new Size(149, 23);
            txtBoxCategoryEdit.TabIndex = 39;
            // 
            // txtBoxDescriptionEdit
            // 
            txtBoxDescriptionEdit.Location = new Point(51, 184);
            txtBoxDescriptionEdit.Name = "txtBoxDescriptionEdit";
            txtBoxDescriptionEdit.Size = new Size(149, 23);
            txtBoxDescriptionEdit.TabIndex = 38;
            // 
            // txtBoxPriceEdit
            // 
            txtBoxPriceEdit.Location = new Point(51, 135);
            txtBoxPriceEdit.Name = "txtBoxPriceEdit";
            txtBoxPriceEdit.Size = new Size(149, 23);
            txtBoxPriceEdit.TabIndex = 37;
            // 
            // txtBoxTitleEdit
            // 
            txtBoxTitleEdit.Location = new Point(51, 92);
            txtBoxTitleEdit.Name = "txtBoxTitleEdit";
            txtBoxTitleEdit.Size = new Size(149, 23);
            txtBoxTitleEdit.TabIndex = 36;
            // 
            // FrmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(263, 323);
            Controls.Add(lblCategoryEdit);
            Controls.Add(lblDescriptionEdit);
            Controls.Add(lblPriceEdit);
            Controls.Add(lblTitleEdit);
            Controls.Add(lblIdEdit);
            Controls.Add(txtBoxIdEdit);
            Controls.Add(btnCancelEdit);
            Controls.Add(btnAcceptEdit);
            Controls.Add(txtBoxCategoryEdit);
            Controls.Add(txtBoxDescriptionEdit);
            Controls.Add(txtBoxPriceEdit);
            Controls.Add(txtBoxTitleEdit);
            MaximizeBox = false;
            Name = "FrmEdit";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryEdit;
        private Label lblDescriptionEdit;
        private Label lblPriceEdit;
        private Label lblTitleEdit;
        private Label lblIdEdit;
        private TextBox txtBoxIdEdit;
        private Button btnCancelEdit;
        private Button btnAcceptEdit;
        private TextBox txtBoxCategoryEdit;
        private TextBox txtBoxDescriptionEdit;
        private TextBox txtBoxPriceEdit;
        private TextBox txtBoxTitleEdit;
    }
}