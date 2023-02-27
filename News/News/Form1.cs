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

        private async void button1_Click(object sender, EventArgs e)
        {
            await get();
        }
        async Task<Rootobject> get()
        {
            Rootobject product = null;
            string url = "https://newsapi.org/v2/everything?domains=wsj.com&apiKey=a6412302f797446fb5d0cee1c946e308";
            HttpResponseMessage response = await client.GetAsync(url);
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(product.tostring());
                label1.Text = product.tostring();
            }
            return product;
        }
    }
}