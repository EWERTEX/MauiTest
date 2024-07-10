using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.CustomModels
{
    class TagLabel : Label
    {
        public static readonly BindableProperty TagProperty = BindableProperty.Create("Tag", typeof(string), typeof(TagLabel), "0");

        public string Tag { get { return (string)GetValue(TagProperty); } set { SetValue(TagProperty, value); } }
    }
}
