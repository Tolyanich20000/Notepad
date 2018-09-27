namespace Notepad
{
    partial class SearchForm
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.cansel = new System.Windows.Forms.Button();
            this.serchingFild = new System.Windows.Forms.TextBox();
            this.fildName = new System.Windows.Forms.Label();
            this.tolower = new System.Windows.Forms.CheckBox();
            this.way = new System.Windows.Forms.GroupBox();
            this.up = new System.Windows.Forms.RadioButton();
            this.down = new System.Windows.Forms.RadioButton();
            this.way.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(283, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(81, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Найти далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cansel
            // 
            this.cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cansel.Location = new System.Drawing.Point(283, 39);
            this.cansel.Name = "cansel";
            this.cansel.Size = new System.Drawing.Size(81, 23);
            this.cansel.TabIndex = 1;
            this.cansel.Text = "Отмена";
            this.cansel.UseVisualStyleBackColor = true;
            this.cansel.Click += new System.EventHandler(this.cansel_Click);
            // 
            // serchingFild
            // 
            this.serchingFild.Location = new System.Drawing.Point(56, 14);
            this.serchingFild.Name = "serchingFild";
            this.serchingFild.Size = new System.Drawing.Size(221, 20);
            this.serchingFild.TabIndex = 2;
            // 
            // fildName
            // 
            this.fildName.AutoSize = true;
            this.fildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fildName.Location = new System.Drawing.Point(12, 14);
            this.fildName.Name = "fildName";
            this.fildName.Size = new System.Drawing.Size(38, 18);
            this.fildName.TabIndex = 3;
            this.fildName.Text = "Что:";
            this.fildName.Click += new System.EventHandler(this.fildName_Click);
            // 
            // tolower
            // 
            this.tolower.AutoSize = true;
            this.tolower.Location = new System.Drawing.Point(12, 79);
            this.tolower.Name = "tolower";
            this.tolower.Size = new System.Drawing.Size(120, 17);
            this.tolower.TabIndex = 4;
            this.tolower.Text = "С учетом регистра";
            this.tolower.UseVisualStyleBackColor = true;
            // 
            // way
            // 
            this.way.Controls.Add(this.up);
            this.way.Controls.Add(this.down);
            this.way.Location = new System.Drawing.Point(141, 51);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(136, 45);
            this.way.TabIndex = 5;
            this.way.TabStop = false;
            this.way.Text = "Направление";
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(6, 17);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(55, 17);
            this.up.TabIndex = 1;
            this.up.Text = "Вверх";
            this.up.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Checked = true;
            this.down.Location = new System.Drawing.Point(80, 17);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(50, 17);
            this.down.TabIndex = 0;
            this.down.TabStop = true;
            this.down.Text = "Вниз";
            this.down.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cansel;
            this.ClientSize = new System.Drawing.Size(376, 108);
            this.Controls.Add(this.way);
            this.Controls.Add(this.tolower);
            this.Controls.Add(this.fildName);
            this.Controls.Add(this.serchingFild);
            this.Controls.Add(this.cansel);
            this.Controls.Add(this.nextBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.way.ResumeLayout(false);
            this.way.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cansel;
        private System.Windows.Forms.Label fildName;
        private System.Windows.Forms.GroupBox way;
        internal System.Windows.Forms.TextBox serchingFild;
        internal System.Windows.Forms.CheckBox tolower;
        internal System.Windows.Forms.RadioButton up;
        internal System.Windows.Forms.RadioButton down;
    }
}