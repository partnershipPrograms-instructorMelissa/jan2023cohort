using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
using CRApractice.Models;

namespace CRApractice.Controllers;
public class UserController : Controller {
    private MyContext _context;

    public UserController(MyContext context){
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index(){
        if(HttpContext.Session.GetInt32("uid") != null){
            return RedirectToAction("Dashboard", "Home");
        }
        else{
            return View();
        }
    }
    [HttpPost("register")]
    public IActionResult Register(User newUser){
        if(ModelState.IsValid){
            PasswordHasher<User> hash = new PasswordHasher<User>(); // create new instance of the password hasher so that we can use it on the next line
            newUser.Password = hash.HashPassword(newUser, newUser.Password);
            // let newUser.Password = hashed version of the password
            _context.Users.Add(newUser);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("uid", newUser.ID);
            HttpContext.Session.SetString("FirstName", newUser.FirstName);
            return RedirectToAction("Dashboard", "Home");
        }
        return View("Index");
    }

    [HttpPost("login")]
    public IActionResult Login(LoginUser login){
        if(ModelState.IsValid){
            User? user = _context.Users.FirstOrDefault(u => u.Email == login.LoginEmail);
            if(user == null){
                ModelState.AddModelError("LoginEmail", "Invalid Email");
            }
            else{
                PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();
                var result = hash.VerifyHashedPassword(login, user.Password, login.LoginPassword);
                if(result == 0){// not a match
                    ModelState.AddModelError("LoginEmail", "Invalid Password");
                }
                else{
                    HttpContext.Session.SetInt32("uid", user.ID);
                    HttpContext.Session.SetString("FirstName", user.FirstName);
                    return RedirectToAction("Dashboard", "Home");
                }
            }
        }
        return View("Index");
    }

    [HttpGet("logout")]
    public IActionResult Logout(){
        return View();
    }
}