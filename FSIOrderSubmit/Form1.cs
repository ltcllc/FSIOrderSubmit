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
using System.Xml;
using System.Xml.Serialization;
using Models.OrderServiceV5;
using System.IO;
using FSIOrderSubmit.Models.OrderServiceV5;


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
            var orderService = new FsiOrderServiceV5();


            var fs = new FileStream(fileName, FileMode.Open);


            var reader = new StreamReader(fs);


            string orderXml = reader.ReadToEnd();


            reader.Close();
            fs.Close();


            var orderServiceResponse = await orderService.SendOrder(orderXml);


            if (orderServiceResponse.ResponseMessage.IsSuccessStatusCode)
            {
                //do success stuff
                var serializer = new XmlSerializer(typeof(Success));
                var sr = new StringReader(orderServiceResponse.Content);

                //serialize the successful response
                success = (Success)serializer.Deserialize(sr);


                //Get the order Id
                Guid orderId = success.OrderId;

                // Get the directories currently on the C drive.
                // DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

                //write to log file
                try
                {
                    using (StreamWriter sw = new StreamWriter("C:/Users/user/Desktop/SuccessLog.txt"))
                    {
                        sw.WriteLine(success.OrderId);
                    }
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Directory could not be found");
                }
                


                //move file to archive


                sr.Close();
            }
            else
            {
                //do fail stuff
                var serializer = new XmlSerializer(typeof(Fail));
                var sr = new StringReader(orderServiceResponse.Content);


                //serialize the failed response
                fail = (Fail)serializer.Deserialize(sr);

                sr.Close();
                //print the errors to the console
                //write to log file

                //Get the directories currently on the C drive
                //DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

                //write to log file

                try {
                    using (StreamWriter sw = new StreamWriter("C:/Users/user/Desktop/ErrorLog.txt"))
                    {
                        fail.Errors.ForEach(a => Console.WriteLine(a));   
                        //Console.WriteLine(Fail.Errors);
                    }
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Directory could not be found.");
                }



            }
        }


        private void bProcessFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileNames.ToList().ForEach(a => ProcessOrder(a));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excelda FSI Order Submission 1.0\nWritten by L Trammer Consulting LLC", "About");
        }
    }
}
