using System;

namespace Ex2
{
    class Car
    {
        private string model;
        private int anyoFabricacion;

        public string Model { get => model; set => model = value; }
        public int AnyoFabricacion { get => anyoFabricacion; set => anyoFabricacion = value; }

        public Car()
        {
        }

        public Car(string model, int anyoFabricacion)
        {
            this.model = model;
            this.anyoFabricacion = anyoFabricacion;
        }

        public override string ToString()
        {
            return "Model: " + this.Model + ", Year of production: " + this.AnyoFabricacion;
        }
    }
    class Program
    {
        static int findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int findMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static void Main(string[] args)
        {

            #region ex1
            //int x1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //for (int i = x1; i <= x2; i++)
            //{
            //    Console.Write(i * i - 2 * i + 1 + " ");
            //}
            #endregion

            #region ex2
            //int x = 1;
            //while (x<=500)
            //{
            //    if(x % 3==0 && x % 5 == 0)
            //    {
            //        Console.Write(x + " ");
            //    }
            //    x++;
            //}
            #endregion

            #region ex3
            //int x = 0;
            //while (x<3)
            //{
            //    Console.Write("Enter username: ");
            //    string user = Console.ReadLine();
            //    Console.Write("Enter password: ");
            //    string pass = Console.ReadLine();
            //    if (user.Equals("12") && pass.Equals("1234"))
            //    {
            //        Console.WriteLine("Login successfull!");
            //        break;
            //    } else
            //    {
            //        Console.WriteLine("Login failed");
            //    }
            //    x++;
            //}
            #endregion

            #region ex4
            //while(true)
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    if(num1 == 0)
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("You cannot divide by 0");
            //        continue;
            //    } else
            //    {
            //        Console.WriteLine("The division is " + num1/num2);
            //        Console.WriteLine("The rest is " + num1%num2);
            //    }
            //}
            #endregion

            #region ex5
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //for(int i = num1; i <= num2; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //int k = num1;
            //while (k != num2+1)
            //{
            //    Console.Write(k + " ");
            //    k++;
            //}
            //Console.WriteLine();

            //int l = num1;
            //do
            //{
            //    Console.Write(l + " ");
            //    l++;
            //} while (l != num2+1);
            #endregion

            #region ex6
            //int[] arr = new int[5];
            //for(int i = 0;i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine("Suma: " + sum);
            //Console.WriteLine("Media: " + sum/5);

            //Console.WriteLine("Max: " + findMax(arr));
            //Console.WriteLine("Min: " + findMin(arr));

            #endregion

            #region ex7
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} is " + (num1 % 2 == 0 ? " positive" : " negative"), num1);
            //Console.WriteLine("{0} is " + (num2 % 2 == 0 ? " positive" : " negative"), num2);
            //Console.WriteLine("Both is " + (num2 % 2 == 0 && num1 % 2 == 0 ? " positive" : " negative"));
            #endregion

            #region ex8
            //Console.Write("Enter quantity of values from the array of intergers: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] arr = new int[length];
            //for(int i = 0; i < length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //string num = "";
            //bool isFound = false;
            //do
            //{
            //    isFound = false;
            //    num = Console.ReadLine();
            //    if (num.Equals("end"))
            //    {
            //        break;
            //    }
            //    for(int i = 0; i < length; i++)
            //    {
            //        if (num.Equals(arr[i] +""))
            //        {
            //            Console.WriteLine("The number {0} exist", num);
            //            isFound = true;
            //            break;
            //        }
            //    }
            //    if (!isFound)
            //    {
            //        Console.WriteLine("Not existed");
            //    }
            //} while (true);
            #endregion

            #region ex9
            //float[] arr = new float[10];
            //for(int i = 0; i < 10; i++)
            //{
            //    arr[i] = float.Parse(Console.ReadLine());
            //}

            //float posiSum = 0, countPosi = 0;
            //float negaSum = 0, countNega = 0; 

            //for (int i = 0; i < 10; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        posiSum += arr[i];
            //        countPosi++;
            //    }
            //    if (arr[i] < 0)
            //    {
            //        negaSum += arr[i];
            //        countNega++;
            //    }
            //}

            //Console.WriteLine("Average numbers negatives is " + negaSum / countNega);
            //Console.WriteLine("Average numbers positives is " + posiSum / countPosi);
            #endregion

            #region ex10
            //int[,] arr = new int[2, 5];
            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[0, i] = int.Parse(Console.ReadLine());
            //    sum1 += arr[0, i];
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    arr[1, j] = int.Parse(Console.ReadLine());
            //    sum2 += arr[0, j];
            //}
            //Console.WriteLine("Average for group 1 is " + sum1 / 5);
            //Console.WriteLine("Average for group 2 is " + sum2 / 5);
            #endregion

            #region ex11
            Car[] arr = new Car[3];
            for (int i = 0; i < 3; i++)
            {
                string Model = Console.ReadLine();
                int AnyoFabricacion = int.Parse(Console.ReadLine());

                arr[i] = new Car(Model, AnyoFabricacion);
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(arr[j].ToString());
            }
            #endregion

            #region ex12
            
            #endregion

            #region ex13

        #endregion
    
            #region ex14

        #endregion

            #region ex15

        #endregion
        }
    }
}
