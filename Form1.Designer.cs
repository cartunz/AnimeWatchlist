namespace AnimeWatchlist
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
            lbl1 = new Label();
            lbl2 = new Label();
            listBox1 = new ListBox();
            inputtxbox = new TextBox();
            addbtn = new Button();
            removebtn = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(46, 51);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(119, 22);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enter Anime :";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(45, 125);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(222, 26);
            lbl2.TabIndex = 1;
            lbl2.Text = "My Anime Watchlist";
            lbl2.Click += lbl2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 184);
            listBox1.TabIndex = 2;
            // 
            // inputtxbox
            // 
            inputtxbox.Location = new Point(171, 50);
            inputtxbox.Name = "inputtxbox";
            inputtxbox.Size = new Size(229, 23);
            inputtxbox.TabIndex = 3;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(416, 50);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(84, 25);
            addbtn.TabIndex = 4;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // removebtn
            // 
            removebtn.Location = new Point(219, 369);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(91, 27);
            removebtn.TabIndex = 5;
            removebtn.Text = "button1";
            removebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(inputtxbox);
            Controls.Add(listBox1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private ListBox listBox1;
        private TextBox inputtxbox;
        private Button addbtn;
        private Button removebtn;
    }
}
