using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LSP
{
    public class EditableDocument : IDocument, IEditable
    {
        private string content;
        public EditableDocument(string content) { this.content = content; }
        
        public void Open()
        {
            Console.WriteLine("Document opened. Data: " + Preview());
        }
        //Implement Save of IEditable
        public void Save(string newContent)
        {
            this.content = newContent;
            Console.WriteLine("Document saved with new content.");
        }
        public string Read()
        {
            Console.WriteLine("Reading document content: " + content);
            return content;
        }
        private string Preview()
        {             
            return content.Length > 20 ? content.Substring(0, 20) + "..." : content;
        }
    }
}
