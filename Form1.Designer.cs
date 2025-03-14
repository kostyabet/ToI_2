namespace ToI_2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.keyPanel = new System.Windows.Forms.Panel();
            this.keyLengthLabel = new System.Windows.Forms.Label();
            this.genKeyTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.genKeyLabel = new System.Windows.Forms.Label();
            this.inputKeyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fromFileButton = new System.Windows.Forms.Button();
            this.inFileButton = new System.Windows.Forms.Button();
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.cypherLabel = new System.Windows.Forms.Label();
            this.plainLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.genKeyButton = new System.Windows.Forms.Button();
            this.genKeySizeLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.keyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyPanel
            // 
            this.keyPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.keyPanel.Controls.Add(this.genKeySizeLabel);
            this.keyPanel.Controls.Add(this.genKeyButton);
            this.keyPanel.Controls.Add(this.keyLengthLabel);
            this.keyPanel.Controls.Add(this.genKeyTextBox);
            this.keyPanel.Controls.Add(this.keyTextBox);
            this.keyPanel.Controls.Add(this.genKeyLabel);
            this.keyPanel.Controls.Add(this.inputKeyLabel);
            this.keyPanel.Location = new System.Drawing.Point(5, 5);
            this.keyPanel.Name = "keyPanel";
            this.keyPanel.Size = new System.Drawing.Size(810, 135);
            this.keyPanel.TabIndex = 0;
            // 
            // keyLengthLabel
            // 
            this.keyLengthLabel.AutoSize = true;
            this.keyLengthLabel.Location = new System.Drawing.Point(9, 111);
            this.keyLengthLabel.Name = "keyLengthLabel";
            this.keyLengthLabel.Size = new System.Drawing.Size(166, 13);
            this.keyLengthLabel.TabIndex = 4;
            this.keyLengthLabel.Text = "Длинна введённых состояний: ";
            // 
            // genKeyTextBox
            // 
            this.genKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.genKeyTextBox.Enabled = false;
            this.genKeyTextBox.Location = new System.Drawing.Point(408, 43);
            this.genKeyTextBox.MaximumSize = new System.Drawing.Size(393, 60);
            this.genKeyTextBox.MinimumSize = new System.Drawing.Size(393, 60);
            this.genKeyTextBox.Multiline = true;
            this.genKeyTextBox.Name = "genKeyTextBox";
            this.genKeyTextBox.ReadOnly = true;
            this.genKeyTextBox.Size = new System.Drawing.Size(393, 60);
            this.genKeyTextBox.TabIndex = 3;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.keyTextBox.Location = new System.Drawing.Point(9, 43);
            this.keyTextBox.MaximumSize = new System.Drawing.Size(393, 60);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(393, 60);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(393, 60);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // genKeyLabel
            // 
            this.genKeyLabel.AutoSize = true;
            this.genKeyLabel.BackColor = System.Drawing.Color.LightGreen;
            this.genKeyLabel.Location = new System.Drawing.Point(408, 8);
            this.genKeyLabel.MaximumSize = new System.Drawing.Size(393, 30);
            this.genKeyLabel.MinimumSize = new System.Drawing.Size(393, 30);
            this.genKeyLabel.Name = "genKeyLabel";
            this.genKeyLabel.Size = new System.Drawing.Size(393, 30);
            this.genKeyLabel.TabIndex = 1;
            this.genKeyLabel.Text = "Сгенерированный ключ";
            this.genKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputKeyLabel
            // 
            this.inputKeyLabel.AutoSize = true;
            this.inputKeyLabel.BackColor = System.Drawing.Color.LightGreen;
            this.inputKeyLabel.Location = new System.Drawing.Point(9, 8);
            this.inputKeyLabel.MaximumSize = new System.Drawing.Size(393, 30);
            this.inputKeyLabel.MinimumSize = new System.Drawing.Size(393, 30);
            this.inputKeyLabel.Name = "inputKeyLabel";
            this.inputKeyLabel.Size = new System.Drawing.Size(393, 30);
            this.inputKeyLabel.TabIndex = 0;
            this.inputKeyLabel.Text = "Состояние регистра (36 бита)";
            this.inputKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.fromFileButton);
            this.panel1.Controls.Add(this.inFileButton);
            this.panel1.Controls.Add(this.cypherTextBox);
            this.panel1.Controls.Add(this.plainTextBox);
            this.panel1.Controls.Add(this.cypherLabel);
            this.panel1.Controls.Add(this.plainLabel);
            this.panel1.Location = new System.Drawing.Point(5, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 145);
            this.panel1.TabIndex = 1;
            // 
            // fromFileButton
            // 
            this.fromFileButton.BackColor = System.Drawing.Color.LightGreen;
            this.fromFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fromFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.fromFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.fromFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.fromFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromFileButton.Location = new System.Drawing.Point(9, 108);
            this.fromFileButton.Name = "fromFileButton";
            this.fromFileButton.Size = new System.Drawing.Size(393, 28);
            this.fromFileButton.TabIndex = 6;
            this.fromFileButton.Text = "Ввести исходный текст из файл";
            this.fromFileButton.UseVisualStyleBackColor = false;
            this.fromFileButton.Click += new System.EventHandler(this.fromFileButton_Click);
            // 
            // inFileButton
            // 
            this.inFileButton.BackColor = System.Drawing.Color.LightGreen;
            this.inFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inFileButton.Enabled = false;
            this.inFileButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.inFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.inFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.inFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inFileButton.Location = new System.Drawing.Point(408, 108);
            this.inFileButton.Name = "inFileButton";
            this.inFileButton.Size = new System.Drawing.Size(393, 28);
            this.inFileButton.TabIndex = 5;
            this.inFileButton.Text = "Сохранить сгенерированный результат в файл";
            this.inFileButton.UseVisualStyleBackColor = false;
            this.inFileButton.Click += new System.EventHandler(this.inFileButton_Click);
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cypherTextBox.Enabled = false;
            this.cypherTextBox.Location = new System.Drawing.Point(408, 43);
            this.cypherTextBox.MaximumSize = new System.Drawing.Size(393, 60);
            this.cypherTextBox.MinimumSize = new System.Drawing.Size(393, 60);
            this.cypherTextBox.Multiline = true;
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.ReadOnly = true;
            this.cypherTextBox.Size = new System.Drawing.Size(393, 60);
            this.cypherTextBox.TabIndex = 3;
            // 
            // plainTextBox
            // 
            this.plainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plainTextBox.Enabled = false;
            this.plainTextBox.Location = new System.Drawing.Point(9, 43);
            this.plainTextBox.MaximumSize = new System.Drawing.Size(393, 60);
            this.plainTextBox.MinimumSize = new System.Drawing.Size(393, 60);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.ReadOnly = true;
            this.plainTextBox.Size = new System.Drawing.Size(393, 60);
            this.plainTextBox.TabIndex = 2;
            // 
            // cypherLabel
            // 
            this.cypherLabel.AutoSize = true;
            this.cypherLabel.BackColor = System.Drawing.Color.LightGreen;
            this.cypherLabel.Location = new System.Drawing.Point(408, 8);
            this.cypherLabel.MaximumSize = new System.Drawing.Size(393, 30);
            this.cypherLabel.MinimumSize = new System.Drawing.Size(393, 30);
            this.cypherLabel.Name = "cypherLabel";
            this.cypherLabel.Size = new System.Drawing.Size(393, 30);
            this.cypherLabel.TabIndex = 1;
            this.cypherLabel.Text = "Сгенерированный результат";
            this.cypherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plainLabel
            // 
            this.plainLabel.AutoSize = true;
            this.plainLabel.BackColor = System.Drawing.Color.LightGreen;
            this.plainLabel.Location = new System.Drawing.Point(9, 8);
            this.plainLabel.MaximumSize = new System.Drawing.Size(393, 30);
            this.plainLabel.MinimumSize = new System.Drawing.Size(393, 30);
            this.plainLabel.Name = "plainLabel";
            this.plainLabel.Size = new System.Drawing.Size(393, 30);
            this.plainLabel.TabIndex = 0;
            this.plainLabel.Text = "Исходный текст";
            this.plainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Шифрование";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(413, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Дешифрование";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // genKeyButton
            // 
            this.genKeyButton.BackColor = System.Drawing.Color.LightGreen;
            this.genKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.genKeyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.genKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.genKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.genKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genKeyButton.Location = new System.Drawing.Point(408, 104);
            this.genKeyButton.Name = "genKeyButton";
            this.genKeyButton.Size = new System.Drawing.Size(393, 28);
            this.genKeyButton.TabIndex = 5;
            this.genKeyButton.Text = "Сгенерировать Ключ";
            this.genKeyButton.UseVisualStyleBackColor = false;
            this.genKeyButton.Visible = false;
            this.genKeyButton.Click += new System.EventHandler(this.genKeyButton_Click);
            // 
            // genKeySizeLabel
            // 
            this.genKeySizeLabel.AutoSize = true;
            this.genKeySizeLabel.Location = new System.Drawing.Point(408, 111);
            this.genKeySizeLabel.Name = "genKeySizeLabel";
            this.genKeySizeLabel.Size = new System.Drawing.Size(189, 13);
            this.genKeySizeLabel.TabIndex = 8;
            this.genKeySizeLabel.Text = "Длинна сгенерированного ключа: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(820, 331);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.keyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LFSR";
            this.keyPanel.ResumeLayout(false);
            this.keyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel keyPanel;
        private System.Windows.Forms.Label inputKeyLabel;
        private System.Windows.Forms.Label genKeyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox genKeyTextBox;
        private System.Windows.Forms.Label keyLengthLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fromFileButton;
        private System.Windows.Forms.Button inFileButton;
        private System.Windows.Forms.TextBox cypherTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Label cypherLabel;
        private System.Windows.Forms.Label plainLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button genKeyButton;
        private System.Windows.Forms.Label genKeySizeLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}