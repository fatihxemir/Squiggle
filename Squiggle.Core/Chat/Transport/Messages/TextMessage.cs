﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace Squiggle.Core.Chat.Transport.Messages
{
    [ProtoContract]
    class TextMessage : Message
    {
        [ProtoMember(1)]
        public string FontName { get; set; }
        [ProtoMember(2)]
        public int FontSize { get; set; }
        [ProtoMember(3)]
        int ColorR { get; set; }
        [ProtoMember(4)]
        int ColorG { get; set; }
        [ProtoMember(5)]
        int ColorB { get; set; }
        public Color Color
        {
            get { return Color.FromArgb(ColorR, ColorG, ColorB); }
            set
            {
                ColorR = value.R;
                ColorG = value.G;
                ColorB = value.B;
            }
        }
        [ProtoMember(6)]
        public FontStyle FontStyle { get; set; }
        [ProtoMember(7)]
        public string Message { get; set; }
    }
}
