using System.ComponentModel.DataAnnotations;

namespace TemperatureConverter.Models
{
    public class TempConverterModel
    {
        [Range(float.MinValue,float.MaxValue,ErrorMessage="You must enter a number...")]
        public float OriginalTemperature { get; set; }

        public float ConvertedTemperature { get; set; }
        public string TempScale { get; set; } = "celsius";

        public float CalculateConversion()
        {
            if (TempScale == "celsius")
            {
                ConvertedTemperature = (OriginalTemperature - 32) * 5 / 9;
            }
            else if (TempScale == "farenheit")
            {
                ConvertedTemperature = (OriginalTemperature * 9 / 5) + 32;
            }
            return ConvertedTemperature;
        }
    }
}
