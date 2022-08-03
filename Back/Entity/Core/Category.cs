using Entity.Shared;
namespace Entity.Core
{
 public   class Category:EntityId
    {
        public string Name { get; set; }
        public int ParientId { get; set; }
        public Category Parient { get; set; }
    }
}
