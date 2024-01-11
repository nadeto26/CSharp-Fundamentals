namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Songs> song = new List<Songs>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_"); //favourite_DownTown_3:14
                string typeList = input[0];
                string songName = input[1];
                string duration = input[2];

                Songs songs = new Songs();
                songs.TypeList = typeList;
                songs.Name = songName;
                songs.Time = duration;

                song.Add(songs);
            }
            string searchFortypeList = Console.ReadLine();
            if (searchFortypeList == "all")
            {
                foreach (Songs songs in song)
                {
                    Console.WriteLine(songs.Name);
                }
            }
            else
            {
                foreach (var songs in song)
                {
                    if (songs.TypeList == searchFortypeList)
                    {
                        Console.WriteLine(songs.Name);
                    }

                }
            }

        }
        public class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; } //3:14
        }
    }
}
    