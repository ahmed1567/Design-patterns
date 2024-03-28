using Observer;

WeatherData weatherData = new WeatherData();

StatisticsScreen statistics = new StatisticsScreen(weatherData);
ConditionsScreen conditions = new ConditionsScreen(weatherData);
ForcastScreen forcastScreen = new ForcastScreen(weatherData);



weatherData.SetMeasurments(20, 30, 40);


