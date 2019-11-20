using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using s9tweets.Models;

namespace s9tweets
{
    public class UsersController : Controller
    {
         private Session9Context _context;

         public UsersController(Session9Context outsideWhirled) 
         {
             _context = outsideWhirled;
         }
        public IActionResult Index()
        {
           
            List<User> users = _context.UserTable.ToList();
            return View(users);
        }
    }
}