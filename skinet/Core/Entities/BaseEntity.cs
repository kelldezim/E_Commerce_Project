namespace Core.Entities
{
    public class BaseEntity
    {
        //if we specify it as a int and Id field name, the framework will automatically treat as a primary key
        public int Id { get; set; }
    }
}