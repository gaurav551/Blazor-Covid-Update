using System.Collections.Generic;

namespace BlazorCrud.Models
{

    public class NepalDistrictWise
    {
        public List<Class1> Property1 { get; set; }
    }

    public class Class1
    {
        public string _id { get; set; }
        public int id { get; set; }
        public float[] bbox { get; set; }
        public Centroid centroid { get; set; }
        public string title { get; set; }
        public string title_en { get; set; }
        public string title_ne { get; set; }
        public string code { get; set; }
        public int province { get; set; }
    }

    public class Centroid
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }

}