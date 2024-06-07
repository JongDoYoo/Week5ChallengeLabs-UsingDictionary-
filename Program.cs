namespace Week5ChallengeLabs_UsingDictionary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listOfNum = {1, 10, 8, 1, 2, 4, 9, 3, 7, 8, 7, 8, 3, 7, 2, 2, 8, 3, 5, 6, 9, 6, 38, 3, 9, 4, 10, 2, 1, 6, 6};  //numberAndCount[(1,2)(2,2)(7,1)(4,2)]
                                                                                                          //e.g (1=key,2=count) updating count as same # appears
             
            Dictionary<int, int> numberAndCount = new Dictionary<int, int>(); //numberAndCount is my dictionary

            foreach (int currentNum in listOfNum)      //currentNum is same as i in for loop 
            {
                if (numberAndCount.ContainsKey(currentNum))//(ContainsKey checks if a key exists in the dictionary?)
                { 
                    numberAndCount[currentNum]++;
                }
                else
                { 
                    numberAndCount.Add(currentNum, 1); //1 is just a count 
                }

                
            }
            foreach (var kvp in numberAndCount)    //use var bc its has two numbers and we dont really have a adequate data type for it
            {
               
                if (kvp.Value == 1)              //.value spits out the value or in this case, the count
                {
                    Console.WriteLine(kvp.Key);     //.key spits out the key
                }
            }//you can even do this
             //if (kvp.key == 1)              
            {
               //Console.WriteLine(kvp.value);
               // or even Console.WriteLine(kvp);
            }
        }

    }
}
