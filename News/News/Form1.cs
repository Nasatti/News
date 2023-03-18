using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace News
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            result.DropDownStyle = ComboBoxStyle.DropDown;
        }

        static HttpClient client = new HttpClient();
        Rootobject articolo = new Rootobject();
        List<int>results = new List<int>();
        List<string> auth = new List<string>();   
        int i = 0;

        async Task<Rootobject> get()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.31.3");
            var rurl = "https://newsapi.org/v2/everything?domains=wsj.com";
            var apiKey = "a6412302f797446fb5d0cee1c946e308";
            var url = $"{rurl}&apiKey={apiKey}";
            
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                articolo = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                for (int i = 0; i < articolo.articles.Count(); i++)
                {
                    if (!auth.Contains(articolo.articles[i].author)) auth.Add(articolo.articles[i].author);
                }
                auth.Sort();
                foreach(string a in auth)
                {
                    if(a!= null) comboBox_authors.Items.Add(a);
                }
                complete(i);
            }
            else
            {
                
            }
            return articolo;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await get();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (i > (articolo.articles.Count() - 3))
            {
                previous.Enabled = false;
            }
            i++;
            complete(i);
            next.Enabled = true;
        }
        private void complete(int n)
        {
            title.Text = articolo.articles[n].title;
            description.Text = articolo.articles[n].description;
            content.Text = articolo.articles[n].content;
            url.Text = articolo.articles[n].url;
            author.Text = "Author: " + articolo.articles[n].author;
            date.Value = articolo.articles[n].publishedAt;
            WebRequest wb = WebRequest.Create(articolo.articles[n].urlToImage);
            using (var response = wb.GetResponse())
            {
                using(var str = response.GetResponseStream())
                {
                    picture.Image = Bitmap.FromStream(str);
                }
            }
            result_pan.Visible = false;
        }
        private void completeSearch(List<int> results)
        {
            int w = 550; int h = 170;
            int y = 137;
            int num = 0;
            foreach(int r in results)
            {
                Panel panel = new Panel();
                panel.Name = "panel_" + num.ToString();
                panel.Size = new Size(w, h);
                panel.Location = new Point(12, y);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                

                System.Windows.Forms.Label title_search = new System.Windows.Forms.Label();
                title_search.Text = articolo.articles[r].title;
                title_search.AutoSize = true;
                title_search.Font = new Font("Modern No. 20", this.title.Font.Size);
                title_search.Location = new Point(5,5);
                title_search.Cursor = System.Windows.Forms.Cursors.Hand;
                title_search.Click += (sender, e) =>
                {
                    i = r;
                    complete(r);
                    result_pan.Visible = false;
                    error.Visible = false;
                    CleanSearch();
                    if (i != 0) next.Enabled = true;
                    else next.Enabled = false;

                    if (i > (articolo.articles.Count() - 3)) previous.Enabled = false;
                    else previous.Enabled = true;
                };
                panel.Controls.Add(title_search);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = w - 100;
                pictureBox.Height = h - 15 - title_search.Height - 35;
                pictureBox.Location = new Point(5, title_search.Height + 10);
                pictureBox.Size = new Size(205, 124);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                WebRequest wb = WebRequest.Create(articolo.articles[r].urlToImage);
                using (var response = wb.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBox.Image = Bitmap.FromStream(str);
                    }
                }
                panel.Controls.Add(pictureBox);

                System.Windows.Forms.TextBox description_search = new System.Windows.Forms.TextBox();
                description_search.Text = articolo.articles[r].description;
                description_search.AutoSize = true;
                description_search.Font = new Font("Cambria", this.content.Font.Size);
                description_search.Location = new Point(210, title_search.Height + 10);
                description_search.Size = new Size(300, 124);
                description_search.Multiline = true;
                description_search.Enabled = false;
                panel.Controls.Add(description_search);

                y += 200;
                this.result_pan.Controls.Add(panel);
                panel.BringToFront();
                this.Refresh();
                num++;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            i--;
            complete(i);
            if (i == 0)
            {
                next.Enabled = false;
            }
            previous.Enabled = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            result_pan.Visible = false;
            CleanSearch();
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = results[result.SelectedIndex];
            complete(results[result.SelectedIndex]);
            result_pan.Visible = false;
            error.Visible = false;
            CleanSearch();
            if (i != 0) next.Enabled = true;
            else next.Enabled = false;

            if (i > (articolo.articles.Count() - 3)) previous.Enabled = false;
            else previous.Enabled = true;
        }
        private void date_CloseUp(object sender, EventArgs e)
        {
            error.Visible = false;
            result.Items.Clear();
            results.Clear();
            result_pan.Visible = true;
            string data2 = date.Value.ToString().Substring(0, 10);
            string data1;
            for (int n = 0; n < articolo.articles.Length; n++)
            {
                data1 = articolo.articles[n].publishedAt.ToString().Substring(0, 10);
                if (data1 == data2)
                {
                    if (articolo.articles[n].title != null)
                    {
                        result.Items.Add(articolo.articles[n].title);
                        results.Add(n);
                    }
                }
            }
            if (results.Count == 0)
            {
                error.Visible = true;
            }
            else
            {
                completeSearch(results);
                if (i != 0) next.Enabled = true;
                else next.Enabled = false;

                if (i > (articolo.articles.Count() - 3)) previous.Enabled = false;
                else previous.Enabled = true;
            }
        }

        private void brn_ricerca_Click(object sender, EventArgs e)
        {
            if (txt_ricerca.Text != "")
            {
            error.Visible = false;
            result.Items.Clear();
            results.Clear();
            result_pan.Visible = true;
            
                string result1;
                string result2 = txt_ricerca.Text;

                for (int n = 0; n < articolo.articles.Length; n++)
                {
                    result1 = articolo.articles[n].title;
                    if (result1 != null)
                    {
                        if (result1.Contains(result2))
                        {
                            result.Items.Add(articolo.articles[n].title);
                            results.Add(n);
                        }
                    }
                }
                if (results.Count == 0)
                {
                    error.Visible = true;
                }
                else
                {
                    completeSearch(results);
                }

            }
        }
        private void title_search_Click(object sender, EventArgs e)
        {
            complete(results[0]);
            result_pan.Visible = false;
            error.Visible = false;
        }
        private void CleanSearch()
        {
            if (this.result_pan.Controls.ContainsKey("panel_0") && this.result_pan.Controls["panel_0"].GetType() == typeof(Panel))
            {

                int num = 0;
                foreach (int r in results)
                {
                    string panelName = "panel_" + num.ToString();
                    Panel panel_delete = (Panel)this.result_pan.Controls[panelName];
                    panel_delete.Dispose();
                    num++;
                }
            }
        }

        private void url_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(articolo.articles[i].url);
        }

        private void comboBox_authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            error.Visible = false;
            result.Items.Clear();
            results.Clear();
            result_pan.Visible = true;

            string result1;
            string result2 = auth[comboBox_authors.SelectedIndex + 1];
            i = comboBox_authors.SelectedIndex + 1;
            for (int n = 0; n < articolo.articles.Length; n++)
            {
                result1 = articolo.articles[n].author;
                if (result1 != null)
                {
                    if (result1 == result2)
                    {
                        if (articolo.articles[n].title != null)
                        {
                            result.Items.Add(articolo.articles[n].title);
                            results.Add(n);
                        }
                    }
                }
            }
            if (results.Count == 0)
            {
                error.Visible = true;
            }
            else
            {
                completeSearch(results);
            }
        }
        private void txt_ricerca_Click(object sender, EventArgs e)
        {
            txt_ricerca.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                brn_ricerca.PerformClick();
            }
        }
    }
}