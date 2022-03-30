using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteString
{
    public class ReadMyString
    {
        public string ReadString(int str, bool spec)
        {
            string Small_Symb = "abcdefghijklmnopqrstuvwxyz"; //Маленькие символы
            string Big_Symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Большие символы
            string Digits = "0123456789"; //Цифры
            string Spec_Symb = "!_~^<>&#@$%*"; //Спец символы
            string Sum_Res; //Общая строка
            string Result = ""; //Общий результат
            int LongSymb; //Длина общей строки

            //Если включены спец символы
            if (spec == true)
            {
                Sum_Res = Spec_Symb + Small_Symb + Big_Symb + Digits; //Получаем вот такую строку
                LongSymb = Spec_Symb.Length + Small_Symb.Length + Big_Symb.Length + Digits.Length; //Получаем общую длину строки
            }
            else
            { //Или спец символы не включены
                Sum_Res = Small_Symb + Big_Symb + Digits;
                LongSymb = Small_Symb.Length + Big_Symb.Length + Digits.Length;
            }


            //Инициализация класса генератора
            Random rnd = new Random();
            //Колчиество символов будет зависить от величины str
            for (int c = 0; c < str; c++)
            {
                int i = rnd.Next(0, LongSymb); //Запуск генератора случайных чисел от 0 до LongSymb
                Result = Result.Insert(0, Sum_Res[i].ToString()); //Получение строки из символьного потока
            }
            return Result;
        }
    }
}
