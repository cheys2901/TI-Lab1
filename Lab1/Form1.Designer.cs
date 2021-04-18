namespace Lab1
{
    partial class frmMain
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
            this.fileNameOpen = new System.Windows.Forms.TextBox();
            this.nameKey = new System.Windows.Forms.TextBox();
            this.nameSave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.choise = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.valueSize = new System.Windows.Forms.Label();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameOpen
            // 
            this.fileNameOpen.Location = new System.Drawing.Point(14, 14);
            this.fileNameOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fileNameOpen.Name = "fileNameOpen";
            this.fileNameOpen.Size = new System.Drawing.Size(170, 27);
            this.fileNameOpen.TabIndex = 0;
            // 
            // nameKey
            // 
            this.nameKey.Location = new System.Drawing.Point(14, 44);
            this.nameKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameKey.Name = "nameKey";
            this.nameKey.Size = new System.Drawing.Size(170, 27);
            this.nameKey.TabIndex = 1;
            // 
            // nameSave
            // 
            this.nameSave.Location = new System.Drawing.Point(14, 74);
            this.nameSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameSave.Name = "nameSave";
            this.nameSave.Size = new System.Drawing.Size(170, 27);
            this.nameSave.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(192, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Текст";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(192, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ключ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(192, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Результат";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // choise
            // 
            this.choise.AutoSize = true;
            this.choise.Checked = true;
            this.choise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choise.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choise.Location = new System.Drawing.Point(313, 17);
            this.choise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choise.Name = "choise";
            this.choise.Size = new System.Drawing.Size(121, 24);
            this.choise.TabIndex = 6;
            this.choise.Text = "Шифрование";
            this.choise.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(313, 74);
            this.start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(88, 27);
            this.start.TabIndex = 7;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 107);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // valueSize
            // 
            this.valueSize.AutoSize = true;
            this.valueSize.Location = new System.Drawing.Point(232, 107);
            this.valueSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueSize.Name = "valueSize";
            this.valueSize.Size = new System.Drawing.Size(17, 20);
            this.valueSize.TabIndex = 10;
            this.valueSize.Text = "5";
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Items.AddRange(new object[] {
            "Железнодорожная изгородь",
            "Столбцовый метод",
            "Пововаривающая решётка",
            "Шифр Цезаря"});
            this.cmbBoxType.Location = new System.Drawing.Point(313, 44);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(188, 28);
            this.cmbBoxType.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(539, 451);
            this.dataGridView1.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 604);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.valueSize);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.choise);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSave);
            this.Controls.Add(this.nameKey);
            this.Controls.Add(this.fileNameOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "ТИ 1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameOpen;
        private System.Windows.Forms.TextBox nameKey;
        private System.Windows.Forms.TextBox nameSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox choise;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label valueSize;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

