namespace PopularWikipediaArticles
{
    public class WikipediaModel
    {
        public string Category { get; set; }
        public double Value { get; set; }
        public string Article { get; set; }

       public WikipediaModel(string category, double value, string article)
        {
            Category = category;
            Value = value;
            Article = article;
        }
    }
}