 using System; 
 using  System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks;




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
  }
 }