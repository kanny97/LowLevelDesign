using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LSP
{
    public class ReadOnlyDocument : IDocument
    {
        private readonly string content;
        public ReadOnlyDocument(string content)
        {
            this.content = content;
        }
        public void Open()
        {
            Console.WriteLine("Document opened. Data: " + Preview());
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
