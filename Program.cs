using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNember1
{
    internal class Program
    {

        public static bool isSpecial(int num)
        {
            // תנאי 1: המספר חייב להיות תלת-ספרתי (בין 100 ל-999)
            if (num < 100 || num > 999)
            {
                return false;
            }

            // שמירת המספר המקורי לצורך השוואה בסוף
            int originalNum = num;

            // פירוק המספר לספרותיו
            int hundreds = num / 100;
            int tens = (num / 10) % 10;
            int units = num % 10;

            // חישוב סכום החזקות של הספרות
            int sumOfCubes = (int)(Math.Pow(hundreds, 3) + Math.Pow(tens, 3) + Math.Pow(units, 3));

            // תנאי 2: החזרת תוצאת ההשוואה בין סכום החזקות למספר המקורי
            return originalNum == sumOfCubes;
        }
        public static int[] specialOnly(int[] numbers)
        {
            // --- שלב 1: ספירת המספרים המיוחדים ---
            int specialCount = 0;
            // נרוץ על המערך המקורי עם לולאת for
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isSpecial(numbers[i]))
                {
                    specialCount++; // אם המספר מיוחד, נקדם את המונה
                }
            }

            // --- שלב 2: יצירת המערך החדש בגודל המדויק ---
            int[] specialArray = new int[specialCount];

            // --- שלב 3: אכלוס המערך החדש ---
            int newArrayIndex = 0; // אינדקס עבור המערך החדש
                                   // נרוץ שוב על המערך המקורי
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isSpecial(numbers[i]))
                {
                    // אם המספר מיוחד, נכניס אותו למערך החדש
                    specialArray[newArrayIndex] = numbers[i];
                    // נקדם את האינדקס של המערך החדש
                    newArrayIndex++;
                }
            }
            return specialArray; // החזרת המערך החדש עם המספרים המיוחדים בלבד
        }

      
        public static string ShortestShow(Show[] shows)
        {
            // משתנה לשמירת אורך ההצגה הקצרה ביותר שנמצאה עד כה
            // מאותחל לערך המקסימלי האפשרי כדי שההצגה החוקית הראשונה תמיד תהיה קצרה יותר
            int minLength = int.MaxValue;

            // משתנה לשמירת שם ההצגה הקצרה ביותר, מאותחל לערך ברירת המחדל
            string shortestShowName = "None";

            // לולאה העוברת על כל ההצגות במערך
            for (int i = 0; i < shows.Length; i++)
            {
                Show currentShow = shows[i];

                // 1. בדיקת התנאי: האם בהצגה יש לפחות 3 שחקנים מנוסים.
                //    (שימוש חובה בפעולה מסעיף ג')
                if (currentShow.NumOfExperiencedActors() >= 3)
                {
                    // 2. אם התנאי מתקיים, נבדוק אם היא קצרה יותר מהמינימום שמצאנו עד כה
                    if (currentShow.GetLengthInMinutes() < minLength)
                    {
                        // אם כן, זו ההצגה הקצרה ביותר שמצאנו עד עכשיו שעונה על הדרישות.
                        // נעדכן את האורך המינימלי ואת שם ההצגה.
                        minLength = currentShow.GetLengthInMinutes();
                        shortestShowName = currentShow.GetShowName();
                    }
                }
            }
            // החזרת שם ההצגה שנמצאה, או "None" אם המשתנה לא עודכן
            return shortestShowName;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter  number:");

            // קריאת הקלט והמרתו למספר (ללא בדיקת תקינות)
            int n = int.Parse(Console.ReadLine());

            // זימון הפעולה isSpecial עם הקלט n
            if (isSpecial(n))
            {
                // אם הפעולה החזירה אמת
                Console.WriteLine("special number");
            }
            else
            {
                // אם הפעולה החזירה שקר
                Console.WriteLine("not special number");
            }

            int[] numbers = { 153, 88, 370, 153, 400, 9, 153 };
            int[] specialNumbers = specialOnly(numbers);
            Console.WriteLine("Special numbers in the array:");
            for (int i = 0; i < specialNumbers.Length; i++)
            {
                Console.WriteLine(specialNumbers[i]);
            }
        }
    }
}
