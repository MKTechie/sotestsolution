using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using SO_TEST_1_2; 

[assembly: CLSCompliant(true)]
    internal sealed class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            int[] arr1 = { 1, 3, 4, 6, 8 };
            int[] arr2 = { 2, 5, 7, 9, 10 };
            int[] arr3 = {};
            int[] arr4 = {-5,-2,-4,-3,-1,0 };
            Game game = new Game();
            ArraySorting arraySorting = new ArraySorting();

            Console.WriteLine(game.MacroPolo(20));

            var sortedArray = arraySorting.SortAndMergeArray(arr1, arr4);
            for(int i=0;i<sortedArray.Length;i++)
            Console.Write( sortedArray[i] );

            Console.ReadKey();


        }
        public UInt32 Abc() { return 0; }
        // Warning: Identifier 'SomeLibrary.SomeLibraryType.abc()'
        // differing only in case is not CLS-compliant
        public void abc() { }
        // No warning: this method is private
        private UInt32 ABC() { return 0; }
    }
   /*
    class AsyncDelegateExample2
    {
        delegate string TestDelegate();

        public object test()
        {
            try
            {
             
                 TestDelegate TDTesting = new TestDelegate(GetServerAddress);
           // SampleDelegate parser = new SampleDelegate(Parse);

            AsyncCallback callback = new AsyncCallback(getTestResult);

              TDTesting.BeginInvoke(null, callback,null);

                 var some_address = GetServerAddress();
                
                return await RunWithExceptionLogging(() => { var data = await LoadFromServer(some_address); return await EnreachData(data); }, ex => { // generate & return context return new Dictionary<string, object>(){{'address', some_address}}; 
                });
            
            }
            catch (Exception ex)
            {
                LogExcecption(ex);
            }
        }

static void getTestResult(IAsyncResult result)
        {
            
            AsyncResult delegateResult = (AsyncResult)result;
             //Perform our logic here for getting address
             TestDelegate delegateInstance = (TestDelegate)delegateResult.AsyncDelegate;

             string someAddress = delegateInstance.EndInvoke(result);
            
        }
         public string GetServerAddress()
         {
             return "Server address is";
         }
            /// <summary>
        /// Method used for mannual logging of error for project demo
        /// </summary>
        /// <param name="exec"></param>
        public static void LogExcecption(Exception exec)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Exception Type: ");
            sb.Append(exec.GetType().ToString());
            sb.Append("Message: " + exec.Message);
            sb.Append("Calling stack trace: " + exec.Source);
            sb.Append("Stack Trace: ");
            sb.Append(exec.StackTrace);
            sb.Append("Context: " + exec.TargetSite);
           // we can use sb for permanent logging.    
             
        }
        }
        
    public class abc
    {
        delegate int SampleDelegate(string data);
        static void Main()
        {

            SampleDelegate counter = new SampleDelegate(CountCharacters);
           // SampleDelegate parser = new SampleDelegate(Parse);

            AsyncCallback callback = new AsyncCallback(DisplayResult);

              object address;
           SampleDelegate.BeginInvoke("hello", callback,address);
            
            Console.WriteLine("Main thread continuing");

            Thread.Sleep(3000);
            Console.WriteLine("Done");
        }

        static void DisplayResult(IAsyncResult result)
        {
            string format = (string)result.AsyncState;
            AsyncResult delegateResult = (AsyncResult)result;
            SampleDelegate delegateInstance = (SampleDelegate)delegateResult.AsyncDelegate;

           // return delegateInstance.EndInvoke(result);
        }

        static int CountCharacters(string text)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Counting characters in {0}", text);
            return text.Length;
        }

        static int Parse(string text)
        {
            Thread.Sleep(100);
            Console.WriteLine("Parsing text {0}", text);
            return int.Parse(text);
        }
    }
    */
    /*
    interface ICalculator
    {
        int Add(int a, int b);
    }

    interface IAuthorization
    {
        string WhoAmI(string Username);
    }
    class Calculator : ICalculator
    {
        public Calculator(IAuthorization objAuthorization, string Username)
        {
            try
            {
                if (Username.Equals(objAuthorization.WhoAmI("MD")))
                {
                    Console.Write("I am in calculator by MK");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
            }
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class a
    {
        public void abc()
        {
        }
    }
    class b : a
    {
        public void bcd()
        {
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
          //  a ab = new b();
           // b ba = new a();
   
            //long Asize = System.GC.GetTotalMemory(true);
            //IAuthorization objAuthorization = new Authorization();
            //System.GC.KeepAlive(objAuthorization);
            //long Bsize = System.GC.GetTotalMemory(true);
            //Calculator calc = new Calculator(objAuthorization, "MD");
            //System.GC.KeepAlive(objAuthorization);
            //Asize = System.GC.GetTotalMemory(true);
            //Console.Write("differenct size" + (-Bsize + Asize));

           // Console.Write("differenct size" + (Bsize- Asize));
          //  int result = calc.Add(2, 2);

           // Console.Write(result);
            Console.ReadLine();
        }
    }

    class Authorization : IAuthorization
    {
        private Authorization(int a) { }
        public Authorization() { }
        public string WhoAmI(string Username)
        {
            return Username;
        }
    }*/

