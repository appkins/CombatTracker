using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CombatTracker.Models
{
    public enum TriggerType
    {
        None = 0,
        Beep = 1,
        WAV = 2,
        TTS = 3
    }

    [Serializable]
    public class Trigger
    {
        [XmlElement(ElementName = "R")]
        public string Expression { get; set; }

        [XmlElement(ElementName = "C")]
        public string Category { get; set; }

        [XmlElement(ElementName = "TN")]
        public string Name { get; set; }

        [XmlElement(ElementName = "ST")]
        public TriggerType Type { get; set; }

        [XmlElement(ElementName = "SD")]
        public string Data { get; set; }

        public bool Match(string test)
        {
            try
            {
                return Regex.Match(test, Expression).Success;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
