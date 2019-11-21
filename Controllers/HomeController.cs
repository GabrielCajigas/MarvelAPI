using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using M_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using M_app.MarvelApi;

using System.ComponentModel.DataAnnotations.Schema;

namespace M_app.Controllers
{
    public class HomeController : Controller
    {
        private ElContext context;

        public HomeController(ElContext ec)
        {
            context = ec;
        }



        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(OldUser user)
        {
            User userInDb = context.Users.FirstOrDefault(u => u.email == user.EmailO);
            if (!ModelState.IsValid)
            {

                return View("Index");

            }
            if (userInDb == null)
            {
                ModelState.AddModelError("EmailO", "Email not found!");
            }
            else
            {
                var hasher = new PasswordHasher<OldUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.password, user.PasswordO);
                if (result == 0)
                {
                    ModelState.AddModelError("PassdwordO", "Incorrect Password!");
                }
            }
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return Redirect("main");
        }



        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // if (context.Users.Any(u => u.email == user.email))
            // {
            //     ModelState.AddModelError("email", "Email already in use!");
            // }
            if (ModelState.IsValid)
            {
                Console.WriteLine("valid");
                var hasher = new PasswordHasher<User>();
                user.password = hasher.HashPassword(user, user.password);
                context.Users.Add(user);
                context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return Redirect("main");
            }
            Console.WriteLine("not valid");

            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
        [HttpGet("main")]
        public IActionResult Main()
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            User userInDb = context.Users.FirstOrDefault(u => u.UserId == userid);
            ViewBag.User = userInDb;
            ViewBag.Heroes = context.elchar;
            return View("Main");
        }

        public async Task<IActionResult> Hero(string searchString)
        {
            var _marvel = new MarvelApi.Marvel();
            CharacterDataWrapper CharacterModel = await _marvel.GetCharacters(searchString);
            Character _character = CharacterModel.Data.Results.FirstOrDefault();


            // ComicDataWrapper comicModel = await _marvel.GetComicsForCharacter(_character.Id);
            // List<Comic> _comics = comicModel.Data.Results;
            // List<Comic> _ComicsWithImages = new List<Comic>(3);
            // int count = 0;
            //some of the data is not in the api db. So skip the comics that do not have images and trim the description
            // foreach (var comic in _comics)
            // {
            //     int pathlength = 0;
            //     if (count == 3)
            //     {
            //         break;
            //     }

            //     //Truncate the description if it is too long
            //     if (!String.IsNullOrEmpty(comic.Description))
            //     {
            //         if (comic.Description.Length > 360)
            //         {
            //             comic.Description = comic.Description.Substring(0, 360) + " ...";
            //         }
            //     }

            //     pathlength = comic.Thumbnail.Path.Length;

            //     if (comic.Thumbnail.Path.Substring(pathlength - 19, 19) != "image_not_available")
            //     {
            //         _ComicsWithImages.Add(comic);
            //         count++;
            //     }
            // }

            // CharacterComicViewModel ccVM = new CharacterComicViewModel();

            // ccVM.Character = _character;
            // ccVM.Comics = _ComicsWithImages;
            // ccVM.AttributionText = CharacterModel.AttributionText;
            if (_character == null)
            {
                return Redirect("/main");
            }
            return View(_character);

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Add(string heroname)
        {
            var _marvel = new MarvelApi.Marvel();
            CharacterDataWrapper CharacterModel = await _marvel.GetCharacters(heroname);
            Character _character = CharacterModel.Data.Results.FirstOrDefault();


            int? userid = HttpContext.Session.GetInt32("UserId");
            User userInDb = context.Users.FirstOrDefault(u => u.UserId == userid);

            _character.usuario = userInDb;
            if (context.elchar.Any(u => u.Id == _character.Id))
            {
                return Redirect("/main");
            }
            else
            {
                context.elchar.Add(_character);
                context.SaveChanges();
                return RedirectToAction("Main");

            }

        }
        [Route("delete/{heroesid}")]
        [HttpGet]
        public IActionResult Delete(int heroesid)
        {
            int? userid = HttpContext.Session.GetInt32("UserId");
            User userInDb = context.Users.FirstOrDefault(u => u.UserId == userid);
            if (userid == null)
            {
                return Redirect("/");
            }
            var heroe = context.elchar.FirstOrDefault(h => h.Id == heroesid);
            context.elchar.Remove(heroe);
            context.SaveChanges();
            return Redirect("/main");
        }
    }
}
