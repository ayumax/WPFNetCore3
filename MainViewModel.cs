using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

#nullable enable

namespace WPFNetCore3
{
    class MainViewModel
    {
        public ObservableCollection<ListItem> Items { get; }

        public string text { get; }


        public MainViewModel()
        {
            Items = new ObservableCollection<ListItem>();

            for (int i = 0; i < 10; ++i)
            {
                Items.Add(new ListItem() { Name = $"ABC{i}" });
            }


            text = null!;

        }
    }
}
