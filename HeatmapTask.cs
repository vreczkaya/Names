using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var dates = new string[30];
            var months = new string[12];
            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = (i + 2).ToString();
            }
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = (i + 1).ToString();
            }
            var heatmap = new double[30, 12];
            foreach (var name in names)
            {
                if (name.BirthDate.Day != 1) heatmap[name.BirthDate.Day - 2, name.BirthDate.Month - 1]++;
            }
            return new HeatmapData(
                "Пример карты интенсивностей",
                heatmap, 
                dates, 
                months);
        }
    }
}