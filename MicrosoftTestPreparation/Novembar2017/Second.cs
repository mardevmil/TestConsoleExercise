using System;

namespace MicrosoftTestPreparation.Novembar2017
{
    //Data su dva stringa u rasponu od A-Z, treba proveriti da li su anagrami.
    //Dva stringa su anagrami ukoliko su sastavljeni od istih karaktera, ali u drugacijem redosledu. 
    //Pri tome, u prvom stringu moze da se nadje specijalan karakter predstavljen znakom @. Specijaln karakter menja bilo koji drugi karakter.
    //Deklaracija: bool areAnagram(const char* s1, const char* s2)
    //Primeri:
    //input: s1=ABAB, s2=BABA, output: true
    //input: s1=A@A@, s2=BAAC, output: true
    //input: s1=ACA, s2=ACAB output: false

    class Novembar2017_Second
    {
        public bool AreAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            char c = s1[0];
            char[] string1 = new char[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                string1[i] = s1[i];                
            }

            bool found = false;
            int foundIndex = -1;
            for (int i = 0; i < s2.Length; i++)
            {
                found = false;
                foundIndex = -1;
                for (int j = 0; j < string1.Length; j++)
                {
                    if (s2[i] == string1[j] || string1[j] == '@')
                    {
                        //Console.WriteLine("found " + s2[i] + " on index " + j + " s1 char: " + string1[j]);
                        found = true;
                        foundIndex = j;
                        break;
                    }
                }

                if (!found)
                {
                    //Console.WriteLine("return false " + s2[i]);
                    return false;
                }                    
                else
                {
                    for (int j = 0; j < string1.Length - 1; j++)
                    {
                        if(j >= foundIndex)
                            string1[j] = string1[j + 1];
                    }

                    Array.Resize(ref string1, string1.Length - 1);
                    
                }
            }

            return true;
        }
    }
}
