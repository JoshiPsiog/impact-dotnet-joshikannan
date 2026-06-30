//#define TRIAL_VERSION 
// defining symbol named TRIAL_VERSION exist, not a varialble
//The compiler never sees both versions.

namespace Week01.Day02
{
    public static class PreprocessorDemo
    {
        public static void Run()
        {
#if TRIAL_VERSION // Does a symbol named TRIAL_VERSION exist
            Console.WriteLine("Running Trial Version ");
#else
            Console.WriteLine("Running Full Version");
#endif
        }
    }
}