using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SilverTower.controls
{
    public partial class MenuLine : StackLayout
    {
        public string Name { get { return LinkName.Text; } set { LinkName.Text = value; } }

        public string ImageName { get; set; }

        public MenuLine()
        {
            InitializeComponent();
        }
    }
}
