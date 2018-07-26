using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace WorkflowApp
{
    public static class Utilities
    {
        public static string GetConfigValue(string pKeyName)
        {
            string innerText = "";

            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\16\TEMPLATE\LAYOUTS\TechnoManagement\Customizations\Configs.xml");
            foreach (XmlNode node in document.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        if (node2.Attributes["Name"].InnerText.ToLower() == pKeyName.ToLower())
                        {
                            innerText = node2.Attributes["value"].InnerText;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return innerText;
        }

        public static void WriteToLog(string Message = "UNKNOWN", string Location = "UNKNOWN")
        {
            const string FilePath = @"C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\16\TEMPLATE\LAYOUTS\TechnoManagement\Customizations\Log.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.Write(Location + "\t");
                    sw.Write(Convert.ToString(DateTime.Now) + "\t");
                    sw.WriteLine(Message);
                }

            }
            catch (Exception ex) { string x = ex.Message; }
        }

        public static string GetURLQuery(string Key)
        {
            string Value = "";
            try
            {
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                Uri myUri = new Uri(url);
                Value = Convert.ToString(HttpUtility.ParseQueryString(myUri.Query).Get(Key));
            }
            catch (Exception ex) { string x = ex.Message; WriteToLog(x, "GetURLQuery Static Function"); }

            return Value;
        }

        public static bool GetReaddOnly()
        {
            bool ReadOnly = true;
            try
            {
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                Uri myUri = new Uri(url);
                ReadOnly = Convert.ToBoolean(Convert.ToInt32(HttpUtility.ParseQueryString(myUri.Query).Get("ReadOnly")));

            }
            catch (Exception ex) { string x = ex.Message; WriteToLog(x, "GetReaddOnly Static Function"); }

            return ReadOnly;
        }

        public static string ConnectionString
        {
            get
            {
                var ConnectionString = HttpContext.Current.Session["ConnectionString"] as string;
                if (null == ConnectionString)
                {
                    ConnectionString = GetConfigValue("SPWFConnectionString");
                    HttpContext.Current.Session["ConnectionString"] = ConnectionString;
                }
                return ConnectionString;

            } 
        }
         
    }
}