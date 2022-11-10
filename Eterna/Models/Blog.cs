using Microsoft.VisualBasic;

namespace Eterna.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Owner { get; set; }
        public int CommentsCount { get; set; }
    }
}
