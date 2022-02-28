public class ListUpdateService{
   public async Task Update(){
      if(ListChange!=null){
         await ListChange.Invoke();
      }
   }
   public event Func<Task>? ListChange;
}