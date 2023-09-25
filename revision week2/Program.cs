namespace revision_week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"c:\temp\results.txt";

            try
            {
                string[] filecontents = File.ReadAllLines(filepath);

                int totalpoints = 0, points = 0, result = 0;
                for (int i =0; i < filecontents.Length; i++)
                {
                    result = Convert.ToInt32(filecontents[i]);

                    if (result >= 90)
                        points = 100;
                    else if (result >= 80)
                        points = 88;
                    else if (result >= 70)
                        points = 77;
                    else if (result >= 60)
                        points = 66;
                    else if (result >= 50)
                        points = 56;
                    else if (result >= 40)
                        points = 46;
                    else if (result >= 30)
                        points = 37;
                    else
                        points = 0;

                    totalpoints = +points;
                }

                File.AppendAllText(filepath, Environment.NewLine + "Total points: " + totalpoints.ToString());
            }
            catch(IOException io)
            {
                Console.WriteLine(io.Message);
            }
        }
    }
}