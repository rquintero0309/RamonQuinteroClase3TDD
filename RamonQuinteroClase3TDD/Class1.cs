using System;

namespace RamonQuinteroClase3TDD
{
    public class Class1
    {
        public int sumar(int uno, int dos)
        {
            return uno + dos;
        }

        public int restar(int uno, int dos)
        {
            return uno - dos;
        }

        public int multiplicar(int uno, int dos)
        {
            return uno * dos;
        }

        public string mayorPrimero (int uno,int dos)
        {
            string res = "";
            if (uno > dos)
                res= "primero es mayor";
            return res;
        }
        public string mayorSegundo(int uno, int dos)
        {
            string res = "";
            
            if (dos > uno)
             res = "segundo es mayor";
            return res;
        }
    }
}
