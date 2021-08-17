using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Exile_Payment_Reminder
{
    class WebRequests
    {
        //public static HttpWebRequest request;

        public enum WebRequestStatusCode
        {
            OK,
            StatusNotOK,
            OperationTimedOut,
            TryCatchFailed,

        }
        public static string createWebRequest(string url)
        {
            if (frmMain.isDebug)
                return string.Empty;

            string responseValue = "";
            string webRequestExceptionString = string.Empty;
            WebRequestStatusCode status = new WebRequestStatusCode();

            //var thread = new Thread(() =>
            //{
                try
                {
                    string aUrl = url;
                    HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                    request.Method = "GET";
                    request.ContentType = "text";
                    request.Timeout = 6000;
                    request.Proxy = null;
                    request.KeepAlive = false;
                    request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";

                    using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                    {

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            Stream receiveStream = response.GetResponseStream();
                            StreamReader readStream = null;

                            if (response.CharacterSet == null)
                            {
                                readStream = new StreamReader(receiveStream);
                            }
                            else
                            {
                                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                            }

                            responseValue = readStream.ReadToEnd();

                            readStream.Close();
                            receiveStream.Close();
                        }
                        else
                        {
                            webRequestExceptionString = response.StatusDescription;
                            status = WebRequestStatusCode.StatusNotOK;
                        }
                    }

                }
                catch (Exception ex)
                {
                    webRequestExceptionString = ex.Message;
                    status = WebRequestStatusCode.TryCatchFailed;
                }
            //});

            //thread.Start();
            //thread.Join();

            frmMain.ActiveForm.Invoke((MethodInvoker) delegate ()
            {
                switch (status)
                {
                    case WebRequestStatusCode.OK:
                        break;
                    case WebRequestStatusCode.OperationTimedOut:
                        responseValue = string.Empty;
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Operation Timed Out", body: "Requested HTTPWebRequest Operation Timed Out");
                        break;
                    case WebRequestStatusCode.StatusNotOK:
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "HttpWebRequest Status Not OK", body: webRequestExceptionString);
                        responseValue = string.Empty;
                        break;
                    case WebRequestStatusCode.TryCatchFailed:
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Try and Catch Failed", body: webRequestExceptionString);
                        responseValue = string.Empty;
                        break;
                }
            });

            return responseValue;
        }
    }
}
