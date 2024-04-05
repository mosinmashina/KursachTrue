using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kursach.Controllers
{
    public class Records
    {
        public static void saveScore(string name, int score)
        {
            NamesAndRecords nameRec = getRecords();
            for (int i = 0; i < nameRec.scores.Count; i++)
            {
                if (nameRec.scores[i] <= score)
                {
                    nameRec.scores.Insert(i, score);
                    nameRec.names.Insert(i, name);
                    if (nameRec.scores.Count > 10)
                    {
                        nameRec.scores.RemoveAt(nameRec.scores.Count - 1);
                        nameRec.names.RemoveAt(nameRec.names.Count - 1);
                    }
                    break;
                }
            }
            setRecords(nameRec);
        }

        public static NamesAndRecords getRecords()
        {
            StreamReader srRecords = new StreamReader(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Controllers\Records.txt");
            StreamReader srNames = new StreamReader(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Controllers\Names.txt");

            List<int> rec = new List<int>();
            List<string> names = new List<string>();

            string numbers = srRecords.ReadLine();
            foreach (string number in numbers.Split())
            {
                int num = int.Parse(number);
                rec.Add(num);
            }
            string namesString = srNames.ReadLine();
            foreach (var name in namesString.Split())
            {
                names.Add(name);
            }
            NamesAndRecords nameRecords = new NamesAndRecords(names, rec);
            srRecords.Close();
            srNames.Close();
            return nameRecords;
        }

        public static void setRecords(NamesAndRecords nameRec)
        {
            StreamWriter swRec = new StreamWriter(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Controllers\Records.txt");
            StreamWriter swName = new StreamWriter(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Controllers\Names.txt");
            for(int i=0; i<nameRec.scores.Count; i++)
            {
                swRec.Write(nameRec.scores[i]);
                if (!(nameRec.scores.Count-1 == i))
                    swRec.Write(' ');
            }
            for (int i = 0; i < nameRec.names.Count; i++)
            {
                swName.Write(nameRec.names[i]);
                if (!(nameRec.names.Count-1 == i))
                    swName.Write(' ');
            }
            swRec.Close();
            swName.Close();
        }
    }

    public class NamesAndRecords
    {
        public List<string> names;
        public List<int> scores;

        public NamesAndRecords()
        {

        }

        public NamesAndRecords(List<string> names, List<int> scores)
        {
            this.names = names;
            this.scores = scores;
        }
    }
}
