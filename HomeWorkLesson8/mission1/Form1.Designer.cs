namespace mission1
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
            this.bttnRef = new System.Windows.Forms.Button();
            this.TbForRef = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnRef
            // 
            this.bttnRef.Location = new System.Drawing.Point(12, 311);
            this.bttnRef.Name = "bttnRef";
            this.bttnRef.Size = new System.Drawing.Size(89, 23);
            this.bttnRef.TabIndex = 0;
            this.bttnRef.Text = "Показать тип";
            this.bttnRef.UseVisualStyleBackColor = true;
            this.bttnRef.Click += new System.EventHandler(this.bttnRef_Click);
            // 
            // TbForRef
            // 
            this.TbForRef.Location = new System.Drawing.Point(12, 12);
            this.TbForRef.Multiline = true;
            this.TbForRef.Name = "TbForRef";
            this.TbForRef.Size = new System.Drawing.Size(776, 281);
            this.TbForRef.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbForRef);
            this.Controls.Add(this.bttnRef);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnRef;
        private System.Windows.Forms.TextBox TbForRef;
    }
}

