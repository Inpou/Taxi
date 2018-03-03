using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiExceptions
{
    /// <summary>
    /// Виключення ,що виникає при спробі змінити довжину ребра 
    /// </summary>
    class SetLengthExceptions : Exception
    {
        public SetLengthExceptions() : base() { }
        public SetLengthExceptions(string Message) : base(Message) { }
    }
    /// <summary>
    /// Виключення, що виникає при спробі викорисати не існуючий вузол
    /// </summary>
    class WrongNodeReferenceException : Exception
    {
        public WrongNodeReferenceException() : base() { }
        public WrongNodeReferenceException(string Message) : base(Message) { }
    }
    /// <summary>
    /// Виключення, що виникає при спробі викорисати ребро з довжиною ,яка рівна або менша нуля
    /// </summary>
    class WrongEdgeLengthException : Exception
    {
        
        public WrongEdgeLengthException() : base() { }
        public WrongEdgeLengthException(string Message) : base(Message) { }
    }

}
