using System.Collections.Generic;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
