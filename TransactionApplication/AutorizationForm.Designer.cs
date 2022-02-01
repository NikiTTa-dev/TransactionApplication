namespace TransactionApplication
{
    partial class AutorizationForm
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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 24F);
            this.PasswordTextBox.Location = new System.Drawing.Point(100, 310);
            this.PasswordTextBox.MaxLength = 17;
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(241, 39);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(340, 44);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "********";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.MouseEnter += new System.EventHandler(this.PasswordTextBox_MouseEnter);
            this.PasswordTextBox.MouseLeave += new System.EventHandler(this.PasswordTextBox_MouseLeave);
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameBox.Location = new System.Drawing.Point(100, 240);
            this.UsernameBox.MaxLength = 17;
            this.UsernameBox.Multiline = true;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(340, 40);
            this.UsernameBox.TabIndex = 5;
            this.UsernameBox.Text = "Username";
            this.UsernameBox.Click += new System.EventHandler(this.UsernameBox_Click);
            this.UsernameBox.MouseEnter += new System.EventHandler(this.UsernameBox_MouseEnter);
            this.UsernameBox.MouseLeave += new System.EventHandler(this.UsernameBox_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(211)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(505, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 37);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackgroundImage = global::TransactionApplication.Properties.Resources.autorizationPhoto;
            this.BackgroundPanel.Controls.Add(this.SignInButton);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(540, 600);
            this.BackgroundPanel.TabIndex = 7;
            this.BackgroundPanel.Click += new System.EventHandler(this.BackgroundPanel_Click);
            this.BackgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundPanel_MouseDown);
            this.BackgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundPanel_MouseMove);
            // 
            // SignInButton
            // 
            this.SignInButton.AutoSize = true;
            this.SignInButton.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(190, 450);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(160, 60);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 600);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button SignInButton;
    }
}

