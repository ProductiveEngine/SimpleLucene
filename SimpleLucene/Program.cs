using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Copy from the tutorial
//https://www.codeproject.com/Articles/320219/Lucene-Net-ultra-fast-search-for-MVC-or-WebForms
namespace SimpleLucene
{
    class Program
    {
        static void Main(string[] args)
        {
            LuceneSearch.AddUpdateLuceneIndex(SampleDataRepository.GetAll());
            List<SampleData> s = LuceneSearch.Search("USA", "Description").ToList();
            Console.WriteLine(s.Count);
            Console.ReadKey();
        }
        
    }
}
