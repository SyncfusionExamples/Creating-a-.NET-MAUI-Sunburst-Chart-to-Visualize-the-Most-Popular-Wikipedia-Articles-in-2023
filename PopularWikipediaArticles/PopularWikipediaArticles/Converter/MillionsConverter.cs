namespace PopularWikipediaArticles
{
    public class MillionsConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return (doubleValue / 1000000).ToString("N1") + "M";
            }

            return value != null ? value : string.Empty;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}