namespace HttpClient_calls.Models
{
    public class PostModel
    {
        public int userid { get; set; }

        public int id { get; set; }

        public string title { get; set; }

        public string body { get; set; }

        List<PostModel> posts = new List<PostModel>();

        public List<PostModel> getPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var apicall = client.GetAsync(url);

            if (apicall.Result.IsSuccessStatusCode)
            {
                var response = apicall.Result.Content.ReadAsAsync<List<PostModel>>();
                response.Wait();
                posts = response.Result;
                return posts;
            }
            else
            {
                throw new Exception("unable to get data from source");
            }
        }
    }
}
