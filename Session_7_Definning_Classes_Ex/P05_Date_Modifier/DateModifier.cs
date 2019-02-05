using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Date_Modifier
{
    class DateModifier
    {

        private string firstDate;
        private string scndDate;


        public String FirstDate
        {
            get { return this.firstDate; }
            set { this.firstDate = value; }
        }

        public String ScndDate
        {
            get { return this.scndDate; }
            set { this.scndDate = value; }
        }


        public int DifferenceBetweenDates(String dateOne, string DateTwo)
        {
            var dateOneEntries = dateOne.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var dateOneYear = int.Parse(dateOneEntries[0]);
            var dateOneMonth = int.Parse(dateOneEntries[1]);
            var dateOneDay = int.Parse(dateOneEntries[2]);

            var dateOneDateTime = new DateTime(dateOneYear, dateOneMonth, dateOneDay);

            var dateTwoEntries = DateTwo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var dateTwoYear = int.Parse(dateTwoEntries[0]);
            var dateTwoMonth = int.Parse(dateTwoEntries[1]);
            var dateTwoDay = int.Parse(dateTwoEntries[2]);

            var dateTwoDateTime = new DateTime(dateTwoYear, dateTwoMonth, dateTwoDay);

            var difference = Math.Abs((dateTwoDateTime - dateOneDateTime).Days);

            return difference;


        }

    }
}
