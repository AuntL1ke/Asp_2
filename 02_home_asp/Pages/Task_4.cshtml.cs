using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_home_asp.Pages.Models;
using _02_home_asp.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _02_home_asp.Pages
{
	public class Task_4Model : PageModel
    {

        public List<Restaurant> Items { get; set; }
        public void OnGet()
        {
            Items = Restaurants.GetAll();

        }
    }
}
