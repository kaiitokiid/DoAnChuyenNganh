using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Utilities.Slides
{
    public class SlideViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { set; get; }
        public string Url { set; get; }

        public string Image { get; set; }
        public int SortOrder { get; set; }

    }
}
