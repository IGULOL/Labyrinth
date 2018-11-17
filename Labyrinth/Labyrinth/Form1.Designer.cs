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
            this.countRows = new System.Windows.Forms.NumericUpDown();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.countCols = new System.Windows.Forms.NumericUpDown();
            this.btnCreateLabirinth = new System.Windows.Forms.Button();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lbEdit = new System.Windows.Forms.Label();
            this.checkedEdit = new System.Windows.Forms.CheckedListBox();
            this.lbGrenades = new System.Windows.Forms.Label();
            this.countGrenades = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGrenades)).BeginInit();
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
            this.dgvLabirinth.Location = new System.Drawing.Point(326, 13);
            this.dgvLabirinth.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLabirinth.Name = "dgvLabirinth";
            this.dgvLabirinth.ReadOnly = true;
            this.dgvLabirinth.RowHeadersVisible = false;
            this.dgvLabirinth.RowTemplate.Height = 24;
            this.dgvLabirinth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLabirinth.Size = new System.Drawing.Size(54, 53);
            this.dgvLabirinth.TabIndex = 0;
            this.dgvLabirinth.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLabirinth_CellMouseUp);
            // 
            // countRows
            // 
            this.countRows.Location = new System.Drawing.Point(31, 69);
            this.countRows.Margin = new System.Windows.Forms.Padding(4);
            this.countRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.countRows.Name = "countRows";
            this.countRows.Size = new System.Drawing.Size(108, 26);
            this.countRows.TabIndex = 1;
            this.countRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(27, 45);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(171, 20);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Размер лабиринта:";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(147, 71);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(17, 20);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "x";
            // 
            // countCols
            // 
            this.countCols.Location = new System.Drawing.Point(171, 68);
            this.countCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.countCols.Name = "countCols";
            this.countCols.Size = new System.Drawing.Size(108, 26);
            this.countCols.TabIndex = 4;
            this.countCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnCreateLabirinth
            // 
            this.btnCreateLabirinth.Location = new System.Drawing.Point(31, 102);
            this.btnCreateLabirinth.Name = "btnCreateLabirinth";
            this.btnCreateLabirinth.Size = new System.Drawing.Size(247, 27);
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
            this.dgvRes.Location = new System.Drawing.Point(326, 288);
            this.dgvRes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.RowHeadersVisible = false;
            this.dgvRes.RowTemplate.Height = 24;
            this.dgvRes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRes.Size = new System.Drawing.Size(54, 53);
            this.dgvRes.TabIndex = 6;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(149, 187);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(129, 27);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Информация";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Location = new System.Drawing.Point(27, 164);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(251, 20);
            this.lbEdit.TabIndex = 13;
            this.lbEdit.Text = "Редактирование лабиринта:";
            // 
            // checkedEdit
            // 
            this.checkedEdit.CheckOnClick = true;
            this.checkedEdit.FormattingEnabled = true;
            this.checkedEdit.Items.AddRange(new object[] {
            "Стены",
            "Вход",
            "Выход"});
            this.checkedEdit.Location = new System.Drawing.Point(31, 187);
            this.checkedEdit.Name = "checkedEdit";
            this.checkedEdit.Size = new System.Drawing.Size(93, 67);
            this.checkedEdit.TabIndex = 14;
            this.checkedEdit.SelectedIndexChanged += new System.EventHandler(this.checkedEdit_SelectedIndexChanged);
            // 
            // lbGrenades
            // 
            this.lbGrenades.AutoSize = true;
            this.lbGrenades.Location = new System.Drawing.Point(27, 288);
            this.lbGrenades.Name = "lbGrenades";
            this.lbGrenades.Size = new System.Drawing.Size(177, 20);
            this.lbGrenades.TabIndex = 15;
            this.lbGrenades.Text = "Количество гранат:";
            // 
            // countGrenades
            // 
            this.countGrenades.Location = new System.Drawing.Point(31, 311);
            this.countGrenades.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countGrenades.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countGrenades.Name = "countGrenades";
            this.countGrenades.Size = new System.Drawing.Size(108, 26);
            this.countGrenades.TabIndex = 16;
            this.countGrenades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(31, 343);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(248, 27);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Найти путь";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 587);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.countGrenades);
            this.Controls.Add(this.lbGrenades);
            this.Controls.Add(this.checkedEdit);
            this.Controls.Add(this.lbEdit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.btnCreateLabirinth);
            this.Controls.Add(this.countCols);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.countRows);
            this.Controls.Add(this.dgvLabirinth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormName";
            this.Text = "Лабиринт";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGrenades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLabirinth;
        private System.Windows.Forms.NumericUpDown countRows;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.NumericUpDown countCols;
        private System.Windows.Forms.Button btnCreateLabirinth;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.CheckedListBox checkedEdit;
        private System.Windows.Forms.Label lbGrenades;
        private System.Windows.Forms.NumericUpDown countGrenades;
        private System.Windows.Forms.Button btnRun;
    }
}

