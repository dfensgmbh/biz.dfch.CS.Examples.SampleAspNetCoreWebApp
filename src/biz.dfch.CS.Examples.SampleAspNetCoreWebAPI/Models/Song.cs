namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Album Album { get; set; }
    }
}
