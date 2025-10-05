using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNember1
{
    public class Show
    {
        // תכונות המחלקה
        private string showName;
        private int lengthInMinutes;
        private Actor[] cast;

        /// <summary>
        /// פעולה בונה המקבלת את שם ההצגה ואורכה בדקות,
        /// ומאתחלת מערך של 8 שחקנים.
        /// </summary>
        /// <param name="showName">שם ההצגה</param>
        /// <param name="lengthInMinutes">אורך ההצגה בדקות</param>
        public Show(string showName, int lengthInMinutes)
        {
            this.showName = showName;
            this.lengthInMinutes = lengthInMinutes;
            this.cast = new Actor[8];
        }

        public int GetLengthInMinutes()
        {
            return lengthInMinutes;
        }
        public string GetShowName()
        {
            return showName;
        }
        public bool AddActor(Actor actor)
        {



            if (actor.GetAge() >= 45 && actor.GetNumberOfShows() >= 5)
            {
                //  מציאת מקום פנוי במערך והוספה
                // על פי הנחת השאלה, תמיד קיים מקום פנוי
                for (int i = 0; i < this.cast.Length; i++)
                {
                    if (this.cast[i] == null)
                    {
                        this.cast[i] = actor; // הוספת השחקן למקום הפנוי הראשון
                        this.cast[i].AddShow(); // עדכון מספר ההצגות של השחקן
                        return true;          // ההוספה הצליחה

                      


                    }

                }
            }

            // אם התנאים לא התקיימו, ההוספה נכשלת
            return false;
        }
        /// <summary>
        /// הפעולה סופרת ומחזירה את מספר השחקנים המנוסים בהצגה.
        /// שחקן מנוסה הוא שחקן עם 10 הצגות ומעלה בעברו.
        /// </summary>
        /// <returns>מספר שלם המייצג את כמות השחקנים המנוסים</returns>
        public int NumOfExperiencedActors()
        {
            int experiencedCounter = 0; // אתחול מונה לספירת השחקנים המנוסים

            // לולאה העוברת על כל המקומות במערך השחקנים
            for (int i = 0; i < this.cast.Length; i++)
            {
                // יש לוודא שהמקום במערך אינו ריק לפני שניגשים לשחקן
                if (this.cast[i] != null)
                {
                    // בדיקת התנאי: האם לשחקן הנוכחי יש 10 הצגות ומעלה
                    if (this.cast[i].GetNumberOfShows() >= 10)
                    {
                        experiencedCounter++; // קידום המונה
                    }
                }
            }
            return experiencedCounter; // החזרת הספירה הסופית
        }


    }
}
