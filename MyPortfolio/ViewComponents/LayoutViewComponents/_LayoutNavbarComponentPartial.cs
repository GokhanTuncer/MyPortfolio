using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count(); //Yapılmamış Bildirim sayısı
			var value = context.ToDoLists.Where(x => x.Status == false).ToList(); 
			return View(value);
		}
	}
}
