using System;
using System.Data.SqlClient;
using System.Linq;

namespace MyFirstCallOfEntites
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DefaultContext())
            {
                var request = from monParagraph in context.Paragraphs
                              select monParagraph;

                var list = request.ToList();

                list.ForEach(item => Console.WriteLine(item.Title));

               

            }   
        }
    }
}
