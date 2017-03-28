using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public static class ClassExts
    {
        public static void AddWithFnc<K, V>(this IDictionary<K, V> d, K k, Func<V, V> fnc)
        {
            if (d.ContainsKey(k))
            {
                d[k] = fnc(d[k]);
            }
            else
            {
                d.Add(k, fnc(default(V)));
            }
        }

        public static string Show<K,V>(this IDictionary<K, V> d)
        {
            string result = "";
            foreach (KeyValuePair<K, V> kvp in d)
            {
                result += string.Format("{0}, {1}\n", kvp.Key.ToString(), kvp.Value.ToString());
            }
            return result;
        }

        public static string Show<K,V>(this IEnumerable<KeyValuePair<K, V>> ls)
        {
            return ls.Aggregate("", (a, i) => a += i.Show() + '\n');
        }

        public static string Show<K,V>(this KeyValuePair<K,V> t)
        {
            return string.Format("{0}, {1}", t.Key.ToString(), t.Value.ToString());
        }

        public static bool IsEqual<K, V>(this IDictionary<K, V> d1, IDictionary<K, V> d2)
        {
            if (d1.Count != d2.Count)
            {
                return false;
            }
            else
            {
                foreach (KeyValuePair<K, V> kvp in d1)
                {
                    if (!d2.ContainsKey(kvp.Key))
                    {
                        return false;
                    }
                    else if (!d2[kvp.Key].Equals(kvp.Value))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
