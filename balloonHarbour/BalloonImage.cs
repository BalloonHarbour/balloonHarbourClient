using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace balloonHarbour {
    class BalloonImage {
        private Color _Color;
        private DirectoryInfo _Directory;
        public BalloonImage(Color aColor) {
            this._Color = aColor;
            _Directory = new DirectoryInfo($"./BallonImages/{_Color.Name}");
        }
        

    }
}
