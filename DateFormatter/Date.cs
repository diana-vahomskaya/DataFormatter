using System.Text.RegularExpressions;

namespace DateFormatter
{
    public class Date
    {
        public static string GetDatePlus3DayStr(string day, string outDay)
        {
            Regex StringFormat = new Regex("(3[0-1]|[1-2][0-9]|0[1-9])[.](1[0-2]|0[1-9])");
            int daymatch;
            int monthmatch;
            string Day = string.Empty;
            string Month = string.Empty;    
            var Matchcollection = StringFormat.Match(day);

            if (Matchcollection.Success)
            {
                daymatch = Int32.Parse(Matchcollection.Groups[1].Value);
                monthmatch = Int32.Parse(Matchcollection.Groups[2].Value);
                if(monthmatch < 13)
                {
                    if(daymatch < 32)
                    {
                        if(monthmatch == 2)
                        {
                            if (daymatch > 28)
                            {
                                throw new Exception("Wrong data format");
                            }
                            else if(daymatch <= 28)
                            {
                                daymatch += 3;
                                if(daymatch > 28)
                                {
                                    monthmatch += 1;
                                    daymatch -= 28;
                                    Day = SwitchDay(daymatch);
                                    Month = SwitchMonth(monthmatch);
                                }
                                else
                                {
                                    Day = SwitchDay(daymatch);
                                    Month = SwitchMonth(monthmatch);
                                }
                            }
                        }
                        else if(monthmatch == 4 || monthmatch == 6 || monthmatch == 9 || monthmatch == 11)
                        {
                            if (daymatch > 30)
                            {
                                throw new Exception("Wrong data format");
                            }
                            else if(daymatch <= 30)
                            {
                                daymatch += 3;
                                if (daymatch > 30)
                                {
                                    monthmatch += 1;
                                    daymatch -= 30;
                                    Day = SwitchDay(daymatch);
                                    Month = SwitchMonth(monthmatch);
                                }
                                else
                                {
                                    Day = SwitchDay(daymatch);
                                    Month = SwitchMonth(monthmatch);
                                }
                            }
                        }
                        else if (monthmatch == 12)
                        {
                            daymatch += 3;
                            if(daymatch > 31)
                            {
                                monthmatch += 1 - 12;
                                daymatch -= 31;
                                Day = SwitchDay(daymatch);
                                Month = SwitchMonth(monthmatch);
                            }
                            else
                            {
                                Day = SwitchDay(daymatch);
                                Month = SwitchMonth(monthmatch);
                            }
                        }
                        else
                        {
                            daymatch += 3;
                            if (daymatch > 31)
                            {
                                monthmatch += 1;
                                daymatch -= 31;
                                Day = SwitchDay(daymatch);
                                Month = SwitchMonth(monthmatch);
                            }
                            else
                            {
                                Day = SwitchDay(daymatch);
                                Month = SwitchMonth(monthmatch);
                            }
                        }
                    }
                    
                }

                outDay = string.Format("{0} {1}", Day, Month);
                return outDay;
            }
            else
            {
                throw new Exception("Wrong string format");
            }
        }
        private static string SwitchDay(int day)
        {
            string dayString = string.Empty;
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
        private static string SwitchMonth(int month)
        {
            string monthString = string.Empty;
            switch (month)
            {
                case 1:
                    monthString = "января";
                    break;
                case 2:
                    monthString = "февраля";
                    break;
                case 3:
                    monthString = "марта";
                    break;
                case 4:
                    monthString = "апреля";
                    break;
                case 5:
                    monthString = "мая";
                    break;
                case 6:
                    monthString = "июня";
                    break;
                case 7:
                    monthString = "июля";
                    break;
                case 8:
                    monthString = "августа";
                    break;
                case 9:
                    monthString = "сентября";
                    break;
                case 10:
                    monthString = "октября";
                    break;
                case 11:
                    monthString = "ноября";
                    break;
                case 12:
                    monthString = "декабря";
                    break;
            }
            return monthString;
        }
       
    }
}