
namespace HW1
{
    class Program
    {        
        private static readonly HttpClient client = new HttpClient();
        public static async Task Main(string[] args)
        {
            await MakeACallToDocumentation();
        }
        static async Task MakeACallToDocumentation()
        {            
            for (int i = 4; i < 11; i++)
            {
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/" + i);
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{content}\n");

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);                
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Result.txt"), true))
                {
                    outputFile.WriteLine(content);
                }
            }
        }
    }
}

