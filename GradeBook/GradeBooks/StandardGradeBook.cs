using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook:BaseGradeBook
    {
       public StandardGradeBook(String name):base(name)
        {
            Name = name;
            Type = Enums.GradeBookType.Standard;
        }
    }
}
