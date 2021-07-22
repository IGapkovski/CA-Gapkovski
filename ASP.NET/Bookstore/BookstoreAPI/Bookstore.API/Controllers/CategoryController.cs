using Bookstore.API.Data;
using Bookstore.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private BookstoreDbContext context { get; set; }
        public CategoryController(BookstoreDbContext _context)
        {
            context = _context;
        }
        // GET: api/Category
        [HttpGet]
        public List<Category> Get()
        {
            return context.categories.ToList();
        }
        // GET api/Category/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return context.categories.FirstOrDefault(c => c.CategoryID == id);
        }
        // POST api/Category
        [HttpPost]
        public string Post([FromBody] Category _category)
        {
            Category category = context.categories.FirstOrDefault(c => c.CategoryName == _category.CategoryName);
            if (category == null)
            {
                context.categories.Add(_category);
                context.SaveChanges();
                return String.Format("Category with name of '{0}' was added", _category.CategoryName);
            }
            else
            {
                return String.Format("There is already a category with name of '{0}'", _category.CategoryName);
            }
        }
        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Category _category)
        {
            Category category = context.categories.Find(id);
            if (category == null)
            {
                return String.Format("There is no category with id of '{0}'", id);
            }
            else
            {
                context.Entry(category).CurrentValues.SetValues(_category);
                context.SaveChanges();
                return String.Format("Category with id of '{0}' was successfully updated", id);
            }
        }
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Category category = context.categories.Find(id);
            if (category == null)
            {
                return String.Format("There is no category with id of '{0}'", id);
            }
            else
            {
                context.categories.Remove(category);
                context.SaveChanges();
                return String.Format("Category with id of '{0}' was successfully deleted", id);
            }
        }
    }
}
