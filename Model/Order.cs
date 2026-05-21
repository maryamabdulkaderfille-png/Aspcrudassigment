public class Order 
{ 
    public int id{get;set;} 
    public string CustomerName {get;set;} = string.Empty; 
 
    public string ProductName {get; set;} = string.Empty; 
 
    public  DateTime OrderDate{get;set;} 
 
    public int Quantity{get; set;} 
     public decimal Price{get; set;} 

 
} 