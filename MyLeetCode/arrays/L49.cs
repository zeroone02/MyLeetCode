using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode.arrays;
public class L49 //O(n)
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var sortAnagramsByAlf = new List<string>();
        var dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string str = String.Concat(strs[i].OrderBy(c => c));
            sortAnagramsByAlf.Add(str);
            if (!dict.ContainsKey(str))
            {
                dict.TryAdd(str, new List<string>());
            }
        }
        for (int i = 0; i < sortAnagramsByAlf.Count; i++)
        {
            dict[sortAnagramsByAlf[i]].Add(strs[i]);
        }
        IList<IList<string>> resultList = new List<IList<string>>();
        foreach (var valueList in dict.Values)
        {
            resultList.Add(valueList);
        }
        return resultList;
    }
}
//1.Отсортировать массив сделав все элементы в алфавитном порядке - sortArr
//2.dict Добавляю в key все возможные уникальные строки из sortArr
//3.Перебираю sortArr,и в каждый value вставляю strs[i] если sortArr[i] равен key
//4.Добавляю в resul лист все value из dict
