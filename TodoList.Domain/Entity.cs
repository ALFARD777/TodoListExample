namespace TodoList.Domain.Entities
{
    public abstract class Entity<IPrimaryKey>
    {
        public IPrimaryKey Id { get; set; }
    }
    public class Entity : Entity<int>
    {


    }
}
