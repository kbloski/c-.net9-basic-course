using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseProject
{
    public class If_ifelse_else
    {
        public static void Example()
        {
            bool isMale = true;

            if (isMale) Console.WriteLine("Man");
            else if (!isMale) Console.WriteLine("Woman");
            else Console.WriteLine("Wyjątek");


            //🔹 Operatory porównania
            //==    Porównuje równość dwóch wartości(np.a == b)
            //!=    Sprawdza, czy wartości są różne
            //<     Sprawdza, czy lewa wartość jest mniejsza od prawej
            //>     Sprawdza, czy lewa wartość jest większa od prawej
            //<=    Sprawdza, czy lewa wartość jest mniejsza lub równa
            //>=    Sprawdza, czy lewa wartość jest większa lub równa
            

            
            //🔹 Operatory logiczne
            //&&    Logiczne AND – zwraca true, jeśli oba warunki są spełnione
            //!     Logiczne NOT – neguje wartość logiczną(np. !true == false)
            


            //🔹 Inne pomocne operacje(rzadziej, ale pokrewne):
            //std::is_same<T, U>::value         Szablon z < type_traits > – sprawdza, czy typy T i U są takie same(czyli jakby === dla typów)
            //typeid(a) == typeid(b)            Sprawdza, czy dwa obiekty mają ten sam typ w czasie działania(wymaga RTTI)
            //std::equal(a, b)                  Sprawdza, czy dwie kolekcje(np.vector) są równe element po elemencie
        }
    }
}
