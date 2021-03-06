using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Imaging;

namespace balloonHarbourClientV2.Classes {
    class AvatarImage {
        private Color _Color;
        private DirectoryInfo _Directory;
        private string _username;
        private string _usernameFirstLetter;


        #region ctor
        public AvatarImage(string aUsername) {
            this._username = aUsername;
            GenerateRandomColor();
        }
        public AvatarImage(string aUsername, Color aColor) {
            this._Color = aColor;
            this._username = aUsername;
            Generate(aColor);
        }
        #endregion

        private string GetUsernameFirstLetter() {
            return _username.Substring(0, 1);
        }

        public void GenerateRandomColor() {
            Random rnd = new Random();
            Generate(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
        }

        public void Generate(Color backgroundColor) {
            _Directory = new DirectoryInfo($".\\Resources\\AvatarImages\\{_username}.bmp");

            var avatarString = GetUsernameFirstLetter();

            Bitmap bmp = new Bitmap(192, 192);
            var sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            var font = new Font("Segoe UI", 72, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(bmp);

            graphics.Clear(backgroundColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.DrawString(avatarString, font, new SolidBrush(Color.WhiteSmoke), new RectangleF(0, 0, 192, 192), sf);
            graphics.Flush();

            Directory.CreateDirectory(".\\Resources\\AvatarImages\\");

            var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            FileStream file = new FileStream(_Directory.FullName, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            file.Close();
            ms.Close();
            _Color = backgroundColor;
        }

        public void Regenerate() {
            Generate(_Color);
        }
        public Color Color { get => _Color;
            set {
                if (value != _Color) {
                    _Color = value;
                    Generate(value);
                }
            }
        }
        public string Username { get => _username;
            set {
                if (value != _username) {
                    _username = value;
                    Generate(Color);
                }
            }
        }
    }
}
