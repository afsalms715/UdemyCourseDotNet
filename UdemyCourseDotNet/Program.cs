using UdemyCourseDotNet.Assignmets;

/*AreaOfCircle areaOfCircle = new AreaOfCircle();
areaOfCircle.CalculateAreaOfCircle(null);
*/
/*FeetToCentimeter feetToCentimeter = new FeetToCentimeter();
feetToCentimeter.ConvertFeetToCentimeter(null);*/

/*var nearestThousand = new NearestThousand();
int value = 0;
Console.WriteLine("Enter the number: ");
nearestThousand.GetNearestThousand(int.TryParse(Console.ReadLine(), out value) ? value : 0);
Console.WriteLine("The nearest thousand is: " + nearestThousand.GetNearestThousand(value));*/

/*var secondsToMinutes = new SecondsToMinutes();
int seconds = 0;
Console.WriteLine("Enter the seconds: ");
secondsToMinutes.ConvertSecondsToMinutes(int.TryParse(Console.ReadLine(), out seconds) ? seconds : 0);
Console.WriteLine("The time is: " + secondsToMinutes.ConvertSecondsToMinutes(seconds));
*/

HeightCategory heightCategory = new();
double heightInInches = 0;
Console.WriteLine("Enter the height in inches: ");
heightCategory.GetHeightCategory(double.TryParse(Console.ReadLine(), out heightInInches) ? heightInInches : 0);
Console.WriteLine("The height category is: " + heightCategory.GetHeightCategory(heightInInches));
