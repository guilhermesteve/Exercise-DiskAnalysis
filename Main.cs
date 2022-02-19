    
using System;
using System.Collections.Generic;

public class DiskAnalysis
{
    
    public static int MaxPossiblespace(int x , List<int> space){
        
        var MaximumPossible = 0; 
        var ListMax = new List<int>();
        for(int i = 0; i < space.Count ; i++){
            int maxofgroup = 0;
            
             
            if((i+x) > space.Count ){
                break;
            }
            
            for(int y = i; y < x+i ; y++){
              
                var n = space[y];
                if(n >  maxofgroup){
                     
                    maxofgroup = n;
                }
            }
            
            ListMax.Add(maxofgroup);
        }
        
        for( int i = 0; i < ListMax.Count ; i++){
            if(i == 0){
                MaximumPossible = ListMax[i];
            }else{
                if(MaximumPossible > ListMax[i]){
                     MaximumPossible = ListMax[i];
                }
            }
        }
        
        return MaximumPossible;
    }
    public static void Main(string[] args)
    {
         var l = new List<int>();
         l.Add(4);
         l.Add(5);
         l.Add(6);
         l.Add(7);
         l.Add(8);
         
        int n = MaxPossiblespace(1, l);
        Console.WriteLine(" answer is " + n);
    }
}
