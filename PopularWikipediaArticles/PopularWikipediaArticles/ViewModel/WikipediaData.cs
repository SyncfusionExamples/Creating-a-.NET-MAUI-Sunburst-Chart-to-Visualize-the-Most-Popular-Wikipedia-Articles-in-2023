using System.Collections.ObjectModel;
using System.Reflection;

namespace PopularWikipediaArticles
{
    public class WikipediaData
    {
        public ObservableCollection<WikipediaModel> Data { get; set; }
        public ObservableCollection<Brush> CustomBrush { get; set; }

        public WikipediaData()
        {
            Data = new ObservableCollection<WikipediaModel>
            {
                new WikipediaModel("Celebrities",22179656, "Taylor Swift"),
                new WikipediaModel("Celebrities",17882508, "Matthew Perry"),
                new WikipediaModel("Celebrities",16026256, "Elon Musk"),
                new WikipediaModel("Celebrities",14812928, "Lisa Marie Presley"),

                new WikipediaModel("Film and Television",31265503, "Oppenheimer (film)"),
                new WikipediaModel("Film and Television",28681943, "J. Robert Oppenheimer"),
                new WikipediaModel("Film and Television",23112884, "Jawan (film)"),
                new WikipediaModel("Film and Television",20614066, "Pathaan (film)"),
                new WikipediaModel("Film and Television",19930916, "Barbie (film)"),
                new WikipediaModel("Film and Television",16988676, "Animal (2023 film)"),
                new WikipediaModel("Film and Television",15062733, "Avatar: The Way of Water"),
                new WikipediaModel("Film and Television",14170970, "Guardians of the Galaxy Vol. 3"),
                new WikipediaModel("Film and Television",13994461, "Leo (2023 Indian film)"),

                new WikipediaModel("Sports",38723498, "2023 Cricket World Cup"),
                new WikipediaModel("Sports",32456338, "Indian Premier League"),
                new WikipediaModel("Sports",26390217, "Cricket World Cup"),
                new WikipediaModel("Sports",20813029, "2023 Indian Premier League"),
                new WikipediaModel("Sports",19968486, "Premier League"),
                new WikipediaModel("Sports",19287757, "Cristiano Ronaldo"),
                new WikipediaModel("Sports",17768818, "Lionel Messi"),

                new WikipediaModel("Others",52565681, "ChatGPT"),
                new WikipediaModel("Others",48549304, "Deaths in 2023"),
                new WikipediaModel("Others",21000722, "The Last of Us (TV series)"),
                new WikipediaModel("Others",18135421, "United States"),
                new WikipediaModel("Others",15200006, "India"),
            };

            CustomBrush = new ObservableCollection<Brush>()
            {
                 new SolidColorBrush(Color.FromArgb("#D4FF4E4E")),
                 new SolidColorBrush(Color.FromArgb("#D408CDAA")),
                 new SolidColorBrush(Color.FromArgb("#D49656FF")),
                 new SolidColorBrush(Color.FromArgb("#D41089E9")),
            };
        }
    }
}