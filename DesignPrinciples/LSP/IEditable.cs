using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LSP
{
    public interface IEditable
    {
        void Save(string newContent);
    }
}
