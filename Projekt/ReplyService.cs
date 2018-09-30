using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class ReplyService
    {
        private string line;
        private string order;
        private string reply;


        public ReplyService()
        {

        }

        public ReplyService(string line)
        {
            this.line = line;
            order = line.Substring(0, 3);
        }

        public string Line
        {
            get
            {
                return line;
            }
            set
            {
                line = value;
            }
        }

        public string Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }

        public string Reply
        {
            get
            {
                return reply;
            }
        }


        public void ServeAVR()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeAVS()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeSRA(int[] samplingRates)
        {
            if (line.Contains("not valid") == true)
            {
                return; // Trzeba dopisać błąd, że nie może takiej ustawić. Instrukcja s. 31.
            }

            reply = new String(line.Where(Char.IsDigit).ToArray());
            reply = reply[0].ToString();
            reply = samplingRates[Array.IndexOf(samplingRates, int.Parse(reply)) + 1].ToString();
        }

        public void ServeSRI()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
            reply = reply.Insert(1, ",");
        }

        public void ServeSEN()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeMOD()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
            reply = reply[0].ToString();
        }

        public void ServeSCA()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeTHR()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeSOD()
        {

        }

        public void ServeASC()
        {

        }

        public void ServeLLM()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeRLM()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeLMA()
        {
            reply = new String(line.Where(Char.IsDigit).ToArray());
        }

        public void ServeVER()
        {
            reply = new string(line.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
            reply = reply.Remove(0, 4);
            reply = reply.Remove(4, 2);
            reply = reply.Remove(17, 8);
            reply = reply.Remove(reply.Length - 5);
            
        }

    }
}
