using System.Text.RegularExpressions;

namespace DateFormatter
{
    public class Date
    {
        public static string GetDatePlus3DayStr(string day, string outDay)
        {
            Regex StringFormat = new Regex("(3[0-1]|[1-2][0-9]|0?[1-9])[.](1[0-2]|0?[1-9])");
            int daymatch;
            int monthmatch;
            var Matchcollection = StringFormat.Match(day);

            if (Matchcollection.Success)
            {
                Regex ValidMonth = new Regex("тридцать первое ((ноября)|(сентября)|(июня)|(апреля))");
                Regex ValidDay = new Regex("((двадцать девятое)|(тридцатое)|(тридцать первое)) февраля");
                daymatch = Int32.Parse(Matchcollection.Groups[1].Value);
                monthmatch = Int32.Parse(Matchcollection.Groups[2].Value);
                outDay = string.Format("{0} {1}", SwitchDay(daymatch), SwitchMonth(monthmatch));
                var matchNotValidMonth = ValidMonth.Matches(outDay);
                var matchNotValidDay = ValidDay.Matches(outDay);
                if (matchNotValidDay.Count != 0 || matchNotValidMonth.Count != 0)
                {
                    throw new Exception("This date doesn't exist");
                }
                else
                {
                    return outDay;
                }

            }
            else
            {
                throw new Exception("Wrong string format");
            }
        }

        public static string SwitchDay(int day)
        {
            day = day + 3;

            string dayString = string.Empty;
            if (day < 32)
            {
                switch (day)
                {
                    case 1:
                        dayString = "первое";
                        break;
                    case 2:
                        dayString = "второе";
                        break;
                    case 3:
                        dayString = "третье";
                        break;
                    case 4:
                        dayString = "четвертое";
                        break;
                    case 5:
                        dayString = "пятое";
                        break;
                    case 6:
                        dayString = "шестое";
                        break;
                    case 7:
                        dayString = "седьмое";
                        break;
                    case 8:
                        dayString = "восьмое";
                        break;
                    case 9:
                        dayString = "девятое";
                        break;
                    case 10:
                        dayString = "десятое";
                        break;
                    case 11:
                        dayString = "одиннадцатое";
                        break;
                    case 12:
                        dayString = "двенадцатое";
                        break;
                    case 13:
                        dayString = "тринадцатое";
                        break;
                    case 14:
                        dayString = "четырнадцатое";
                        break;
                    case 15:
                        dayString = "пятнадцатое";
                        break;
                    case 16:
                        dayString = "шестнадцатое";
                        break;
                    case 17:
                        dayString = "семнадцатое";
                        break;
                    case 18:
                        dayString = "восемнадцатое";
                        break;
                    case 19:
                        dayString = "девятнадцатое";
                        break;
                    case 20:
                        dayString = "двадцатое";
                        break;
                    case 21:
                        dayString = "двадцать первое";
                        break;
                    case 22:
                        dayString = "двадцать второе";
                        break;
                    case 23:
                        dayString = "двадцать третье";
                        break;
                    case 24:
                        dayString = "двадцать четвертое";
                        break;
                    case 25:
                        dayString = "двадцать пятое";
                        break;
                    case 26:
                        dayString = "двадцать шестое";
                        break;
                    case 27:
                        dayString = "двадцать седьмое";
                        break;
                    case 28:
                        dayString = "двадцать восьмое";
                        break;
                    case 29:
                        dayString = "двадцать девятое";
                        break;
                    case 30:
                        dayString = "тридцатое";
                        break;
                    case 31:
                        dayString = "тридцать первое";
                        break;
                }

                return dayString;
            }
            else
            {
                throw new Exception("Wrong day format");
            }
        }
        public static string SwitchMonth(int monthday)
        {
            string month = string.Empty;
            switch (monthday)
            {
                case 1:
                    month = "января";
                    break;
                case 2:
                    month = "февраля";
                    break;
                case 3:
                    month = "марта";
                    break;
                case 4:
                    month = "апреля";
                    break;
                case 5:
                    month = "мая";
                    break;
                case 6:
                    month = "июня";
                    break;
                case 7:
                    month = "июля";
                    break;
                case 8:
                    month = "августа";
                    break;
                case 9:
                    month = "сентября";
                    break;
                case 10:
                    month = "октября";
                    break;
                case 11:
                    month = "ноября";
                    break;
                case 12:
                    month = "декабря";
                    break;
            }
            return month;
        }
    }
}