namespace WinFormsApp1
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
            btnadd = new Button();
            btnrmv = new Button();
            label1 = new Label();
            Animetxtbx = new TextBox();
            enteranm = new Label();
            label2 = new Label();
            Genretxtbx = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.SaddleBrown;
            btnadd.ForeColor = Color.Bisque;
            btnadd.Location = new Point(314, 94);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(81, 33);
            btnadd.TabIndex = 1;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnrmv
            // 
            btnrmv.BackColor = Color.SaddleBrown;
            btnrmv.ForeColor = Color.Bisque;
            btnrmv.Location = new Point(168, 413);
            btnrmv.Name = "btnrmv";
            btnrmv.Size = new Size(84, 34);
            btnrmv.TabIndex = 2;
            btnrmv.Text = "Remove";
            btnrmv.UseVisualStyleBackColor = false;
            btnrmv.Click += btnrmv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(96, 22);
            label1.Name = "label1";
            label1.Size = new Size(228, 26);
            label1.TabIndex = 3;
            label1.Text = "Anime Watchlist";
            // 
            // Animetxtbx
            // 
            Animetxtbx.BackColor = Color.Bisque;
            Animetxtbx.Location = new Point(138, 82);
            Animetxtbx.Name = "Animetxtbx";
            Animetxtbx.Size = new Size(160, 23);
            Animetxtbx.TabIndex = 4;
            // 
            // enteranm
            // 
            enteranm.AutoSize = true;
            enteranm.BackColor = Color.Tan;
            enteranm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enteranm.ForeColor = Color.SaddleBrown;
            enteranm.Location = new Point(28, 82);
            enteranm.Name = "enteranm";
            enteranm.Size = new Size(104, 21);
            enteranm.TabIndex = 5;
            enteranm.Text = "Enter Anime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(23, 116);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 6;
            label2.Text = "Anime Genre";
            // 
            // Genretxtbx
            // 
            Genretxtbx.BackColor = Color.Bisque;
            Genretxtbx.Location = new Point(138, 116);
            Genretxtbx.Name = "Genretxtbx";
            Genretxtbx.Size = new Size(160, 23);
            Genretxtbx.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Bisque;
            listView1.ForeColor = Color.SaddleBrown;
            listView1.Location = new Point(23, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(372, 237);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(434, 477);
            Controls.Add(listView1);
            Controls.Add(Genretxtbx);
            Controls.Add(label2);
            Controls.Add(enteranm);
            Controls.Add(Animetxtbx);
            Controls.Add(label1);
            Controls.Add(btnrmv);
            Controls.Add(btnadd);
            Name = "Form1";
            Text = "Anime Watchlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnadd;
        private Button btnrmv;
        private Label label1;
        private TextBox Animetxtbx;
        private Label enteranm;
        private Label label2;
        private TextBox Genretxtbx;
        private ListView listView1;
    }
}
