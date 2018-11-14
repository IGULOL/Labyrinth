namespace Labyrinth
{
    partial class FormName
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
            this.dgvLabirinth = new System.Windows.Forms.DataGridView();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.btnCreateLabirinth = new System.Windows.Forms.Button();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLabirinth
            // 
            this.dgvLabirinth.AllowUserToAddRows = false;
            this.dgvLabirinth.AllowUserToDeleteRows = false;
            this.dgvLabirinth.AllowUserToResizeColumns = false;
            this.dgvLabirinth.AllowUserToResizeRows = false;
            this.dgvLabirinth.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvLabirinth.ColumnHeadersHeight = 25;
            this.dgvLabirinth.ColumnHeadersVisible = false;
            this.dgvLabirinth.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLabirinth.Location = new System.Drawing.Point(54, 85);
            this.dgvLabirinth.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLabirinth.Name = "dgvLabirinth";
            this.dgvLabirinth.RowHeadersVisible = false;
            this.dgvLabirinth.RowTemplate.Height = 24;
            this.dgvLabirinth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLabirinth.Size = new System.Drawing.Size(49, 48);
            this.dgvLabirinth.TabIndex = 0;
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(122, 32);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(57, 24);
            this.numericUpDownRows.TabIndex = 1;
            this.numericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(51, 34);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 18);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Размер";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(186, 34);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(15, 18);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "x";
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(207, 32);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(57, 24);
            this.numericUpDownCols.TabIndex = 4;
            this.numericUpDownCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCreateLabirinth
            // 
            this.btnCreateLabirinth.Location = new System.Drawing.Point(286, 32);
            this.btnCreateLabirinth.Name = "btnCreateLabirinth";
            this.btnCreateLabirinth.Size = new System.Drawing.Size(94, 24);
            this.btnCreateLabirinth.TabIndex = 5;
            this.btnCreateLabirinth.Text = "Задать";
            this.btnCreateLabirinth.UseVisualStyleBackColor = true;
            this.btnCreateLabirinth.Click += new System.EventHandler(this.btnCreateLabirinth_Click);
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AllowUserToDeleteRows = false;
            this.dgvRes.AllowUserToResizeColumns = false;
            this.dgvRes.AllowUserToResizeRows = false;
            this.dgvRes.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvRes.ColumnHeadersHeight = 25;
            this.dgvRes.ColumnHeadersVisible = false;
            this.dgvRes.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRes.Location = new System.Drawing.Point(394, 85);
            this.dgvRes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.RowHeadersVisible = false;
            this.dgvRes.RowTemplate.Height = 24;
            this.dgvRes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRes.Size = new System.Drawing.Size(49, 48);
            this.dgvRes.TabIndex = 6;
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 449);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.btnCreateLabirinth);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.dgvLabirinth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormName";
            this.Text = "Лабиринт";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLabirinth;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Button btnCreateLabirinth;
        private System.Windows.Forms.DataGridView dgvRes;
    }
}

