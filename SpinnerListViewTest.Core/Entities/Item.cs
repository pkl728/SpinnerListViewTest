using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SpinnerListViewTest.Core.Entities
{
    public class Item
    {
        public string Description { get; set; }

        public string Value { get; set; }

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
