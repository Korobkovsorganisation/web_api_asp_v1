﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_asp_v1.Data;
using web_api_asp_v1.Models;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : Controller
{
    // GET: ProductsController
    public ActionResult Index()
    {
        return View();
    }

    // GET: ProductsController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: ProductsController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ProductsController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProductsController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: ProductsController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProductsController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: ProductsController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
