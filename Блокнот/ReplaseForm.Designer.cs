namespace Notepad
{
    partial class ReplaseForm
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
            this.replaseAll = new System.Windows.Forms.Button();
            this.replase = new System.Windows.Forms.Button();
            this.fildRName = new System.Windows.Forms.Label();
            this.replaseFild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(329, 14);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(88, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Найти далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // cansel
            // 
            this.cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cansel.Location = new System.Drawing.Point(329, 101);
            this.cansel.Name = "cansel";
            this.cansel.Size = new System.Drawing.Size(88, 23);
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
            this.serchingFild.Click += new System.EventHandler(this.fildName_Click);
            this.serchingFild.TextChanged += new System.EventHandler(this.serchingFild_TextChanged);
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
            this.tolower.Location = new System.Drawing.Point(12, 115);
            this.tolower.Name = "tolower";
            this.tolower.Size = new System.Drawing.Size(120, 17);
            this.tolower.TabIndex = 4;
            this.tolower.Text = "С учетом регистра";
            this.tolower.UseVisualStyleBackColor = true;
            this.tolower.CheckedChanged += new System.EventHandler(this.tolower_CheckedChanged);
            // 
            // replaseAll
            // 
            this.replaseAll.Location = new System.Drawing.Point(329, 72);
            this.replaseAll.Name = "replaseAll";
            this.replaseAll.Size = new System.Drawing.Size(88, 23);
            this.replaseAll.TabIndex = 5;
            this.replaseAll.Text = "Заменить все";
            this.replaseAll.UseVisualStyleBackColor = true;
            // 
            // replase
            // 
            this.replase.Location = new System.Drawing.Point(329, 43);
            this.replase.Name = "replase";
            this.replase.Size = new System.Drawing.Size(88, 23);
            this.replase.TabIndex = 6;
            this.replase.Text = "Заменить";
            this.replase.UseVisualStyleBackColor = true;
            // 
            // fildRName
            // 
            this.fildRName.AutoSize = true;
            this.fildRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fildRName.Location = new System.Drawing.Point(12, 46);
            this.fildRName.Name = "fildRName";
            this.fildRName.Size = new System.Drawing.Size(41, 18);
            this.fildRName.TabIndex = 8;
            this.fildRName.Text = "Чем:";
            // 
            // replaseFild
            // 
            this.replaseFild.Location = new System.Drawing.Point(56, 46);
            this.replaseFild.Name = "replaseFild";
            this.replaseFild.Size = new System.Drawing.Size(221, 20);
            this.replaseFild.TabIndex = 7;
            this.replaseFild.TextChanged += new System.EventHandler(this.replaseFild_TextChanged);
            // 
            // ReplaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cansel;
            this.ClientSize = new System.Drawing.Size(429, 144);
            this.Controls.Add(this.fildRName);
            this.Controls.Add(this.replaseFild);
            this.Controls.Add(this.replase);
            this.Controls.Add(this.replaseAll);
            this.Controls.Add(this.tolower);
            this.Controls.Add(this.fildName);
            this.Controls.Add(this.serchingFild);
            this.Controls.Add(this.cansel);
            this.Controls.Add(this.nextBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReplaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplaseForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cansel;
        private System.Windows.Forms.Label fildName;
        private System.Windows.Forms.Label fildRName;
        private System.Windows.Forms.TextBox serchingFild;
        private System.Windows.Forms.TextBox replaseFild;
        private System.Windows.Forms.CheckBox tolower;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button replaseAll;
        private System.Windows.Forms.Button replase;
    }
}