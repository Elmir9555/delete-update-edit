using EntityMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityMigration.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public SliderDetail Detail { get; set; }
        public VideoValentine Videos { get; set; }
        public Valentine Valentines { get; set; }
        public Experts Experts { get; set; }
        public List<Employee> Employees { get; set; }
        public Blog Blogs { get; set; }
        public List<BlogCards> BlogCards { get; set; }
        public List<InstaCarousel> InstaCarousels { get; set; }
    }
}
