namespace Notepad
{
    partial class GoToLineForm
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
            this.cansel = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.lineNomName = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // cansel
            // 
            this.cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cansel.Location = new System.Drawing.Point(157, 59);
            this.cansel.Name = "cansel";
            this.cansel.Size = new System.Drawing.Size(75, 23);
            this.cansel.TabIndex = 0;
            this.cansel.Text = "Отмена";
            this.cansel.UseVisualStyleBackColor = true;
            // 
            // run
            // 
            this.run.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.run.Location = new System.Drawing.Point(76, 59);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 1;
            this.run.Text = "Переход";
            this.run.UseVisualStyleBackColor = true;
            // 
            // lineNomName
            // 
            this.lineNomName.AutoSize = true;
            this.lineNomName.Location = new System.Drawing.Point(12, 9);
            this.lineNomName.Name = "lineNomName";
            this.lineNomName.Size = new System.Drawing.Size(82, 13);
            this.lineNomName.TabIndex = 3;
            this.lineNomName.Text = "Номер строки:";
            this.lineNomName.Click += new System.EventHandler(this.lineNom_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(15, 33);
            this.line.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.line.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(217, 20);
            this.line.TabIndex = 4;
            this.line.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GoToLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 94);
            this.Controls.Add(this.line);
            this.Controls.Add(this.lineNomName);
            this.Controls.Add(this.run);
            this.Controls.Add(this.cansel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GoToLineForm";
            this.Text = "Перход на строку";
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cansel;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label lineNomName;
        public System.Windows.Forms.NumericUpDown line;
    }
}