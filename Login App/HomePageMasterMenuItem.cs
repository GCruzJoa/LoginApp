using System;
using System.Collections.Generic;
using System.Text;

namespace Login_App
{
    class HomePageMasterMenuItem
    {
        public HomePageMasterMenuItem()
        {
            TargetType = typeof(HomePageMaster);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
