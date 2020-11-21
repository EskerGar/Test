
using System;

public class PlayerModel
{

   public event Action<int> OnChangedCount; 
   
   private int _clickCount;

   public void AddCount()
   {
      OnChangedCount?.Invoke(++_clickCount);
   }
}
