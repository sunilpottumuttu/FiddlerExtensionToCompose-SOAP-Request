using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace SOAPRequestComposer
{
    public partial class SOAPRequestComposer : UserControl
    {
        public SOAPRequestComposer()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            SendSOAPRequest();
        }

        public void SendSOAPRequest()
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(@rtbRequest.Text);

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    rtbResponse.Text = FormatXml(soapResult);
                }
            }
        }
        /// <summary>
        /// Create a soap webrequest to [Url]
        /// </summary>
        /// <returns></returns>
        public HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@txtURL.Text);
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }

        private void btnLoadSample_Click(object sender, EventArgs e)
        {
            txtURL.Text = @"http://www.w3schools.com/webservices/tempconvert.asmx?op=CelsiusToFahrenheit";

            Assembly assem = this.GetType().Assembly;
            var assemblyName= "SOAPRequestComposer";
            string fileName = string.Format("{0}.{1}", assemblyName, "SampleSOAPRequest.txt");
            using (Stream stream = assem.GetManifestResourceStream(fileName))
            {
                using (var reader = new StreamReader(stream))
                {
                    rtbRequest.Text= FormatXml(reader.ReadToEnd());
                }

            }
        }
    }
}
