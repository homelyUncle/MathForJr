namespace Math2._0
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
            this.num21 = new System.Windows.Forms.Label();
            this.singLbl = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.ResTxt1 = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.MinOperandTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxOperandTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResTxt2 = new System.Windows.Forms.TextBox();
            this.ResTxt3 = new System.Windows.Forms.TextBox();
            this.ResTxt4 = new System.Windows.Forms.TextBox();
            this.num11 = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num21
            // 
            this.num21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num21.Location = new System.Drawing.Point(268, 47);
            this.num21.Name = "num21";
            this.num21.Size = new System.Drawing.Size(88, 38);
            this.num21.TabIndex = 1;
            this.num21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // singLbl
            // 
            this.singLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singLbl.Location = new System.Drawing.Point(233, 29);
            this.singLbl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.singLbl.Name = "singLbl";
            this.singLbl.Size = new System.Drawing.Size(35, 38);
            this.singLbl.TabIndex = 2;
            this.singLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(223, 190);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(169, 33);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "новый пример";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResTxt1
            // 
            this.ResTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTxt1.Location = new System.Drawing.Point(334, 108);
            this.ResTxt1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ResTxt1.Name = "ResTxt1";
            this.ResTxt1.Size = new System.Drawing.Size(22, 38);
            this.ResTxt1.TabIndex = 0;
            this.ResTxt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResTxt1_KeyPress);
            // 
            // resultLbl
            // 
            this.resultLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(175, 152);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(274, 35);
            this.resultLbl.TabIndex = 6;
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinOperandTxt
            // 
            this.MinOperandTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinOperandTxt.Location = new System.Drawing.Point(52, 47);
            this.MinOperandTxt.Name = "MinOperandTxt";
            this.MinOperandTxt.Size = new System.Drawing.Size(49, 29);
            this.MinOperandTxt.TabIndex = 4;
            this.MinOperandTxt.Text = "1";
            this.MinOperandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "минимальный операнд";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaxOperandTxt
            // 
            this.MaxOperandTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxOperandTxt.Location = new System.Drawing.Point(52, 110);
            this.MaxOperandTxt.Name = "MaxOperandTxt";
            this.MaxOperandTxt.Size = new System.Drawing.Size(49, 29);
            this.MaxOperandTxt.TabIndex = 5;
            this.MaxOperandTxt.Text = "99";
            this.MaxOperandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "максимальный операнд";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResTxt2
            // 
            this.ResTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTxt2.Location = new System.Drawing.Point(312, 108);
            this.ResTxt2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ResTxt2.Name = "ResTxt2";
            this.ResTxt2.Size = new System.Drawing.Size(22, 38);
            this.ResTxt2.TabIndex = 1;
            this.ResTxt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResTxt2_KeyPress);
            // 
            // ResTxt3
            // 
            this.ResTxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTxt3.Location = new System.Drawing.Point(290, 108);
            this.ResTxt3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ResTxt3.Name = "ResTxt3";
            this.ResTxt3.Size = new System.Drawing.Size(22, 38);
            this.ResTxt3.TabIndex = 2;
            this.ResTxt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResTxt3_KeyPress);
            // 
            // ResTxt4
            // 
            this.ResTxt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTxt4.Location = new System.Drawing.Point(268, 108);
            this.ResTxt4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ResTxt4.Name = "ResTxt4";
            this.ResTxt4.Size = new System.Drawing.Size(22, 38);
            this.ResTxt4.TabIndex = 3;
            this.ResTxt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResTxt4_KeyPress);
            // 
            // num11
            // 
            this.num11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num11.Location = new System.Drawing.Point(268, 9);
            this.num11.Name = "num11";
            this.num11.Size = new System.Drawing.Size(88, 38);
            this.num11.TabIndex = 1;
            this.num11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wins
            // 
            this.wins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wins.Location = new System.Drawing.Point(52, 189);
            this.wins.Name = "wins";
            this.wins.ReadOnly = true;
            this.wins.Size = new System.Drawing.Size(49, 22);
            this.wins.TabIndex = 5;
            this.wins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "правильных ответов\r\nподряд";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(52, 217);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(49, 23);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "сброс";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ResTxt4);
            this.Controls.Add(this.ResTxt3);
            this.Controls.Add(this.ResTxt2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.MaxOperandTxt);
            this.Controls.Add(this.MinOperandTxt);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.ResTxt1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.singLbl);
            this.Controls.Add(this.num11);
            this.Controls.Add(this.num21);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сложение и вычитание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label num21;
        private System.Windows.Forms.Label singLbl;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox ResTxt1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox MinOperandTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxOperandTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResTxt2;
        private System.Windows.Forms.TextBox ResTxt3;
        private System.Windows.Forms.TextBox ResTxt4;
        private System.Windows.Forms.Label num11;
        private System.Windows.Forms.TextBox wins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button2;
    }
}

