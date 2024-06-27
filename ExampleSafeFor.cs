using UnityEngine;
using static Safe;

public class ExampleSafeFor : MonoBehaviour
{
    void Method_1()
    {
        int exit_at = ITERATION_LIMIT_BEFORE_EXIT;
    
    
        for (int i = 0; Check(() => i < 10, ref exit_at); i++)
        {
            // code here...
            // exit with a warning if the limit is reached
        }
    
    
        for (int i = 0; Check(() => i < 10, ref exit_at, true); i++)
        {
            // code here...
            // exit with an error if the limit is reached
        }
    }
    
    
    
    void Method_2()
    {
        // Check parameters:
        
        // [true/false] for exit with error/warning.
        // If empty, default value is false.
    
        // [int] for custom iterations limit before exit.
        // If empty, default value is 1000.
    
        // These parameters can be used in any combinations:
        //
        // Check ( [true/false], limit )
        // Check ( limit, [true/false] )
        // Check ( [true/false] )
        // Check ( limit )
        // Check ()
    
    
        var check_with_error = Check(true); // equal to: Check (true, 1000)
    
        for (int i = 0; check_with_error(() => true); i++)
        { /* code here */ }
    
    
        var check_with_warning = Check(); // equal to Check (false, 1000)
        
        for (int i = 0; check_with_warning(() => i < 10); i++)
        { /* code here */ }
    
    
        var check_with_custom_limit = Check(5); // equal to Check (false, 5)
    
        for (int i = 0; check_with_custom_limit(() => i < 10); i++)
        { /* code here */ }
    }
}
