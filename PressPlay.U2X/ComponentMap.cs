﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PressPlay.U2X
{
    public class ComponentMap
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlAttribute]
        public string To { get; set; }
    }
}