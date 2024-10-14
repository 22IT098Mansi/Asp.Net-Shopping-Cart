﻿using MyApp.DataAccessLayer.Infrastructure.IRepository;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            var Categorydb = _context.Categories.FirstOrDefault(x=>x.CategoryId == category.CategoryId);
            if(Categorydb != null)
            {
                Categorydb.CategoryName = category.CategoryName;
                Categorydb.OrderPlace = category.OrderPlace;
            }
            
        }
    }
}
