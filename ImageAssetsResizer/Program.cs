using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;
using CommandLine.Text;

namespace AutoAssetsResizer
{
    class Program
    {
        class Options
        {
            [Option('d', "directory", Required = true,
              HelpText = "Input directory to be processed.")]
            public string InputDirectory { get; set; }

            [Option('v', "verbose", DefaultValue = true,
              HelpText = "Prints all messages to standard output.")]
            public bool Verbose { get; set; }

            [ParserState]
            public IParserState LastParserState { get; set; }

            [HelpOption]
            public string GetUsage()
            {
                return HelpText.AutoBuild(this,
                  (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Universal Windows Platform Auto Image Assets Resizer";

            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // Values are available here
                if (options.Verbose) 
                    Console.WriteLine("Filename: {0}", options.InputDirectory);
            }

            Console.WriteLine("Resizer...");

            if (!Directory.Exists(options.InputDirectory))
                Console.WriteLine("Directory not found: {0}", options.InputDirectory);

            List<ImageAsset> imageAssetDefinitions = new ImageAssetList().ImageAssetDefinitions;

            string[] files = Directory.GetFiles(options.InputDirectory);

            if (options.Verbose)
            {
                foreach(string fileName in files)
                    Console.WriteLine("Image files found: {0}", fileName);
            }              

            List<ImageAsset> assets = new List<ImageAsset>();
            
            var result = imageAssetDefinitions.Where(p => !files.Any(p2 => p2.Contains(p.ToString()))).ToList();

            int savedAssets = 0;
            foreach(string fileName in files)
            {
                foreach (ImageAsset imageAssetDefinition in result)
                {
                    if (fileName.Contains(imageAssetDefinition.Name))
                    {
                        Bitmap source = new Bitmap(fileName);

                        Bitmap scaledAsset = ImageHelper.ResizeImage(source, imageAssetDefinition.Width, imageAssetDefinition.Height);

                        string newFileName = fileName.Remove(fileName.Count() - 7) + imageAssetDefinition.Scale.ToString();

                        if (options.Verbose)
                            Console.WriteLine("Saving asset: {0}.png", newFileName);

                        scaledAsset.Save(newFileName + ".png", ImageFormat.Png);
                        savedAssets++;
                    }                   
                }
            }
            
            Console.WriteLine("Number of assets saved: {0}", savedAssets);
            Console.WriteLine("Resizer... done.\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}