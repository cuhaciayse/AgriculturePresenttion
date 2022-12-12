﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresenttion.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.GetById(id);
            return View(value); 
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value=_contactService.GetById(id);
            return View(value);
        }
    }
}
