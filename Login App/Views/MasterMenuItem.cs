using System;
using System.Collections.Generic;
using System.Text;
using Login_App.Views;

namespace Login_App
{
    class HomePageMasterMenuItem
    {
        public HomePageMasterMenuItem()
        {
            TargetType = typeof(HomeMasterPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
