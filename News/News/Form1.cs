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

namespace News
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static HttpClient client = new HttpClient();
        Rootobject articolo = new Rootobject();
        List<int>results = new List<int>();
        int i = 0;

        async Task<Rootobject> get()
        {
            string url = "https://newsapi.org/v2/everything?domains=wsj.com&apiKey=a6412302f797446fb5d0cee1c946e308";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                articolo = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
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
        private void completeSearch(int n)
        {
            title_search.Text = articolo.articles[n].title;
            txt_search.Text = articolo.articles[n].description;
            WebRequest wb = WebRequest.Create(articolo.articles[n].urlToImage);
            using (var response = wb.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    img_search.Image = Bitmap.FromStream(str);
                }
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

        private void date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(articolo.articles[i].url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            result_pan.Visible = false;
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = results[result.SelectedIndex];
            complete(results[result.SelectedIndex]);
            result_pan.Visible = false;
            error.Visible = false;
        }

        private void date_DropDown(object sender, EventArgs e)
        {
            
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
                    result.Items.Add(articolo.articles[n].title);
                    results.Add(n);
                }
            }
            if (results.Count == 0)
            {
                error.Visible = true;
                txt_search.Visible = false;
                img_search.Visible = false;
                title_search.Visible = false;
            }
            else
            {
                completeSearch(results[0]);
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
                    completeSearch(results[0]);
                }

            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void title_search_Click(object sender, EventArgs e)
        {
            complete(results[0]);
            result_pan.Visible = false;
            error.Visible = false;
        }
    }
}