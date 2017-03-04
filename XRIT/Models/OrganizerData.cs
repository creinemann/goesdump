﻿using System;
using System.Collections.Generic;

namespace OpenSatelliteProject {
    public class OrganizerData {
        public Dictionary<int, string> Segments { get; set; }
        public int Lines { get; set; }
        public int Columns { get; set; }
        public float PixelAspect { get; set; }
        public uint StartColumn { get; set; }
        public int MaxSegments;

        public OrganizerData() {
            Segments = new Dictionary<int, string>();
            Lines = -1;
            Columns = -1;
            PixelAspect = -1;
            StartColumn = 0;
            MaxSegments = 0;
        }

        public bool IsComplete { get { return Segments.Count == MaxSegments; }}
    }
}

