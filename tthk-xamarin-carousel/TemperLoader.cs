using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace tthk_xamarin_carousel
{
    class TemperLoader
    {
        static string[] temperamentTitles = new string[] { "C++", "C#", "Python", "Golang (Go)"/*, "PHP"*/ };
        static string[] temperamentDescriptions = new string[]
        {
            "Компилируемый, статически типизированный язык программирования общего назначения. Поддерживает такие парадигмы программирования, как процедурное программирование, объектно-ориентированное программирование, обобщённое программирование.",
            "Современный объектно-ориентированный и типобезопасный язык программирования. C# позволяет разработчикам создавать разные типы безопасных и надежных приложений, выполняющихся в . NET.",
            "Это язык общего назначения, что означает, что он предназначен для использования в различных приложениях, включая науку о данных, разработку программного обеспечения и веб-разработку и автоматизацию. Процесс разработки занимает крайне мало времени",
            "Язык программирования, созданный компанией Google. Является компилируемым, а сам компилятор поддерживается большинством популярных операционных систем — BSD, Linux, Windows.",
            //"Это распространённый язык программирования общего назначения с открытым исходным кодом. PHP специально сконструирован для веб-разработок и его код может внедряться непосредственно в HTML."
        };
        static string[] temperamentPictures = new string[] { "name.PNG", "issue.PNG", "python.PNG", "bober.PNG" };

        public static List<Temperament> LoadStaticValues()
        {
            List<Temperament> tempers = new List<Temperament>();
            for (int i = 0; i < temperamentTitles.Length; i++)
            {
                tempers.Add(new Temperament()
                {
                    Title = temperamentTitles[i],
                    Description = temperamentDescriptions[i],
                    Picture = temperamentPictures[i]
                });
            }
            return tempers.ToList();
        }
    }
}
