using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using PhuKien.Data;
using PhuKien.Models;

namespace PhuKien.Controllers
{
    public class NewsController : Controller
    {
        private readonly PhuKienContext _context;

        public NewsController(PhuKienContext context)
        {      
            _context = context;
        }
        public async Task<IActionResult> ListNews(int page = 1)
        {
            int totalRow = 0;
            var pageSize = 1;
            var news = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            totalRow = news.Count();
            var sanphams = news.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<News>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            ViewBag.ListCate = await _context.CategoriesNews.ToListAsync();
            ViewBag.ListNews = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToListAsync();
            return View(paginationSet);
        }

        public async Task<IActionResult> Category(long id, int page = 1)
        {
            int totalRow = 0;
            var pageSize = 1;
            var news = await _context.News.Where(x => x.Status == 1 && x.CategoryId == id).OrderBy(x => x.DisplayOrder).ToListAsync();
            totalRow = news.Count();
            var sanphams = news.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<News>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            ViewBag.category = await _context.CategoriesNews.Where(x => x.Status == 1 && x.Id == id).SingleOrDefaultAsync();
            ViewBag.ListCate = await _context.CategoriesNews.ToListAsync();
            ViewBag.ListNews = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToListAsync();
            return View(paginationSet);
        }

        public async Task<IActionResult> Detail(long id)
        {
            var blog = await _context.News.Where(x => x.Status == 1&& x.Id==id).SingleOrDefaultAsync();
            ViewBag.ListNews = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToListAsync();
            ViewBag.relatedNews = await _context.News.Where(x => x.CategoryId == blog.CategoryId && x.Id != id && x.Status == 1).OrderBy(x => x.DisplayOrder).Take(5).ToListAsync();
            ViewBag.categories = await _context.CategoriesNews.ToListAsync();
            return View(blog);
        }
    }
}
