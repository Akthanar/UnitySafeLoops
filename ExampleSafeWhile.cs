using UnityEngine;
using static Safe; // this is not mandatory, you can use Safe.@while

public class ExampleSafeWhile : MonoBehaviour
{
    public int value1= 00;
    public int value2= 15;
    public int value3= 05;
 
    void MethodWithSafeWhile()
    {
        @while((() => (value1 < value2) && (value2 > value3)), () =>
        {
            Debug.Log("Max 1000 loops, then return with a LogWarning");
            value1++;
        });
    }
    
    void MethodWithSafeWhileAndCustomLimit()
    {
        int customLoopLimitAmount = 500;
    
    
        @while((() => (value1 < value2) && (value2 > value3)), () =>
        {
            Debug.Log("Max " + customLoopLimitAmount + " loops, then return with a LogWarning");
            value1++;
        },
        customLoopLimitAmount);
    }

    void OtherWayToUse()
    {
        Safe.@while(conditions, code);
        // or just: @while(conditions, code);
        
        // conditions to stay in the while
        bool conditions() => return (value1 < value2);
        
        // code to execute inside while
        void code()
        {
            Debug.Log("loop");
        }
    }
}
