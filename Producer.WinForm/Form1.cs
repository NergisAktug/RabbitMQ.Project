using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Producer.WinForm
{
    public partial class frmMain : Form
    {
        private bool _isConnectionOpen;
        private bool isConnectionOpen
        {
            get => _isConnectionOpen;
            set
            {
                _isConnectionOpen = value;
                ConnectionStateChanged();
            }
        }

        private IConnection connection;//Default connection
        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel());

        public frmMain()
        {
            InitializeComponent();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();
            pnlMain.Enabled = gbQueueExchange.Enabled = isConnectionOpen;
        }
        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "": "Not ")}Connected\n";
            tsLblConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"\n Connection state is {state}");
        }

       
        private void AddLog(string logStr)
        {
            logStr = $"\n [ {DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.Items.Add($"\n  {logStr}\n");
            //txtLog.SelectionStart = txtLog.Text.Length;
            //txtLog.ScrollToCaret();
        }

        private void Init()
        {
            //ExchangeTypes

            cbDeclareExchangeType.Items.Add("direct");
            cbDeclareExchangeType.Items.Add("fanout");
            cbDeclareExchangeType.Items.Add("headers");
            cbDeclareExchangeType.Items.Add("topic");

            cbDeclareExchangeType.SelectedIndex = 0;
        }

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                // hangi port'tan rabbitmq'ya bağlanılacağı bilgisi girilir
                Uri = new Uri(txtConnectionString.Text)
               /*HostName = "192.168.1.100",
                Port= 5672,
                UserName = "nergis",
                Password="nergis"*/
            };
         
            return factory.CreateConnection();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection==null)
            {
                connection = GetConnection();
            }
            else
                connection.Close();

            isConnectionOpen = connection.IsOpen;
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
           //chanell'i kullanarak bir exchange yaratmak gerekiyor.

            channel.ExchangeDeclare(txtDeclareExchangeName.Text,cbDeclareExchangeType.Text);

            //Oluşutulan exchange log olarak bir ekrana basiliyor,

            AddLog($"\n Exchange created with Name: {txtDeclareExchangeName.Text}, Type: {cbDeclareExchangeType.Text}");

        }

        private void btnDeclareQueue_Click(object sender, EventArgs e)
        {
            //Queue yaratılıyor;

            channel.QueueDeclare(txtDeclareQueueName.Text,false,exclusive:false);

            AddLog($"\n Query created with Name: {txtDeclareQueueName.Text} ");

        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            //Burada Queue ile Exchange Bind ediliyor
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtDeclareQueueRoutingKey.Text);
            AddLog($"\n Queue created with Name: {txtDeclareQueueName.Text}, Exchange Name: {txtDeclareExchangeName.Text} , Type: {cbDeclareExchangeType.Text}");

        }

        private void WriteDataToExchange(string exchangeName, string routingKey, object data)
        {
            //gelen datayı önce stringe sonrada bytearray'e ceviriyoruz..
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(exchangeName, routingKey,null,dataArr);
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            //send_mail adında bir query oluşturduk buraya kadar şimdi bu query'de taşınacak datayı uygun hale getiren metodu cagiriyoruz.

            var message = txtMessage.Text;

            for (int i = 0; i < numericRepeatCount.Value; i++)
            {
                if (chUseCounter.Checked)
                    message = $"[{i+1}]- {txtMessage.Text}";

                WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text,message);
            }

            
            
        }
    }
}
