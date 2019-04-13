using System;
using System.Collections.Generic;
using System.Text;
using Reactive.Bindings;

namespace WPFNetCore3
{
    class ListItem : ViewModelBase
    {
        private string _Name = "Default";
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                RaizeChanged();
            }

        }

        public ReactiveCommand SelectedCommand { get; }

        public ListItem()
        {
            SelectedCommand = new ReactiveCommand();
            SelectedCommand.Subscribe(() => Name = "Pushed");
        }

    }
}
