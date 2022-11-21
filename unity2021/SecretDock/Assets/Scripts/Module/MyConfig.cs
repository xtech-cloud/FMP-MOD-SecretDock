
using System.Xml.Serialization;

namespace XTC.FMP.MOD.SecretDock.LIB.Unity
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class MyConfig : MyConfigBase
    {
        public class ClickArea
        {
            [XmlAttribute("wakeCount")]
            public int wakeCount { get; set; } = 10;
            [XmlAttribute("tickTime")]
            public float tickTime { get; set; } = 0.5f;
            [XmlAttribute("x")]
            public int x { get; set; } = 0;
            [XmlAttribute("y")]
            public int y { get; set; } = 0;
            [XmlAttribute("width")]
            public int width { get; set; } = 0;
            [XmlAttribute("height")]
            public int height { get; set; } = 0;
            [XmlElement("Anchor")]
            public Anchor anchor { get; set; } = new Anchor();
            [XmlArray("Subjects"), XmlArrayItem("Subject")]
            public Subject[] subjects { get; set; } = new Subject[0];
        }

        public class Style
        {
            [XmlAttribute("name")]
            public string name { get; set; } = "";
            [XmlElement("ClickArea")]
            public ClickArea clickArea { get; set; } = new ClickArea();
        }


        [XmlArray("Styles"), XmlArrayItem("Style")]
        public Style[] styles { get; set; } = new Style[0];
    }
}

