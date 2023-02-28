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
            i++;
            complete(i);
        }
        private void complete(int n)
        {
                title.Text = articolo.articles[n].title;
                description.Text = articolo.articles[n].description;
                content.Text = articolo.articles[n].content;
        }
    }
}