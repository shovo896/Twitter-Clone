namespace Twitter_Clone.Entities;

public class BaseEntity
{
   public Guid Id { get; private set; }
   public DateTime CreatedAt { get; private set; }
   public DateTime? ModifiedAt { get; private set; }
   public Guid CreatedBy { get; private set; }
   public Guid? ModifiedBy { get; private set; }

   public BaseEntity()
   {
       Id = Guid.NewGuid();
       CreatedAt = DateTime.UtcNow;
   }

   //public string DescribeRecord
  // {
       
   //}
   public viod SetyModified()
   {
       ModifiedAt = DateTime.UtcNow;
       ModifiedBy = ModifiedBy;
   }
}