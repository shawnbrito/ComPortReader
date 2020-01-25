using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QRCodeCreator
{
    class LogJson
    {
        //https://github.com/adrianpietka/logstash-sender/tree/master/FeedLogstash

        public readonly int Id;
        public readonly DateTime DateTime;
        public readonly string message;
        public readonly List<string> tags;
        
        public LogJson(int id, DateTime dateTime, string mess) {
            Id = id; DateTime = dateTime; message = mess;
            tags = new List<string>();
            tags.Add("DHT22");
        }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
