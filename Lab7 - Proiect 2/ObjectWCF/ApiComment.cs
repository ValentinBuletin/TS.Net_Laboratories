using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ObjectWCF
{
    public class ApiComment : Interface1
    {
        void Interface1.Add(string column)
        {
            Class1.Add(column);
        }
        void Interface1.Remove(string column)
        {
            Class1.Remove(column);
        }
        void Interface1.Delete(string where, string whereValue)
        {
            Class1.Delete(where, whereValue);
        }
        List<string> Interface1.Check(string check)
        {
            return Class1.Check(check);
        }
        void Interface1.Modify(string set, string setValue, string where, string whereValue)
        {
            Class1.Modify(set, setValue, where, whereValue);
        }
        List<string> Interface1.SearchPath(string column, string text)
        {
            return Class1.SearchPath(column, text);
        }
        List<string> Interface1.Search(string column, string text)
        {
            return Class1.Search(column, text);
        }
        List<string> Interface1.Columns()
        {
            return Class1.Columns();
        }
        bool Interface1.Insert(string name, string fullPath, string type, double size, DateTime dateCreated)
        {
            return Class1.Insert(name, fullPath, type, size, dateCreated);
        }
    }
}
