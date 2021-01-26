namespace API.Entities
{
    public class Product
    {
        //if we specify it as a int and Id field name, the framework will automatically treat as a primary key
        public int Id { get; set; }
        public string Name { get; set; }
    }
}