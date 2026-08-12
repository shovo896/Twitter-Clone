using System.Text ;
using System.Threading.Tasks;
using Twitter_Clone.Entities;

namespace TwitterClone.Domain.Entities
{

    public class Tweet :BaseEntity
    {
        // private Guid _id;
        private Guid _userId;
        private string _content; 
            //private DateTime _createdAt; 
       // private DateTime _modifiedAt;
        //private Guid _createdBy; 
        // private Guid _modifiedBy;

        public Tweet(string content):base(Guid.NewGuid()) 
        {
            
        }


        public string Content { get; private set; }

        public void AddContent(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                Content = string.Empty;
                // we are done ....sob sikhe kaj korba tumi    

                //  khub  eeee important 
            }
        }
    }
} 