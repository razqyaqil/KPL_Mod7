using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace modul7_1302202072
{
    internal class BankTransferConfig
    {
        public string filePath = "bank_transfer_config.json";
        public dynamic lang;
        public int transferThreshold;
        public int lowfee;
        public int highfee;
        public dynamic metod;
        public dynamic confirm;

        public BankTransferConfig()
        {
            StreamReader r = new StreamReader(filePath);
            string jsonString = r.ReadToEnd();
            JObject parsed = JObject.Parse(jsonString);


            this.lang = parsed["lang"];
            dynamic transfer = parsed["transfer"];

            this.transferThreshold = transfer["threshold"];
            this.lowfee = transfer["low_fee"];
            this.highfee = transfer["high_fee"];
            this.metod = parsed["methods"].ToArray();
            this.confirm = parsed["confirmation"];


        }


    }
}
