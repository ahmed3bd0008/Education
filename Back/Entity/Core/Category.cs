using System.Collections.Generic;
using Entity.Shared;
namespace Entity.Core
{
 public   class Category:EntityId

{
    
    public string Name { get; set; }
    public int ParentID { get; set; }
   public List<Category> Subcategories { get; set; }
}
    }
