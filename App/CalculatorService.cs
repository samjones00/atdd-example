using System.Collections.Generic;
using System.Linq;
using App.Models;

namespace App
{
    public class CalculatorService
    {
        private decimal _total;
        private readonly IList<decimal> _actions = new List<decimal>();

        public void Send(MathOperation operation)
        {
            if (operation.Operation.Equals(OperationType.Add))
            {
                Add(operation.Value);
                return;
            }

            Subtract(operation.Value);
        }

        public void Add(decimal value) => _actions.Add(value);
        public void Subtract(decimal value) => _actions.Add(value * -1);
        public void Calculate() => _total = _actions.Sum();
        public decimal Total() => _total;
    }
}
