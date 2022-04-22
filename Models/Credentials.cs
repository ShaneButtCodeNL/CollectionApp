

public class Credentials{

   private readonly IConfiguration _config;

   public Credentials(IConfiguration config){
      _config=config;
   }
   public string? UserName{get;set;}

   public string? Password{get;set;}

   public string? Token{get;set;}
}