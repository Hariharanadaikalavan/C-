namespace ConstructorEx
{
    internal  class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of elemets to be added");
            int upto=int.Parse(Console.ReadLine());
            int[]age=new int[upto];//10
            
            for(int i = 0; i<age.Length; i++)
            {
                age[i]= int.Parse(Console.ReadLine());  //[1,0,6,0,9,0,5,6,0,9]
            }
            Console.WriteLine("Original length of array--->"+age.Length); 
            int counter = 0;
            for(int  i=0; i<age.Length; i++)
            {
                if (age[i] != 0) //eliminating zeros
                {
                    Console.WriteLine(age[i]);
                    counter++;
                }
            }
            Console.WriteLine("The Length of array--->"+counter);

        }
    }
}
