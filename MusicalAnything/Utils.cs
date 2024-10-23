using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MusicalAnything {
    internal class SavedTokenHandler {
        private Dictionary<string, string> _tokens = new Dictionary<string, string>();
        public SavedTokenHandler(string setting) {
            if (setting == "") return;

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setting))) {
                BinaryFormatter bf = new BinaryFormatter();
                _tokens = (Dictionary<string, string>)bf.Deserialize(ms);
            }
        }
        public string GetSettings() {
            if (_tokens.Count == 0) return "";

            using (MemoryStream ms = new MemoryStream()) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, _tokens);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                return Convert.ToBase64String(buffer);
            }
        }

        public string GetToken(string Keyname) {
            if (_tokens.ContainsKey(Keyname)) {
                return _tokens[Keyname];
            }
            return null;
        }

        public void SetToken(string KeyName, string Token) {
            _tokens[KeyName] = Token;
        }

    }
}
