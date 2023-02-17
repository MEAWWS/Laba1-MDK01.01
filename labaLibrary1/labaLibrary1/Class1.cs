using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaLibrary1
{
    internal class LanguageLibrary
    {

        public Dictionary<int, string> Russian = new Dictionary<int, string>()
        {
            { 1, "Введите: 1 - для добавления в очередь; 2 - для принятия на приём; 3 - Показать очередь" },
            { 2, "Введиет ФИО:" },
            { 3, "Принять на приём"},
            { 4, "Нет пациентов"}

        };
        public Dictionary<int, string> English = new Dictionary<int, string>()
        {
            {1, "Enter: 1 - to add to the queue, 2 - for admission, 3 - show queue" },
            {2, "Enter your full name:" },
            {3, "Accept for an appointment" },
            {4, "No patients" }

        };

        public string Language(int ln,int key)
        {
            if (ln == 1)
            {
                Russian.TryGetValue(key, out string s);
                return s;
            }
            else
            {
                English.TryGetValue(key, out string es);
                return es;
                    
            }
        }
    }
}

   
