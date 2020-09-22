namespace Uchetnik
{
    partial class Auth_Form
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
            this.Auth_Label1 = new System.Windows.Forms.Label();
            this.Auth_TextBox = new System.Windows.Forms.TextBox();
            this.Auth_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Auth_Label1
            // 
            this.Auth_Label1.AutoSize = true;
            this.Auth_Label1.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auth_Label1.Location = new System.Drawing.Point(8, 6);
            this.Auth_Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Auth_Label1.Name = "Auth_Label1";
            this.Auth_Label1.Size = new System.Drawing.Size(108, 13);
            this.Auth_Label1.TabIndex = 0;
            this.Auth_Label1.Text = "Введите Ваш логин:";
            // 
            // Auth_TextBox
            // 
            this.Auth_TextBox.Location = new System.Drawing.Point(11, 22);
            this.Auth_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Auth_TextBox.Name = "Auth_TextBox";
            this.Auth_TextBox.Size = new System.Drawing.Size(121, 20);
            this.Auth_TextBox.TabIndex = 1;
            this.Auth_TextBox.UseSystemPasswordChar = true;
            // 
            // Auth_Button
            // 
            this.Auth_Button.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auth_Button.Location = new System.Drawing.Point(67, 46);
            this.Auth_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Auth_Button.Name = "Auth_Button";
            this.Auth_Button.Size = new System.Drawing.Size(65, 20);
            this.Auth_Button.TabIndex = 2;
            this.Auth_Button.Text = "Вход";
            this.Auth_Button.UseVisualStyleBackColor = true;
            this.Auth_Button.Click += new System.EventHandler(this.Auth_Button_Click);
            // 
            // Auth_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 82);
            this.Controls.Add(this.Auth_Button);
            this.Controls.Add(this.Auth_TextBox);
            this.Controls.Add(this.Auth_Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Auth_Form";
            this.Text = "Аунтификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Auth_Label1;
        private System.Windows.Forms.TextBox Auth_TextBox;
        private System.Windows.Forms.Button Auth_Button;
    }
}

