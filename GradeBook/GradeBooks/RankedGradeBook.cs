using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(String name):base(name)
        {
            Name = name;
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
