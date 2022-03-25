using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.UI.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Filter<T>(this List<T> list, Func<T, bool> predicate = null)
        {
            if(predicate is null)
            {
                return list;
            }

            return new List<T>(list.Where(predicate));
        }

        public static void ForEach<T>(this List<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        public static void Foreach<T>(this List<T> list, Action<T>[] actions)
        {
            if(actions is null || list is null)
            {
                return;
            }

            foreach (var item in list)
            {
                foreach (var action in actions)
                {
                    action(item);
                }
            }
        }
    }
}
