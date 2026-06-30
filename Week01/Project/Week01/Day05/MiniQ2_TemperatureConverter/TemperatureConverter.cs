namespace Week01.Day05.MiniQ2_TemperatureConverter;

public class TemperatureConverter
{
    // Celsius to Fahrenheit
    public double Convert(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Fahrenheit to Celsius
    public double Convert(double fahrenheit, bool isFahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Kelvin to Celsius
    public double Convert(double kelvin, string unit)
    {
        return kelvin - 273.15;
    }
}