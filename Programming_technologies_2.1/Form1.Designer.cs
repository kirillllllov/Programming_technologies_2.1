namespace Programming_technologies_2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnteredCopecks = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // EnteringCopecks
            // 
            EnteredCopecks.Location = new Point(10, 43);
            EnteredCopecks.Name = "EnteringCopecks";
            EnteredCopecks.Size = new Size(776, 23);
            EnteredCopecks.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(10, 72);
            button1.Name = "button1";
            button1.Size = new Size(778, 23);
            button1.TabIndex = 1;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(EnteredCopecks);
            Name = "Form1";
            Text = "Сonversion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EnteredCopecks;
        private Button button1;
    }
}
