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
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.author = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.LinkLabel();
            this.content = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.result_pan = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.result_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 56);
            this.panel1.TabIndex = 2;
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date.Location = new System.Drawing.Point(217, 68);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(168, 20);
            this.date.TabIndex = 3;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.picture);
            this.panel2.Controls.Add(this.author);
            this.panel2.Controls.Add(this.url);
            this.panel2.Controls.Add(this.content);
            this.panel2.Controls.Add(this.description);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(9, 109);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 247);
            this.panel2.TabIndex = 4;
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(0, 234);
            this.author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(38, 13);
            this.author.TabIndex = 11;
            this.author.Text = "Author";
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(2, 208);
            this.url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(20, 13);
            this.url.TabIndex = 10;
            this.url.TabStop = true;
            this.url.Text = "Url";
            this.url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.url_LinkClicked);
            // 
            // content
            // 
            this.content.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.content.BackColor = System.Drawing.SystemColors.Control;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(-2, 68);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(405, 101);
            this.content.TabIndex = 8;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(-5, 28);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(595, 46);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-6, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(596, 28);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(9, 67);
            this.previous.Margin = new System.Windows.Forms.Padding(2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(56, 19);
            this.previous.TabIndex = 5;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.next.Enabled = false;
            this.next.Location = new System.Drawing.Point(535, 68);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(56, 19);
            this.next.TabIndex = 6;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // result_pan
            // 
            this.result_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_pan.Controls.Add(this.error);
            this.result_pan.Controls.Add(this.close);
            this.result_pan.Controls.Add(this.result);
            this.result_pan.Controls.Add(this.label2);
            this.result_pan.Location = new System.Drawing.Point(81, 93);
            this.result_pan.Name = "result_pan";
            this.result_pan.Size = new System.Drawing.Size(439, 272);
            this.result_pan.TabIndex = 12;
            this.result_pan.Visible = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(189, 245);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 19);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(159, 53);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 21);
            this.result.TabIndex = 3;
            this.result.SelectedIndexChanged += new System.EventHandler(this.result_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Results";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(141, 137);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(157, 18);
            this.error.TabIndex = 14;
            this.error.Text = "No Results on this date!";
            this.error.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "THE WALL STREET JOURNAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(425, 68);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(154, 101);
            this.picture.TabIndex = 12;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.result_pan);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.result_pan.ResumeLayout(false);
            this.result_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.LinkLabel url;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Panel result_pan;
        private System.Windows.Forms.ComboBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture;
    }
}

