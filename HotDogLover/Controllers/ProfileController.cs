﻿using HotDogLover.Models;
using HotDogLover.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotDogLover.Controllers
{
    public class ProfileController : Controller
    {
        ProfileService profileService = new ProfileService();

        // GET: Profile
        public ActionResult Index()
        {
            return View(profileService.ListAll());
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            HotDogLover.Models.Profile profile = profileService.Get(id);
            return View(profile);
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
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

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View(profileService.Get(id));
        }

        // POST: Profile/Edit/5
        [HttpPost]
        //public ActionResult Create([Bind(Include = "StudentID,Name,Email,Age,Address,City,Zip,State")] Student student)
        public ActionResult Edit([Bind(Include="ProfileID, Name,Bio,Picture")]Profile profile)
        {
            if (!ModelState.IsValid) {
                return RedirectToAction("Edit", new {id=profile.ProfileID }); 
            }
            try
            {
                profileService.Update(profile);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
