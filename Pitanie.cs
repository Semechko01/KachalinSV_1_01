using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KachalinSV_1_1
{
    public class Pitanie
    {
        
        public Pitanie()
        {

        }
        public Pitanie(string _name, float _belok, float _yglevodi)
        {
            name = _name;
            belok = _belok;
            yglevodi = _yglevodi;
            Q = Q_calculator();
        }
        string name = "";
        float belok = 0;
        float yglevodi = 0;
        float Q = 0;
        public float Q_calculator()
        {
            return yglevodi * 8 + belok * 5;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Belok
        {
            get { return belok; }
            set { belok = value; }
        }
        public float Yglevodi
        {
            get { return yglevodi; }
            set { yglevodi = value; }

        }
        public float q
        {
            get { return Q; }
            set { Q = value; }
        }
        public string Info()
        {
            return $"Name: {Name}\nБелок: {Belok}г\nУглеводы: {Yglevodi}г\nQ: {q}";
        }
    }
}
