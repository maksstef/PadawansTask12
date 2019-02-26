using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();
       
            for(int i = 0; i < source.Length; ++i)
            {
                for(int j = i+1; j < source.Length; ++j)
                {
                    if(source[i] == source[j])
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}