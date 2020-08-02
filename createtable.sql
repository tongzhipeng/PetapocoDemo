DROP TABLE IF EXISTS `WeatherForecast`;
CREATE TABLE `WeatherForecast` (
  `id` int NOT NULL AUTO_INCREMENT,
  `TemperatureC` int NOT NULL,
  `Summary` int NOT NULL,
  `Date` datetime NOT NULL DEFAULT '0001-01-01 00:00:00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22242 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;