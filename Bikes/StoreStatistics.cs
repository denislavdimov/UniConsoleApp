using static System.Console;

namespace Uni.Bikes
{
    public class StoreStatistics
    {
        public static Dictionary<int, T> Statistics<T>(List<T> list)
        {
            var dic = new Dictionary<int, T>();
            for (int i = 0; i < list.Count; i++)
            {
                dic.Add(i, list[i]);
            }
            return dic;
        }

        public static void ShowAll<T, T1>(List<T> list, List<T1> list2)
        {
            WriteLine($"All Enduros: {Statistics(list).Count}");
            WriteLine($"All Downhills: {Statistics(list2).Count}");
        }
    }
}
