using System;
using System.IO;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace ExamQuestions.Service
{
    public class EmployeeService : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "GET":
                    READ(context);
                    break;
            }
        }

        private void READ(HttpContext context)
        {
            int employeeCode = Convert.ToInt16(context.Request["id"]);

            var emp = new Employee {EmpCode = employeeCode};

            string serializedEmployee = Serialize(emp);
            context.Response.ContentType = "text/xml";
//            WriteResponse(serializedEmployee);
        }

        public bool IsReusable { get; private set; }

        private String Serialize(Employee emp)
        {
            try
            {
                String XmlizedString = null;
                XmlSerializer xs = new XmlSerializer(typeof (Employee));
                //create an instance of the MemoryStream class since we intend to keep the XML string 
                //in memory instead of saving it to a file.
                MemoryStream memoryStream = new MemoryStream();
                //XmlTextWriter - fast, non-cached, forward-only way of generating streams or files 
                //containing XML data
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                //Serialize emp in the xmlTextWriter
                xs.Serialize(xmlTextWriter, emp);
                //Get the BaseStream of the xmlTextWriter in the Memory Stream
                memoryStream = (MemoryStream) xmlTextWriter.BaseStream;
                //Convert to array
                XmlizedString = Encoding.ASCII.GetString(memoryStream.ToArray());
                return XmlizedString;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string UTF8ByteArrayToString(byte[] toArray)
        {
            return null;
        }
    }

    public enum Food
    {
        pizza,
        cheese,
        pasta
    }
}