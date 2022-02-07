using System.Text.Json;
using System.Text.Json.Serialization;


namespace CollectionApp.Models;

public class Item:IComparable<Item>{
   private ItemDetails? _itemDetails{get;set;}
   public string? Id{get;set;}

   public string? Type{get;set;}

   public string? ImgPath{get;set;}

   public string? Details{
      get=>JsonSerializer.Serialize(_itemDetails);
      set=>_itemDetails=JsonSerializer.Deserialize<ItemDetails>(value);
   }

   
   // Compares to another Item object. Used mainly in sort function.
   public int CompareTo(Item item){
      int c=this.Type.CompareTo(item.Type);
      //Same Type
      if(c==0){
         var detailsThis=JsonSerializer.Deserialize<ItemDetails>(this.Details);
         var detailsItem=JsonSerializer.Deserialize<ItemDetails>(item.Details);
         c=detailsThis.Name.CompareTo(detailsItem.Name);
         //Same Name
         if(c==0){
            //Manga
            if(this.Type=="Manga"){
               int? v2=detailsItem.Volume;
               int? v1=detailsThis.Volume;
               if(v1>v2) return 1;
               if(v2>v1) return -1;
               return 0;
            }
         }
      }
      return c;
   }
}