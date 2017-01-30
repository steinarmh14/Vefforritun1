﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vefforittun_20151_Project5_Solution.Models;

namespace Vefforittun_20151_Project5_Solution.Controllers
{
    public class MovieAppController : Controller
    {

        public ActionResult Index()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            IEnumerable<Movie> model = MovieAppRepository.Instance.GetAllMovies(username);
            return View(model);
        }

        public ActionResult Detail(int? id)
        {
            if(id.HasValue)
            {
                int realID = id.Value;
                string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                Movie model = MovieAppRepository.Instance.GetMovieById(username, realID);
                return View(model);
            }
            return View("Error");
        }

        [HttpPost]
        public ActionResult RateMovie(FormCollection collection)
        {
            string movieId = collection["movieid"];
            string rateInfo = collection["rateinfo"];

            int id = Int32.Parse(movieId);
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            if (String.IsNullOrEmpty(movieId))
            {
                return View("Error");
            }
            if(String.IsNullOrEmpty(rateInfo))
            { 
                //return RedirectToAction("Detail", "MovieApp", new { id = movieId });
                var movie = MovieAppRepository.Instance.GetMovieById(username, id);
                return Json(movie, JsonRequestBehavior.AllowGet);
            }
            

            Rating rating = MovieAppRepository.Instance.GetRatingsByID(id).Where(x => x.Username == username).SingleOrDefault();
            if(rating != null)
            {
                rating.rating = Int32.Parse(rateInfo);
                MovieAppRepository.Instance.UpdateRating(rating);                
            }
            else 
            {
                Rating newRating = new Rating { MovieId = id, rating = Int32.Parse(rateInfo), Username = username };
                MovieAppRepository.Instance.AddRating(newRating);
            }

            var movie2 = MovieAppRepository.Instance.GetMovieById(username,id);
            return Json(movie2, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult ReviewMovie(FormCollection collection)
        {
            string movieId = collection["movieid"];
            string reviewText = collection["reviewtext"];

            if (String.IsNullOrEmpty(movieId))
            {
                return View("Error");
            }

            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int id = Int32.Parse(movieId);
            Movie movie = MovieAppRepository.Instance.GetMovieById(username, id);
            if (String.IsNullOrEmpty(reviewText))
            {
                //return RedirectToAction("Detail", "MovieApp", new { id = movieId });
                var allComments = MovieAppRepository.Instance.GetMovieById(username, id);
                return Json(allComments, JsonRequestBehavior.AllowGet);
            }

            /*string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int id = Int32.Parse(movieId);
            Movie movie = MovieAppRepository.Instance.GetMovieById(username, id);*/
            if (movie != null)
            {
                Review review = new Review{ Text = reviewText, Username = username, MovieId = id };
                MovieAppRepository.Instance.AddReview(review);
                //return RedirectToAction("Detail", "MovieApp", new { id = movieId });
                var allComments = MovieAppRepository.Instance.GetMovieById(username, id);
                return Json(allComments, JsonRequestBehavior.AllowGet);
            }
            return View("Error");

           /* if (ModelState.IsValid)
            {
                model.Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                MovieAppRepository.Instance.AddReview(model);
            }

            // Sækjum öll comment og skilum þeim sem JSON
            var allComments = MovieAppRepository.Instance.GetAllComments();
            return Json(allComments, JsonRequestBehavior.AllowGet);*/
        }


        //
        // POST: /VideoApp/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
