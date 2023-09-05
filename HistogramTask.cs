using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var dates = new string[31];
            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = (i + 1).ToString();
            }
            var birthCounts = new double[dates.Length];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Name == name)
                {
                    birthCounts[names[i].BirthDate.Day - 1]++;
                }
            }
            birthCounts[0] = 0;
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                dates,
                birthCounts);
        }
    }
}