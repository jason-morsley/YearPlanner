﻿using System;
using System.Collections.Generic;

namespace YearPlanner
{
    public class DayOffsets
    {
        private Year _year;

        private Dictionary<int, int> _leftOffsets;
        private Dictionary<int, int> _rightOffsets;

        public Dictionary<int, int> LeftOffsets => _leftOffsets;
        public Dictionary<int, int> RightOffsets => _rightOffsets;

        public void CalculateDayOffsets()
        {
            CalculateLeftOffsets();
            CalculateRightOffsets();

            //foreach (var kvp in widestMonths)
            //{
            //    var month = kvp.Key;
            //    var widestMonthsValue = kvp.Value;

            //    var noDaysInMonth = Month.GetNumberOfDaysInMonth(_year.Value, month);

            //    _rightOffsets.Add(month, (widestMonth - noDaysInMonth) - (highestSunday - widestMonthsValue));
            //}

            //foreach (var kvp in highestSundays)
            //{
            //    var month = kvp.Key;
            //    var day = kvp.Value;

            //    _leftOffsets.Add(month, highestSunday - day);
            //}
        }

        private void CalculateRightOffsets()
        {
        }

        private void CalculateLeftOffsets()
        {
            // First determine the 
            //var highestSundays = new Dictionary<int, int>();
            //var widestMonths = new Dictionary<int, int>();

            //var widestMonth = 0;
            //var highestSunday = 0;
            //foreach (var month in _year.Months)
            //{
            //    foreach (var day in month.Days)
            //    {
            //        var dt = new DateTime(_year.Value, month.Value, day.Value);
            //        if (dt.DayOfWeek == DayOfWeek.Sunday)
            //        {
            //            highestSundays.Add(month.Value, day.Value);
            //            widestMonths.Add(month.Value, day.Value);

            //            if (dt.Day > highestSunday)
            //            {
            //                highestSunday = dt.Day;

            //                widestMonth = highestSunday + Month.GetNumberOfDaysInMonth(_year.Value, month.Value);
            //            }
            //            break;
            //        }
            //    }
            //}
        }

        public DayOffsets(Year year)
        {
            // Is year object valid? If not, throw error. null checking.

            _year = year;

            _leftOffsets = new Dictionary<int, int>();
            _rightOffsets = new Dictionary<int, int>();

            CalculateDayOffsets();
        }
    }
}