using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml.Serialization;
using Models.OrderServiceV5;
using System.IO;
using FSIOrderSubmit.Models.OrderServiceV5;
using FSIOrderSubmit.Models.OrderStatus;

namespace FSIOrderSubmit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                       
        }


        private void ProcessOrder(string fileName)
        {
            if (!ValidConfiguration())
                return;

            var fail = new Fail();
            var success = new Success();
            var orderService = new FsiOrderServiceV5();

            var fs = new FileStream(fileName, FileMode.Open);

            var reader = new StreamReader(fs);

            string orderXml = reader.ReadToEnd();

            reader.Close();
            fs.Close();

            var orderServiceResponse = orderService.SendOrder(orderXml);

            if (orderServiceResponse.ResponseMessage.IsSuccessStatusCode)
            {
                //do success stuff
                var serializer = new XmlSerializer(typeof(Success));
                var sr = new StringReader(orderServiceResponse.Content);

                //serialize the successful response
                success = (Success) serializer.Deserialize(sr);

                //Get the order Id
                Guid orderId = success.OrderId;

                //write to log file

            }
            else
            {
                //do fail stuff
                var serializer = new XmlSerializer(typeof(Fail));
                var sr = new StringReader(orderServiceResponse.Content);

                //serialize the failed response
                fail = (Fail) serializer.Deserialize(sr);

                sr.Close();

                //write to error log


            }
        }

        private async void ProcessOrderAsync(string fileName)
        {
            if (!ValidConfiguration())
                return;

            var fail = new Fail();
            var success = new Success();
            var orderService = new FsiOrderServiceV5();

            var fs = new FileStream(fileName, FileMode.Open);

            var reader = new StreamReader(fs);

            string orderXml = reader.ReadToEnd();

            reader.Close();
            fs.Close();

            var orderServiceResponse = await orderService.SendOrderAsync(orderXml);

            if (orderServiceResponse.ResponseMessage.IsSuccessStatusCode)
            {
                //do success stuff
                var serializer = new XmlSerializer(typeof(Success));
                var sr = new StringReader(orderServiceResponse.Content);

                //serialize the successful response
                success = (Success) serializer.Deserialize(sr);

                //Get the order Id
                Guid orderId = success.OrderId;

                //write to log file

            }
            else
            {
                //do fail stuff
                var serializer = new XmlSerializer(typeof(Fail));
                var sr = new StringReader(orderServiceResponse.Content);

                //serialize the failed response
                fail = (Fail) serializer.Deserialize(sr);

                sr.Close();

                //write to error log


            }
        }

        private void GetOrderStatus(Guid orderId)
        {
            var fail = new Fail();
            var success = new Success();
            var orderService = new FsiOrderServiceV5();           

            var orderStatusResponse = orderService.GetOrderStatus(orderId);

            if (orderStatusResponse.ResponseMessage.IsSuccessStatusCode)
            {
                //do success stuff
                string xml = orderStatusResponse.Content;
                var serializer = new XmlSerializer(typeof(OrderStatusData));
                var sr = new StringReader(orderStatusResponse.Content);

                //serialize the successful response
                success = (Success) serializer.Deserialize(sr);

                

                //write to log file

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(orderStatusResponse.Content))
                {
                    //do fail stuff
                    var serializer = new XmlSerializer(typeof(Fail));
                    var sr = new StringReader(orderStatusResponse.Content);

                    //serialize the failed response
                    fail = (Fail) serializer.Deserialize(sr);

                    sr.Close();

                    //write to error log

                }
            }            
        }


        private void bProcessFiles_Click(object sender, EventArgs e)
        {
            lblMessage.Text = $"Processing {openFileDialog1.FileNames.Count()} files";
            if (!chkAsync.Checked)
                openFileDialog1.FileNames.ToList().ForEach(a => ProcessOrder(a));
            else
                openFileDialog1.FileNames.ToList().ForEach(a => ProcessOrderAsync(a));
            lblMessage.Text = "Done.";
        }

        private void bSelectFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void menuConfiguration_Click(object sender, EventArgs e)
        {
            Configuration configurationWindow = new Configuration();
            configurationWindow.ShowDialog();
        }

        public bool ValidConfiguration()
        {
            bool result = false;

            var errorList = new List<string>();

            if (FSIOrderSubmit.Properties.Settings.Default.TestMode == true)
            {
                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.TestCreateOrderRequestUri))
                {
                    errorList.Add("TestCreateOrderRequestUri is required for Test orders");
                }

                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceBaseAddress))
                {
                    errorList.Add("TestOrderServiceBaseAddress is required for Test orders");
                }

                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.TestOrderServiceApiKey))
                {
                    errorList.Add("TestOrderServiceApiKey is required for Test orders");
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceBaseAddress))
                {
                    errorList.Add("LiveOrderServiceBaseAddress is required for Live orders");
                }

                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.LiveCreateOrderRequestUri))
                {
                    errorList.Add("LiveCreateOrderRequestUri is required for Live orders");
                }

                if (string.IsNullOrWhiteSpace(FSIOrderSubmit.Properties.Settings.Default.LiveOrderServiceApiKey))
                {
                    errorList.Add("LiveOrderServiceApiKey is required for Live orders");
                }
            }

            if (errorList.Any())
            {
                string errorString = string.Empty;
                errorList.ForEach(a => errorString += a + ". ");
                MessageBox.Show(errorString);
                result = false;
            }
            else
                result = true;


            return result;
        }

        private void bOrderStatusTest_Click(object sender, EventArgs e)
        {
            Guid testOrderId = new Guid("0EAB4069-FEA2-4CB7-9019-69082C17CB31");
            GetOrderStatus(testOrderId);
        }
    }
}
