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
            this.size = new System.Windows.Forms.NumericUpDown();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lbEdit = new System.Windows.Forms.Label();
            this.checkedEdit = new System.Windows.Forms.CheckedListBox();
            this.lbGrenades = new System.Windows.Forms.Label();
            this.countGrenades = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.rbManually = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
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
            this.dgvLabirinth.Location = new System.Drawing.Point(246, 28);
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
            // size
            // 
            this.size.Location = new System.Drawing.Point(24, 55);
            this.size.Margin = new System.Windows.Forms.Padding(4);
            this.size.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(108, 26);
            this.size.TabIndex = 1;
            this.size.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.size.ValueChanged += new System.EventHandler(this.size_ValueChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(20, 31);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(171, 20);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Размер лабиринта:";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(186, 187);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(31, 27);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Location = new System.Drawing.Point(21, 162);
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
            this.checkedEdit.Location = new System.Drawing.Point(24, 248);
            this.checkedEdit.Name = "checkedEdit";
            this.checkedEdit.Size = new System.Drawing.Size(93, 67);
            this.checkedEdit.TabIndex = 14;
            this.checkedEdit.Visible = false;
            this.checkedEdit.SelectedIndexChanged += new System.EventHandler(this.checkedEdit_SelectedIndexChanged);
            // 
            // lbGrenades
            // 
            this.lbGrenades.AutoSize = true;
            this.lbGrenades.Location = new System.Drawing.Point(20, 87);
            this.lbGrenades.Name = "lbGrenades";
            this.lbGrenades.Size = new System.Drawing.Size(177, 20);
            this.lbGrenades.TabIndex = 15;
            this.lbGrenades.Text = "Количество гранат:";
            // 
            // countGrenades
            // 
            this.countGrenades.Location = new System.Drawing.Point(24, 110);
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
            this.btnRun.Location = new System.Drawing.Point(24, 329);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(193, 27);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Найти путь";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbManually
            // 
            this.rbManually.AutoSize = true;
            this.rbManually.Location = new System.Drawing.Point(24, 188);
            this.rbManually.Name = "rbManually";
            this.rbManually.Size = new System.Drawing.Size(101, 24);
            this.rbManually.TabIndex = 18;
            this.rbManually.Text = "Вручную";
            this.rbManually.UseVisualStyleBackColor = true;
            this.rbManually.CheckedChanged += new System.EventHandler(this.rbManually_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 24);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Рандомно";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(41, 269);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(156, 27);
            this.btnRandom.TabIndex = 20;
            this.btnRandom.Text = "Сгенерировать";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 394);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbManually);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.countGrenades);
            this.Controls.Add(this.lbGrenades);
            this.Controls.Add(this.checkedEdit);
            this.Controls.Add(this.lbEdit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.size);
            this.Controls.Add(this.dgvLabirinth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormName";
            this.Text = "Лабиринт";
            this.Shown += new System.EventHandler(this.FormName_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGrenades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLabirinth;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.CheckedListBox checkedEdit;
        private System.Windows.Forms.Label lbGrenades;
        private System.Windows.Forms.NumericUpDown countGrenades;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbManually;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnRandom;
    }
}

