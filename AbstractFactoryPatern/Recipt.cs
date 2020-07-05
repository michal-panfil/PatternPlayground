using System;

namespace AbstractFactoryPatern
{
    public class Recipt : ITranscationDocument
    {
        public void GeneratePdf()
        {
            Console.WriteLine($"Document of transaction is {this.GetType()}");
        }

    }
}
