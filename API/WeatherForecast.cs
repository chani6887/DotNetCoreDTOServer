namespace API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
//     יוצרת פרויקט
//     מעתיקה מחלקה אחת
//     אחר כך עושה מחלקה ממפר בDAL 