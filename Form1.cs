using Newtonsoft.Json;
using PteroConsole.NET;
using System.Net;

namespace PteroController
{
    
    public partial class Form1 : Form
    {
        public string serverUuid = "";
        public string panelUrl = "";
        public string clientKey = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnfetch_Click(object sender, EventArgs e)
        {
            serverUuid = txtsvid.Text;
            panelUrl = txtpanelurl.Text;
            clientKey = txtclientkey.Text;
            var console = new PteroConsole.NET.PteroConsole();
            console.OnConnectionStateUpdated += (sender, state) =>
            {
                Console.WriteLine($"Console status: {state}");
            };

            console.OnServerResourceUpdated += (sender, resource) =>
            {
                Console.WriteLine($"Stats: {resource.Uptime}, State: {resource.State}");
            };

            console.OnServerStateUpdated += (sender, state) =>
            {
                Console.WriteLine($"State: {state}");
            };

            console.RequestToken += pteroConsole =>
            {
                Console.WriteLine("Revoking token");
                var wc = new WebClient();
                wc.Headers.Add("Authorization", "Bearer " + clientKey);
                var raw = wc.DownloadString($"{panelUrl}api/client/servers/{serverUuid}/websocket");
                var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
                return data.Token;
            };

            console.OnMessage += (sender, s) =>
            {
                Console.WriteLine("Output: " + s);
            };

            var wc = new WebClient();
            wc.Headers.Add("Authorization", "Bearer " + clientKey);
            var raw = wc.DownloadString($"{panelUrl}api/client/servers/{serverUuid}/websocket");
            var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;

            await console.Connect(panelUrl, data.Socket, data.Token);
        }
    }
}