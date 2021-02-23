using System;
using System.Collections.Generic;
using System.Text;
using Login_App.Models;

namespace Login_App.ViewModels
{
    public class TabbedHomeViewModel
    {
        // Discobery Tab Menu Option Properties
        public TabbedMenuOption BarAndHotelsMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption FineDiningMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption CafesMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption NearbyMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption FastFoodsMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption FeaturedFoodsMenuOption { get; set; } = new TabbedMenuOption();


        // TabbedPage Menu Option Properties
        public TabbedMenuOption HomeMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption DiscoveryMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption BookmarkMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption TopFoodMenuOption { get; set; } = new TabbedMenuOption();
        public TabbedMenuOption ProfileMenuOption { get; set; } = new TabbedMenuOption();

        public TabbedHomeViewModel()
        {
            // Discovery Tab Menu Options
            BarAndHotelsMenuOption.Title = "Bar and Hotels"; BarAndHotelsMenuOption.Image = "beer.png";
            FineDiningMenuOption.Title = "Fine Dining"; FineDiningMenuOption.Image = "servingDish.png";
            CafesMenuOption.Title = "Cafes"; CafesMenuOption.Image = "coffeeShop.png";
            NearbyMenuOption.Title = "Nearby"; NearbyMenuOption.Image = "route.png";
            FastFoodsMenuOption.Title = "Fast Foods"; FastFoodsMenuOption.Image = "fastFood.png";
            FeaturedFoodsMenuOption.Title = "Featured Foods"; FeaturedFoodsMenuOption.Image = "pizzaSlice.png";


            // TabbedPage Menu Options
            HomeMenuOption.Title = "Home"; HomeMenuOption.Image = "home.png";
            DiscoveryMenuOption.Title = "Discovery"; DiscoveryMenuOption.Image = "discovery.png";
            BookmarkMenuOption.Title = "Bookmark"; BookmarkMenuOption.Image = "bookmark.png";
            TopFoodMenuOption.Title = "Top Food"; TopFoodMenuOption.Image = "trophy.png";
            ProfileMenuOption.Title = "Profile"; ProfileMenuOption.Image = "profile.png";
        }
    }
}
