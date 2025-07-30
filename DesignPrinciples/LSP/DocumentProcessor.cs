using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.LSP
{
    public class DocumentProcessor
    {
        public void Process(IDocument doc)
        {
            doc.Open();
            Console.WriteLine("Processing document...");
            Console.WriteLine("Document content: " + doc.Read());
        }
        public void ProcessAndSave(IDocument doc, string additionalInfo)
        {
            //Check if doc is of type readonly document and throw exception
            if (doc is not EditableDocument editableDocument)
            {
                throw new InvalidOperationException("Cannot save a read-only document.");
            }
            doc.Open();
            string currData = doc.Read();
            string newData = currData + " " + additionalInfo;
            editableDocument.Save(newData);
            Console.WriteLine("Editable document processed and saved");
        }
    }
}