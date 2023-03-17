namespace News
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.result_pan = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.txt_ricerca = new System.Windows.Forms.TextBox();
            this.brn_ricerca = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.author = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.LinkLabel();
            this.content = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.result_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 68);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 426);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "THE WALL STREET JOURNAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // result_pan
            // 
            this.result_pan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_pan.AutoScroll = true;
            this.result_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_pan.Controls.Add(this.error);
            this.result_pan.Controls.Add(this.close);
            this.result_pan.Controls.Add(this.result);
            this.result_pan.Controls.Add(this.label2);
            this.result_pan.Location = new System.Drawing.Point(5, 65);
            this.result_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result_pan.Name = "result_pan";
            this.result_pan.Size = new System.Drawing.Size(790, 390);
            this.result_pan.TabIndex = 12;
            this.result_pan.Visible = false;
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(296, 105);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(196, 23);
            this.error.TabIndex = 14;
            this.error.Text = "No Results on this date!";
            this.error.Visible = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(697, 18);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(314, 65);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(160, 24);
            this.result.TabIndex = 3;
            this.result.SelectedIndexChanged += new System.EventHandler(this.result_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Results";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date.Location = new System.Drawing.Point(289, 97);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 22);
            this.date.TabIndex = 3;
            this.date.CloseUp += new System.EventHandler(this.date_CloseUp);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            this.date.DropDown += new System.EventHandler(this.date_DropDown);
            // 
            // previous
            // 
            this.previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous.Location = new System.Drawing.Point(12, 82);
            this.previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 5;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Enabled = false;
            this.next.Location = new System.Drawing.Point(713, 84);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 6;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txt_ricerca
            // 
            this.txt_ricerca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ricerca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ricerca.Location = new System.Drawing.Point(289, 68);
            this.txt_ricerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ricerca.Name = "txt_ricerca";
            this.txt_ricerca.Size = new System.Drawing.Size(188, 22);
            this.txt_ricerca.TabIndex = 7;
            // 
            // brn_ricerca
            // 
            this.brn_ricerca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brn_ricerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_ricerca.Image = ((System.Drawing.Image)(resources.GetObject("brn_ricerca.Image")));
            this.brn_ricerca.Location = new System.Drawing.Point(484, 65);
            this.brn_ricerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brn_ricerca.Name = "brn_ricerca";
            this.brn_ricerca.Size = new System.Drawing.Size(32, 30);
            this.brn_ricerca.TabIndex = 8;
            this.brn_ricerca.UseVisualStyleBackColor = true;
            this.brn_ricerca.Click += new System.EventHandler(this.brn_ricerca_Click);
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picture.Location = new System.Drawing.Point(573, 250);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(205, 124);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 18;
            this.picture.TabStop = false;
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(5, 427);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(45, 16);
            this.author.TabIndex = 17;
            this.author.Text = "Author";
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(35, 411);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(24, 16);
            this.url.TabIndex = 16;
            this.url.TabStop = true;
            this.url.Text = "Url";
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.SystemColors.Control;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(4, 263);
            this.content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(541, 96);
            this.content.TabIndex = 15;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(0, 171);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(793, 57);
            this.description.TabIndex = 14;
            this.description.Text = "Description";
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-3, 137);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(795, 34);
            this.title.TabIndex = 13;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Url:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_pan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.author);
            this.Controls.Add(this.url);
            this.Controls.Add(this.content);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.brn_ricerca);
            this.Controls.Add(this.txt_ricerca);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1061, 726);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.result_pan.ResumeLayout(false);
            this.result_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Panel result_pan;
        private System.Windows.Forms.ComboBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ricerca;
        private System.Windows.Forms.Button brn_ricerca;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.LinkLabel url;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

