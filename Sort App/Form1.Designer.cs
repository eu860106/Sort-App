namespace Sort_App
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Sort_Button = new System.Windows.Forms.Button();
            this.Number_input = new System.Windows.Forms.TextBox();
            this.Sort_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Random_minimum = new System.Windows.Forms.TextBox();
            this.Random_maximum = new System.Windows.Forms.TextBox();
            this.Random_number = new System.Windows.Forms.TextBox();
            this.random_generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sort_Button
            // 
            this.Sort_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_Button.Location = new System.Drawing.Point(519, 68);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(62, 42);
            this.Sort_Button.TabIndex = 0;
            this.Sort_Button.Text = "Sort";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Number_input
            // 
            this.Number_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_input.Location = new System.Drawing.Point(134, 68);
            this.Number_input.Name = "Number_input";
            this.Number_input.Size = new System.Drawing.Size(361, 26);
            this.Number_input.TabIndex = 3;
            // 
            // Sort_output
            // 
            this.Sort_output.AutoSize = true;
            this.Sort_output.BackColor = System.Drawing.Color.White;
            this.Sort_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_output.Location = new System.Drawing.Point(61, 233);
            this.Sort_output.Name = "Sort_output";
            this.Sort_output.Size = new System.Drawing.Size(0, 20);
            this.Sort_output.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cocktail Sort";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(86, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "請依序輸入欲排列的整數，數字間請以空白鍵分割，若輸入格式錯誤將會回傳Error";
            // 
            // Random_minimum
            // 
            this.Random_minimum.Location = new System.Drawing.Point(148, 169);
            this.Random_minimum.Name = "Random_minimum";
            this.Random_minimum.Size = new System.Drawing.Size(49, 22);
            this.Random_minimum.TabIndex = 7;
            this.Random_minimum.Text = "0";
            // 
            // Random_maximum
            // 
            this.Random_maximum.Location = new System.Drawing.Point(274, 169);
            this.Random_maximum.Name = "Random_maximum";
            this.Random_maximum.Size = new System.Drawing.Size(49, 22);
            this.Random_maximum.TabIndex = 8;
            this.Random_maximum.Text = "100";
            // 
            // Random_number
            // 
            this.Random_number.Location = new System.Drawing.Point(416, 169);
            this.Random_number.Name = "Random_number";
            this.Random_number.Size = new System.Drawing.Size(52, 22);
            this.Random_number.TabIndex = 9;
            this.Random_number.Text = "5";
            // 
            // random_generate
            // 
            this.random_generate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.random_generate.Location = new System.Drawing.Point(519, 158);
            this.random_generate.Name = "random_generate";
            this.random_generate.Size = new System.Drawing.Size(90, 41);
            this.random_generate.TabIndex = 10;
            this.random_generate.Text = "數列生成";
            this.random_generate.UseVisualStyleBackColor = true;
            this.random_generate.Click += new System.EventHandler(this.random_generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "隨機生成數列";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(62, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "數列最小值 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(213, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "最大值 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(342, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "生成數量 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(86, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "條件 : 0 <= 最小值 <  最大值，生成數量必須 > 1，否則不會生成數列";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(60, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "數列輸入 : ";
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(587, 68);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(70, 42);
            this.Reset_button.TabIndex = 17;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(681, 593);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.random_generate);
            this.Controls.Add(this.Random_number);
            this.Controls.Add(this.Random_maximum);
            this.Controls.Add(this.Random_minimum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sort_output);
            this.Controls.Add(this.Number_input);
            this.Controls.Add(this.Sort_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.TextBox Number_input;
        private System.Windows.Forms.Label Sort_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Random_minimum;
        private System.Windows.Forms.TextBox Random_maximum;
        private System.Windows.Forms.TextBox Random_number;
        private System.Windows.Forms.Button random_generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Reset_button;
    }
}

