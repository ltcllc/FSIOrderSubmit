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

namespace FSIOrderSubmit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }


        public async void ProcessOrder(string fileName)
        {            
            var fail = new Fail();
            var success = new Success();

            var fs = new FileStream(fileName, FileMode.Open);

            var reader = new StreamReader(fs);

            string orderXml = reader.ReadToEnd();

            var response = SendOrderToFSI(orderXml);

            var responseData = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                //do success stuff
                var serializer = new XmlSerializer(typeof(Success));
                var sr = new StringReader(responseData);

                //serialize the successful response
                success = (Success) serializer.Deserialize(sr);

                //Get the order Id
                Guid orderId = success.OrderId;

                //write to log file

                //move file to archive
            }
            else
            {
                //do fail stuff
                var serializer = new XmlSerializer(typeof(Fail));
                var sr = new StringReader(responseData);

                //serialize the failed response
                fail = (Fail) serializer.Deserialize(sr);

                //print the errors to the console
                //change to write to a log file
                fail.Errors.ForEach(a => Console.WriteLine(a));

                //require input so the console does not close
                Console.ReadKey();
            }
        }

        private static HttpResponseMessage SendOrderToFSI(string orderXml)
        {
            var orderService = new FsiOrderServiceV5();
            return orderService.SendOrder(orderXml).Result;
        }

        private void bProcessFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileNames.ToList().ForEach(a => ProcessOrder(a));
        }

        private void bSelectFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
