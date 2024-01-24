namespace TesPraktekKPL_1302200022
{
    public class Mobil
    {
        public string brand { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Mobil(string brand, string name, string description)
        {
            this.brand = brand;
            this.name = name;
            this.description = description;
        }
    }
}
