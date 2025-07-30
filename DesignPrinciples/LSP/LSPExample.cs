using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LSP
{
    public class LSPExample
    {
        public static void Main(string[] args)
        {
            IDocument editable = new EditableDocument("Draft proposal for Q3.");
            IDocument readOnly = new ReadOnlyDocument("Top secret strategy.");
            
            DocumentProcessor processor = new DocumentProcessor();
            processor.Process(readOnly);
            processor.ProcessAndSave(editable, "Additional notes");
        }
    }
}
