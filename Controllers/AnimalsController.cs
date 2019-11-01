using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name,string taxonomy, string breed, int age, string gender, string isfixed, int page)
    {
        //the first page is actually page 0
        if(page > 0)
          page = page - 1;

        var query = _db.Animals.AsQueryable();

        if (name != null)
        {
        query = query.Where(entry => entry.Name == name).Skip(page * 5).Take(5);
        }

        if (taxonomy != null)
        {
        query = query.Where(entry => entry.Taxonomy == taxonomy).Skip(page * 5).Take(5);
        }

        if (breed != null)
        {
        query = query.Where(entry => entry.Breed == breed).Skip(page * 5).Take(5);
        }

        if (age > 0)
        {
        query = query.Where(entry => entry.Age == age).Skip(page * 5).Take(5);
        }

        if (gender != null)
        {
        query = query.Where(entry => entry.Gender == gender).Skip(page * 5).Take(5);
        }

        if (isfixed != null)
        {
        query = query.Where(entry => entry.IsFixed == Boolean.Parse(isfixed)).Skip(page * 5).Take(5);
        }
        if(name == null && taxonomy == null && breed == null && age <= 0 && gender == null && isfixed == null)
        {
          query = query.Skip(page * 5).Take(5);
        }

        return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
        return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }
    // PUT api/animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
        animal.AnimalId = id;
        _db.Entry(animal).State = EntityState.Modified;
        _db.SaveChanges();
    }
    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}
