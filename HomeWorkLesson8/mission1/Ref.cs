using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mission1
{
    class Ref
    {

        public static string[] ShowDateTime()
        {
            string[] RefDateTime1 = new string[16];
            DateTime DT = new DateTime();

            

            RefDateTime1[0] = ($"1.Date - {DT.Date.GetType()} \r\n");
            RefDateTime1[1] = ($"2.Day - {DT.Day.GetType()} \r\n");
            RefDateTime1[2] = ($"3.DayOfWeek - {DT.DayOfWeek.GetType()}\r\n");
            RefDateTime1[3] = ($"4.DayOfYear - {DT.DayOfYear.GetType()}\r\n");
            RefDateTime1[4] = ($"5.Hour - {DT.Hour.GetType()} \r\n");
            RefDateTime1[5] = ($"6.Kind - {DT.Kind.GetType()} \r\n");
            RefDateTime1[6] = ($"7.Millisecond - {DT.Millisecond.GetType()} \r\n");
            RefDateTime1[7] = ($"8.Minute - {DT.Minute.GetType()} \r\n");
            RefDateTime1[8] = ($"9.Month - {DT.Month.GetType()} \r\n");
            RefDateTime1[9] = ($"10.Second - {DT.Second.GetType()} \r\n");
            RefDateTime1[10] = ($"11.Ticks - {DT.Ticks.GetType()} \r\n");
            RefDateTime1[11] = ($"12.TomeOfDay - {DT.TimeOfDay.GetType()} \r\n");
            RefDateTime1[12] = ($"13.Year - {DT.Year.GetType()} \r\n");

            RefDateTime1[13] = ($"14.Now - {DateTime.Now.GetType()} \r\n");
            RefDateTime1[14] = ($"15.Today - {DateTime.Today.GetType()} \r\n");
            RefDateTime1[15] = ($"16.UtcNow - {DateTime.UtcNow.GetType()} \r\n");

            return RefDateTime1;
        }

    }
}
