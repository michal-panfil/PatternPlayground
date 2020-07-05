using System;

namespace AbstractFactoryPatern
{
    public class Invoice : ITranscationDocument
    {
        public void GeneratePdf()
        {
            Console.WriteLine($"Document of transaction is {this.GetType()}");
        }

    }
}
