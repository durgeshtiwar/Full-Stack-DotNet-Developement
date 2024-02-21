// namespace Timejone 
// {
//     public class Time
//     {
//         public int hours{get;set;}
//         public int minutes{get;set;}
//         public int seconds{get;set;}
//         public void setTime(int h,int m,int s)
//         {
//             hours = h;
//             minutes = m;
//             seconds = s;

//         }
//         public void showTime()
//         {
//             normalize();
//             Console.WriteLine("The current time is: "+hours+" Hour " +minutes+ " Minute " +seconds+ " Second");
//         }
//         public void normalize()
//         {
//              if (minutes > 60 || seconds >60)
//              {
//                 minutes += seconds / 60;
//                 seconds = seconds%60;
//                 hours += minutes/60;
//                 minutes= minutes % 60;
//              }
//         }
//         public void add(Time time1)
//         {
//             hours+=time1.hours;
//             minutes+=time1.minutes;
//             seconds+=time1.seconds;
//             showTime();
//         }
//     }
// }