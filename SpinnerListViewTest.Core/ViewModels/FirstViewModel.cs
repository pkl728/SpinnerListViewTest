using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using SpinnerListViewTest.Core.Entities;
using SpinnerListViewTest.Core.Services;
using SpinnerListViewTest.Core.ViewModels.Helpers;
using System.Collections.Generic;
// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Windows.Input;
namespace SpinnerListViewTest.Core.ViewModels
{
    /// <summary>
    /// Define the FirstViewModel type.
    /// </summary>
    public class FirstViewModel : BaseViewModel
    {
        private List<Item> items;
        public List<Item> Items
        {
            get { return items; }
            set
            {
                items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        private MvxCommand doneCommand;
        public ICommand DoneCommand
        {
            get
            {
                doneCommand = doneCommand ?? new MvxCommand(async () => await DoDoneCommand());
                return doneCommand;
            }
        }

        public override void Start()
        {
            base.Start();
            Items = new List<Item>();
            for (var j = 0; j < 20; j++){
                var item = new Item();
                item.Description = "Item #" + j;
                var itemValues = new List<ItemValue>();
                for (var i = 0; i < 5; i++) {
                    var itemValue = new ItemValue();
                    itemValue.Value = "Option " + i;
                    itemValues.Add(itemValue);
                }
                item.Values = itemValues;
                Items.Add(item);
            }
        }

        private async System.Threading.Tasks.Task DoDoneCommand()
        {
            Close(this);
        }

    }
}
