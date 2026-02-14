using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopping.Models;

namespace shopping.ViewComponents
{
    public class productViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var product = new List<product>
            {
                new product(1, "پسته ممتاز", "سرشار از پروتئین", "1.jpg"),
                new product(2, "بادام درختی", "مناسب سلامت قلب", "2.jpg"),
                new product(3, "گردو تازه", "تقویت حافظه", "3.jpg"),
                new product(4, "کشمش طلایی", "منبع طبیعی آهن", "4.jpg"),
                new product(5, "زعفران اصل", "کیفیت صادراتی", "5.jpg"),
                new product(6, "دارچین سیلان", "عطر فوق‌العاده", "6.jpg"),
                new product(7, "زنجبیل تازه", "تقویت ایمنی بدن", "7.jpg"),
                new product(8, "برنج طارم", "معطر و ممتاز", "8.jpg"),
                new product(9, "برنج هاشمی", "کیفیت اعلا", "10.jpg"),
                new product(9, "برنج هاشمی", "کیفیت اعلا", "10.jpg"),
                new product(9, "برنج هاشمی", "کیفیت اعلا", "10.jpg"),

            };
         return View("_product",product);
        }
    }
}