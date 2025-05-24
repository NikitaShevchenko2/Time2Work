using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BaseRepo
{
    // base repo: makes instatiating context in all repos easier
    public class RepoBase
    {
        // protected: accessible in this class and in the derived classes, not outside of these
        protected Context _context;

        public RepoBase(Context context)
        {
            _context = context; 
        }
    }
}
