namespace ReDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ReDirectory
    {
        public static void Main()
        {
            string[] filesInDir = Directory.GetFiles("input");
            //var txt = new List<string>();
            //var png = new List<string>();
            //var test = new List<string>();
            Directory.CreateDirectory("output");
            //Directory.CreateDirectory("output/txts");
            //Directory.CreateDirectory("output/pngs");
            //Directory.CreateDirectory("output/tests");

            File.Move(@"input/bill.png", "output");

            //for (int i = 0; i < filesInDir.Length; i++)
            //{
            //    var fileExtension = filesInDir[i].Split('.').Last();
            //    if (fileExtension.Equals("txt"))
            //    {
            //        File.Move("filesInDir[i]", "output/txts");
            //    }
            //    else if (fileExtension.Equals("png"))
            //    {
            //        File.Move("filesInDir[i]", "output/pngs");
            //    }
            //    else if (fileExtension.Equals("test"))
            //    {
            //        File.Move("filesInDir[i]", "output/tests");
            //    }
            //}
        }
    }
}
