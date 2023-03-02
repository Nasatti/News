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
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {
                articolo = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(articolo.tostring());
                complete(i);
            }
            return articolo;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await get();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (i == (articolo.articles.Length - 1))
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
            author.Text = articolo.articles[n].author;
            date.Value = articolo.articles[n].publishedAt;
            WebRequest wb = WebRequest.Create(articolo.articles[n].urlToImage);
            //https://www.youtube.com/watch?v=sLbbzEhF0mw&ab_channel=SatellaSoft
            result_pan.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            i--;
            complete(i);
            if (i == 0)
            {
                next.Enabled = false;
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            error.Visible = false;
            result.Items.Clear();
            results.Clear();
            result_pan.Visible = true;
            for(int n = 0; n < articolo.articles.Length; n++)
            {
                string data1 = articolo.articles[n].publishedAt.ToString().Substring(0, 10);
                string data2 = date.Value.ToString().Substring(0, 10);
                if (data1 == data2)
                {
                    result.Items.Add(articolo.articles[n].title);
                    results.Add(n);
                }
            }
            if(results.Count == 0)
            {
                error.Visible = true;
            }
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
            complete(results[result.SelectedIndex]);
            result_pan.Visible = false;
            error.Visible = false;
        }
    }
}