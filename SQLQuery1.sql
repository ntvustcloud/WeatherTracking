update [dbo].tbl_WeatherInformation set 
State='SD',
City='city SD',
Date='3/14/2024',
Temperature = '56',
Humidity='20',
Sunrise='6:50:00',
Sunset='17:30:00',
Cloudy='1',
Windy='0',
Rainy='0'
where Id = '6';

select * from [dbo].tbl_WeatherInformation
