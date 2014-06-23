using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpinnerListViewTest.Core.Entities
{
    public class ItemValue
    {
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            var rhs = obj as ItemValue;
            if (rhs == null)
            {
                return false;
            }

            return rhs.Value == Value;
        }

        public override int GetHashCode()
        {
            return Value == null ? 0 : Value.GetHashCode();
        }
    }
}
