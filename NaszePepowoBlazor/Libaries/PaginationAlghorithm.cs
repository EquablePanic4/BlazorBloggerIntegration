using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszePepowoBlazor.Libaries
{
    public class PaginationAlghorithm
    {
        public static List<int> GetPaginationList(int current, int last)
        {
            //Chcemy mieć 7 elementów maksymalnie <-- 3 w tył [obecna] 3 w przód -->
            var lista = new HashSet<int>();

            //Cofanie w tył
            for (var i = current - 1; i >= 1 && (current - i) <= 2; i--)
                lista.Add(i);

            lista.Add(current);

            //Następne strony
            for (var i = current; i <= last && (i - current) <= 2; i++)
                lista.Add(i);

            //Sprawdzamy czy jest pierwsza i ostatnia strona
            if (!lista.Contains(1))
                lista.Add(1);

            if (!lista.Contains(last))
                lista.Add(last);

            //Zwracamy listę
            return lista.OrderBy(o => o).ToList();
        }
    }
}
