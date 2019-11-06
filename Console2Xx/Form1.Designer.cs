namespace Console2Xx
{
    partial class Form1
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
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn2ListBox = new System.Windows.Forms.Button();
            this.btnPrintTime = new System.Windows.Forms.Button();
            this.btn2Console = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsole
            // 
            this.btnConsole.Location = new System.Drawing.Point(56, 34);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(147, 42);
            this.btnConsole.TabIndex = 0;
            this.btnConsole.Text = "OpenConsole";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(56, 82);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(147, 45);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "HideConsole";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(219, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(569, 394);
            this.listBox1.TabIndex = 2;
            // 
            // btn2ListBox
            // 
            this.btn2ListBox.Location = new System.Drawing.Point(56, 195);
            this.btn2ListBox.Name = "btn2ListBox";
            this.btn2ListBox.Size = new System.Drawing.Size(147, 51);
            this.btn2ListBox.TabIndex = 3;
            this.btn2ListBox.Text = "Console2ListBox";
            this.btn2ListBox.UseVisualStyleBackColor = true;
            this.btn2ListBox.Click += new System.EventHandler(this.btn2ListBox_Click);
            // 
            // btnPrintTime
            // 
            this.btnPrintTime.Location = new System.Drawing.Point(56, 336);
            this.btnPrintTime.Name = "btnPrintTime";
            this.btnPrintTime.Size = new System.Drawing.Size(147, 47);
            this.btnPrintTime.TabIndex = 4;
            this.btnPrintTime.Text = "OutputTime";
            this.btnPrintTime.UseVisualStyleBackColor = true;
            this.btnPrintTime.Click += new System.EventHandler(this.btnPrintTime_Click);
            // 
            // btn2Console
            // 
            this.btn2Console.Location = new System.Drawing.Point(56, 252);
            this.btn2Console.Name = "btn2Console";
            this.btn2Console.Size = new System.Drawing.Size(147, 52);
            this.btn2Console.TabIndex = 5;
            this.btn2Console.Text = "Back2Console";
            this.btn2Console.UseVisualStyleBackColor = true;
            this.btn2Console.Click += new System.EventHandler(this.btn2Console_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Console);
            this.Controls.Add(this.btnPrintTime);
            this.Controls.Add(this.btn2ListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn2ListBox;
        private System.Windows.Forms.Button btnPrintTime;
        private System.Windows.Forms.Button btn2Console;
    }
}

