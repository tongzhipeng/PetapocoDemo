using PetaPoco;
using System.ComponentModel;

namespace PetapocoDemo.Model
{
    public enum WeatherSummary
    {
        [Description("晴天")]
        Sunny = 1,
        [Description("多云")]
        Cloudy = 2,
        [Description("有雨")]
        Rainy = 3,
        [Description("有风")]
        Windy = 4,
        [Description("下雪")]
        Snowy = 5,
        [Description("有雾")]
        Foggy = 6
    }
}