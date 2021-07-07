namespace DefaultNamespace
{
    public class Cat: Animal
    {
        public string typecap;
        
        
    }
    
    public class Animal
    {
        public int Weight { get; set; }
       
    }
    
    public class AddressSearcher
    {
        public void Search()
        {



            Cat cc = new Cat();
            cc.Weight = 5;
        }
    }
    
     
     
     
     
     
     
     
}