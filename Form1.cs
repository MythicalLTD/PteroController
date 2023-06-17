using Newtonsoft.Json;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.Win32;


namespace PteroController
{
    public partial class Form1 : Form
    {
        public string panelUrl = "";
        public string clientKey = "";
        public string serverUuid = "";
        public static PteroConsole.NET.PteroConsole console;

        public Form1()
        {
            InitializeComponent();
        }

        public void loadSettings()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\PteroController"))
            {
                panelUrl = (string)key.GetValue("panelUrl");
                clientKey = (string)key.GetValue("clientKey");
                serverUuid = (string)key.GetValue("serverUuid");
                txtpanelurl.Text = panelUrl;
                txtpanelapikey.Text = clientKey;
                txtsvid.Text = serverUuid;
            }
        }
        private void saveSettings()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\PteroController"))
            {
                key.SetValue("panelUrl", panelUrl);
                key.SetValue("clientKey", clientKey);
                key.SetValue("serverUuid", serverUuid);

            }
        }
        private async void btnclear_Click(object sender, EventArgs e)
        {
            panelUrl = txtpanelurl.Text;
            clientKey = txtpanelapikey.Text;
            serverUuid = txtsvid.Text;
            console = new PteroConsole.NET.PteroConsole();
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
                UpdateOutput(s);
            };
            var wc = new WebClient();
            wc.Headers.Add("Authorization", "Bearer " + clientKey);
            var raw = wc.DownloadString($"{panelUrl}api/client/servers/{serverUuid}/websocket");
            var data = JsonConvert.DeserializeObject<WebsocketDataResource>(raw).Data;
            await console.Connect(panelUrl, data.Socket, data.Token);
            saveSettings();
        }

        private void UpdateOutput(string input)
        {
            string pattern = @"\x1B\[[0-?]*[ -/]*[@-~]";
            string output = Regex.Replace(input, pattern, string.Empty);

            //coutput.WriteInput(input, Color.White, true);
            Console.WriteLine(output);
        }

        private async void btnexit_Click(object sender, EventArgs e)
        {
            console = new PteroConsole.NET.PteroConsole();
            await console.Disconnect();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }
    }
}
