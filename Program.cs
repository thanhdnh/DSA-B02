public class Program
{
    static Array createFibArray(int n){
        Array ar =  Array.CreateInstance(
                        typeof(int),
                        new int[1]{n},
                        new int[1]{1}
                    );
        ar.SetValue(1, 1);
        ar.SetValue(1, 2);
        for(int i=3; i<=ar.GetUpperBound(0); i++)
            ar.SetValue(
                (int)ar.GetValue(i-2)+(int)ar.GetValue(i-1),
                 i
            );
        return ar;
    }
    static Array create2DFibArray(int n, int m){
        Array ar = Array.CreateInstance(
                        typeof(int),
                        new int[2]{n, m},
                        new int[2]{1, 1}
                    );
        ar.SetValue(1, 1, 1); ar.SetValue(1, 1, 2);
        for(int i=ar.GetLowerBound(0);i<=ar.GetUpperBound(0);i++)
            for(int j=ar.GetLowerBound(1);j<=ar.GetUpperBound(1);j++){
                int x = 0; //công thức 1
                //2 phần tử liền trước x là x-1 và x-2
                //cặp chỉ số tương ứng với x-1
                int ii = 0, jj = 0;//công thức 2 và 3
                //cặp chỉ số tương ứng với x-2
                int iii = 0, jjj = 0;//công thức 2 và 3

                ar.SetValue(ar.GetValue(ii, jj)+ar.GetValue(iii, jjj), 
                            i, j);
            }
        return ar;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        Array fibs = createFibArray(10);
        foreach(int v in fibs)
            Console.Write(v+", ");

        /*Array ar1 = Array.CreateInstance(
                            typeof(int), 
                            new int[1]{5}, 
                            new int[1]{2}
                        );*/
        /*for(int i=ar1.GetLowerBound(0);
                i<=ar1.GetUpperBound(0);i++)*/
        /*for(int i=ar1.GetLowerBound(0); 
                i<ar1.GetLength(0)+ar1.GetLowerBound(0); i++)
            ar1.SetValue(i*i, i); //giá trị, chỉ số
        for(int i=ar1.GetLowerBound(0); 
                i<ar1.GetLength(0)+ar1.GetLowerBound(0); i++)
            Console.WriteLine($"ar1[{i}]={ar1.GetValue(i)}");
        */
        /*Array ar2 = Array.CreateInstance(
                                typeof(int),
                                new int[2]{3, 2},
                                new int[2]{1, 1}
                            );
        Random r = new Random();
        for(int i=ar2.GetLowerBound(0); i<=ar2.GetUpperBound(0);i++)
            for(int j=ar2.GetLowerBound(1); j<=ar2.GetUpperBound(1);j++)
                ar2.SetValue(r.Next(1, 9), i, j);
        for(int i=ar2.GetLowerBound(0); i<=ar2.GetUpperBound(0);i++){
            for(int j=ar2.GetLowerBound(1); j<=ar2.GetUpperBound(1);j++)
                System.Console.Write(ar2.GetValue(i, j)+"\t");
            Console.WriteLine("");
        }*/

        Console.ReadLine();
    }
}