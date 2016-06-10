using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAssetsResizer
{
    class ImageAssetList
    {
        public List<ImageAsset> ImageAssetDefinitions { get; set; }

        public ImageAssetList()
        {
            ImageAssetDefinitions = new List<ImageAsset>();

            ImageAssetDefinitions.Add(new ImageAsset("Square71x71Logo", 100, 71, 71));
            ImageAssetDefinitions.Add(new ImageAsset("Square71x71Logo", 125, 89, 89));
            ImageAssetDefinitions.Add(new ImageAsset("Square71x71Logo", 150, 107, 107));
            ImageAssetDefinitions.Add(new ImageAsset("Square71x71Logo", 200, 142, 142));
            ImageAssetDefinitions.Add(new ImageAsset("Square71x71Logo", 400, 400, 400));

            ImageAssetDefinitions.Add(new ImageAsset("Square150x150Logo", 100, 150, 150));
            ImageAssetDefinitions.Add(new ImageAsset("Square150x150Logo", 125, 188, 188));
            ImageAssetDefinitions.Add(new ImageAsset("Square150x150Logo", 150, 225, 225));
            ImageAssetDefinitions.Add(new ImageAsset("Square150x150Logo", 200, 300, 300));
            ImageAssetDefinitions.Add(new ImageAsset("Square150x150Logo", 400, 600, 600));

            ImageAssetDefinitions.Add(new ImageAsset("Wide310x150Logo", 100, 310, 150));
            ImageAssetDefinitions.Add(new ImageAsset("Wide310x150Logo", 125, 388, 188));
            ImageAssetDefinitions.Add(new ImageAsset("Wide310x150Logo", 150, 465, 225));
            ImageAssetDefinitions.Add(new ImageAsset("Wide310x150Logo", 200, 620, 300));
            ImageAssetDefinitions.Add(new ImageAsset("Wide310x150Logo", 400, 1240, 600));

            ImageAssetDefinitions.Add(new ImageAsset("Square310x310Logo", 100, 310, 310));
            ImageAssetDefinitions.Add(new ImageAsset("Square310x310Logo", 125, 388, 388));
            ImageAssetDefinitions.Add(new ImageAsset("Square310x310Logo", 150, 465, 465));
            ImageAssetDefinitions.Add(new ImageAsset("Square310x310Logo", 200, 620, 620));
            ImageAssetDefinitions.Add(new ImageAsset("Square310x310Logo", 400, 1240, 1240));

            ImageAssetDefinitions.Add(new ImageAsset("Square44x44Logo", 100, 44, 44));
            ImageAssetDefinitions.Add(new ImageAsset("Square44x44Logo", 125, 55, 55));
            ImageAssetDefinitions.Add(new ImageAsset("Square44x44Logo", 150, 66, 66));
            ImageAssetDefinitions.Add(new ImageAsset("Square44x44Logo", 200, 88, 88));
            ImageAssetDefinitions.Add(new ImageAsset("Square44x44Logo", 400, 176, 176));

            ImageAssetDefinitions.Add(new ImageAsset("StoreLogo", 100, 50, 50));
            ImageAssetDefinitions.Add(new ImageAsset("StoreLogo", 125, 63, 63));
            ImageAssetDefinitions.Add(new ImageAsset("StoreLogo", 150, 75, 75));
            ImageAssetDefinitions.Add(new ImageAsset("StoreLogo", 200, 100, 100));
            ImageAssetDefinitions.Add(new ImageAsset("StoreLogo", 400, 200, 200));

            ImageAssetDefinitions.Add(new ImageAsset("BadgeLogo", 100, 24, 24));
            ImageAssetDefinitions.Add(new ImageAsset("BadgeLogo", 125, 30, 30));
            ImageAssetDefinitions.Add(new ImageAsset("BadgeLogo", 150, 36, 36));
            ImageAssetDefinitions.Add(new ImageAsset("BadgeLogo", 200, 48, 48));
            ImageAssetDefinitions.Add(new ImageAsset("BadgeLogo", 400, 96, 96));

            ImageAssetDefinitions.Add(new ImageAsset("SplashScreen", 100, 620, 300));
            ImageAssetDefinitions.Add(new ImageAsset("SplashScreen", 125, 775, 375));
            ImageAssetDefinitions.Add(new ImageAsset("SplashScreen", 150, 930, 450));
            ImageAssetDefinitions.Add(new ImageAsset("SplashScreen", 200, 1240, 600));
            ImageAssetDefinitions.Add(new ImageAsset("SplashScreen", 400, 2480, 1200));
        }
    }
}
