using Xamarin.Forms;

namespace BarInfo.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public string Image
        {
            get
            {
               return "bar.jpg";
            }
        } 

    }
}