namespace TwitterClone.Domain.Entities{
    
    
    public class User {
        
        
        private Guid _id ;
        private string _firstname ;
        private string _lastname ;
        private strting _email; 
        
        
        public User ()
        {
            _id =Guid.NewGuid()
        }
        public Guid Id 
        {
            get 
            {
                return _id ;
                
            }
        }
        
        public string FirstName 
        {
            get 
            {
                return _firstName;
                
            }
            set 
            {
                _firstName = value ;
            }
            
        }
        
        
        
        
        
        
        
        
    }
    
}