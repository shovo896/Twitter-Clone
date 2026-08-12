 using System; 
 using  System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks




 namespace Twitter_Clone.Entities
 {
  public class BaseEntity
  {
   private Guid _id;
   //private string _firstName;
  // private string _lastName;
   //private string _email;
   private DateTime _createdAt; 
   private DateTime _modifiedAt;
   private Guid _createdBy; 
   private Guid _modifiedBy; 
   
   
   
   public Guid Id { get; private  set; }

   public DateTime CreatedAt { get; private set; }

    
   public DateTime? ModifiedAt { get; private set; }
    
    public Guid CreatedBy { get; private set; } 
    public Guid? ModifiedBy { get; private set; } 
    public BaseEntity()
    {
      //_createdAt = DateTime.Now;
     //  _modifiedAt = DateTime.Now;
     Id = Guid.NewGuid(); 
     CreatedAt = DateTime.UtcNow; 
     
    }
   

  }
 }