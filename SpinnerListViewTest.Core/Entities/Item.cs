using System.Collections.Generic;

namespace SpinnerListViewTest.Core.Entities
{
    public class Item
    {
        public Item()
        {
            Value = new ItemValue { Value = "[Choose value]" };
        }

        public string Description { get; set; }

        public ItemValue Value { get; set; }

        public string Comment { get; set; }

        private List<ItemValue> values;
        
        public List<ItemValue> Values {
            get { return values; }
            set
            {
                values = new List<ItemValue>();
                var fakeValue = new ItemValue { Value = "[Choose value]" };
                values.Add(fakeValue);
                values.AddRange(value);
            } 
        }
    }
}
