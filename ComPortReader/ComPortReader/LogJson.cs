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
        public readonly int mID;
        public readonly DateTime mDateTime;
        public readonly string mMessage;

        public LogJson(int id, DateTime dateTime, string mess) {
            mID = id; mDateTime = dateTime; mMessage = mess;
        }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
