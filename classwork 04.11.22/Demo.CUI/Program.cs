using Demo.Data;

namespace Demo.CUI
{
    internal class Program
    {      public class Point2d
        {
        
        }
        public static void Main()
        {
     

            var repo = new EmployeeFakeRepository();    
            Console.WriteLine(repo.Count);
            List<Point2d> ints = new()
            {
                new Point2d() { X = 3, Y = 65 },
                new Point2d() { X = 29, Y = 9 },
                new Point2d() { X = 8, Y = 12 },
                new Point2d() { X = 1, Y = 65 },
                new Point2d() { X = 16, Y = 65 },
                new Point2d() { X = 1, Y = 12 },
                new Point2d() { X = 55, Y = 26 },
                new Point2d() { X = 5, Y = 12 },
                new Point2d() { X = 9, Y = 33 },
                new Point2d() { X = 15, Y = 26 },
                new Point2d() { X = 18, Y = 26 }
            };
            var otherInts = ints.GroupBy(c => c.Y);
            List<Point2d> otherInts = ints
                .Where(c => c.X <= 10) //фильтрфция
                .OrderBy(c => c.Y)      //сортировка
                .ThenBy(c => c.X)       //след. уровень сорт
                .Select(c => c)         //проецирование
                .ToList();              //преобразование в list
            foreach (var cur in otherInts)
                Console.WriteLine($"{cur}");
            var result = ints.All(c => c.X >= 0 && c.Y >= 0); // соответсвиет всех элементов
        result = ints.Any(c => c.X % 2 == 0 && c.Y % 2 == 0); // соответствие хотя-бы одного элемента
        }
    }
}