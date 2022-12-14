namespace UP_11_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.ASideBox = new System.Windows.Forms.TextBox();
            this.BSideBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ASideLabel = new System.Windows.Forms.Label();
            this.BSideLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PerimeterLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IsSquareLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сторону а ->";
            // 
            // ASideBox
            // 
            this.ASideBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ASideBox.Location = new System.Drawing.Point(168, 10);
            this.ASideBox.Name = "ASideBox";
            this.ASideBox.Size = new System.Drawing.Size(100, 23);
            this.ASideBox.TabIndex = 1;
            // 
            // BSideBox
            // 
            this.BSideBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BSideBox.Location = new System.Drawing.Point(168, 39);
            this.BSideBox.Name = "BSideBox";
            this.BSideBox.Size = new System.Drawing.Size(100, 23);
            this.BSideBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите сторону b ->";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AcceptButton.Location = new System.Drawing.Point(274, 10);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(143, 52);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сторона а ->";
            // 
            // ASideLabel
            // 
            this.ASideLabel.AutoSize = true;
            this.ASideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.ASideLabel.Location = new System.Drawing.Point(112, 82);
            this.ASideLabel.Name = "ASideLabel";
            this.ASideLabel.Size = new System.Drawing.Size(132, 17);
            this.ASideLabel.TabIndex = 7;
            this.ASideLabel.Text = "Здесь сторона а";
            // 
            // BSideLabel
            // 
            this.BSideLabel.AutoSize = true;
            this.BSideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.BSideLabel.Location = new System.Drawing.Point(112, 108);
            this.BSideLabel.Name = "BSideLabel";
            this.BSideLabel.Size = new System.Drawing.Size(132, 17);
            this.BSideLabel.TabIndex = 9;
            this.BSideLabel.Text = "Здесь сторона b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сторона b ->";
            // 
            // PerimeterLabel
            // 
            this.PerimeterLabel.AutoSize = true;
            this.PerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.PerimeterLabel.Location = new System.Drawing.Point(111, 135);
            this.PerimeterLabel.Name = "PerimeterLabel";
            this.PerimeterLabel.Size = new System.Drawing.Size(129, 17);
            this.PerimeterLabel.TabIndex = 11;
            this.PerimeterLabel.Text = "Здесь периметр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Периметр ->";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.SquareLabel.Location = new System.Drawing.Point(112, 161);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(122, 17);
            this.SquareLabel.TabIndex = 13;
            this.SquareLabel.Text = "Здесь площадь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(13, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Площадь ->";
            // 
            // IsSquareLabel
            // 
            this.IsSquareLabel.AutoSize = true;
            this.IsSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.IsSquareLabel.Location = new System.Drawing.Point(112, 190);
            this.IsSquareLabel.Name = "IsSquareLabel";
            this.IsSquareLabel.Size = new System.Drawing.Size(62, 17);
            this.IsSquareLabel.TabIndex = 15;
            this.IsSquareLabel.Text = "Да/Нет";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(13, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Квадрат? ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 227);
            this.Controls.Add(this.IsSquareLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PerimeterLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BSideLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ASideLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.BSideBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ASideBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ASideBox;
        private System.Windows.Forms.TextBox BSideBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PerimeterLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IsSquareLabel;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label ASideLabel;
        public System.Windows.Forms.Label BSideLabel;
    }
}

