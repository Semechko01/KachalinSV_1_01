using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KachalinSV_1_1
{
    public class Chocolate : Pitanie//Создание класса наследуемого от класса Pitanie
    {
        public Chocolate(string _name, float _belok, float _yglevodi,float _P)//Создание конструктор класса
        {
            Name = _name;
            Belok = _belok;
            Yglevodi = _yglevodi;
            q = Q_calculator();
            P = _P;
            Qp();
        }
        float P = 0;

        public float p
        {
            get { return P; }
            set { P = value; }
        }


        public void Qp()//Формулы для нового вида качества
        {
            q = Q_calculator();
            if (P >= 0 && P <= 20)
                q = q * 1.2f + P * 9;
            else if (P > 20)
                q = q * 1.5f + P * 10;
        }
        public string Info()//Функция для вывода информации для обьекта
        {
            return $"Name: {Name}\nБелок: {Belok}г\nУглеводы: {Yglevodi}г\nQ: {q}\nЖиры: {p}";
        }
    }
}
