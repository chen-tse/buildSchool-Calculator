namespace Calculator
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
            this.button_panel = new System.Windows.Forms.Panel();
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_panel
            // 
            this.button_panel.BackColor = System.Drawing.Color.White;
            this.button_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button_panel.Controls.Add(this.button1);
            this.button_panel.Location = new System.Drawing.Point(18, 135);
            this.button_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(684, 386);
            this.button_panel.TabIndex = 0;
            // 
            // display_textBox
            // 
            this.display_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_textBox.Location = new System.Drawing.Point(18, 20);
            this.display_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.display_textBox.Multiline = true;
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.Size = new System.Drawing.Size(684, 102);
            this.display_textBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(21, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(715, 535);
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.button_panel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我是計算機";
            this.button_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.TextBox display_textBox;
        private System.Windows.Forms.Button button1;
    }
}

