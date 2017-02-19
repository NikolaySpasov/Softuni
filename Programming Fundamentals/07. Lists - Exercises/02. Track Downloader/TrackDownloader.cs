namespace TrackDownloader
{
    using System;
    using System.Collections.Generic;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split();

            var downloadedTracks = new List<string>();

            var filenames = Console.ReadLine();
            while (filenames != "end")
            {
                bool isOnBlacklist = false;
                foreach (var blacklistedWord in blacklistedWords)
                {
                    if (filenames.Contains(blacklistedWord))
                    {
                        isOnBlacklist = true;
                    }
                }

                if (isOnBlacklist != true)
                {
                    downloadedTracks.Add(filenames);
                }

                filenames = Console.ReadLine();
            }

            downloadedTracks.Sort();

            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, downloadedTracks));
        }
    }
}