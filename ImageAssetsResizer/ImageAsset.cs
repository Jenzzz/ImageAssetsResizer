using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAssetsResizer
{
    class ImageAsset
    {
        public string Name { get; set; }
        public int Scale { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Bitmap Data { get; set; }

        public override string ToString()
        {
            return Name + "-scale" + Scale;
        }

        public ImageAsset(string name, int scale, int width, int height)
        {
            Name = name;
            Scale = scale;
            Height = height;
            Width = width;
        }

        public ImageAsset(string name, int scale, int width, int height, Bitmap data)
        {
            Name = name;
            Scale = scale;
            Height = height;
            Width = width;
            Data = data;
        }
    }
}
