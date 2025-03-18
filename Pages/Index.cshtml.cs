﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld_ASP_Razor_2.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        //  public string Name;  //fields

        public string Name { get; set; }
        public int Age { get; set; }

        public string Result { get; set; }



        public void OnGet()
        {

        }


        public void OnPost()
        {

            Result = $"Hello {Name}, you are {Age} years old";

        }


    }
}
