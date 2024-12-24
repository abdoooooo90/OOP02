namespace Demo
{
    internal class Program
    {
        #region Overloading
        //public static int Sum(int X,int Y)
        //    { return X + Y; }
        //public static int Sum(int X, int Y, int Z)
        //{ return X + Y + Z; }
        //public static double Sum(double X, double Y, double Z) 
        //{ return X + Y + Z; }
        //public static double Sum(double X,int Y)
        //    { return X + Y; }
        //public static double Sum(int X, double Y)
        //{ return X + Y; }
        #endregion
        static void Main(string[] args)
        {
            #region Indexer
            //PhoneBook Note=new PhoneBook(3);
            //Note.AddPerson(0, "Ali", 123);
            //Note.AddPerson(1, "nada",456);
            //Note.AddPerson(2, "anas", 789);
            //// Note.SetNumber("Ali",444);//setter
            ////Console.WriteLine(Note.GetNumber("Ali"));
            ////indexer num[]=444;
            //Note["Ali"] = 111738089;  //using indexer as setter
            //Console.WriteLine(Note["Ali"]);//using indexer as getter
            ////indexer for string get no set /read only

            #endregion

            #region Class
            //Car C1;
            ////Decalre for reference from type "car" refr null
            ////can ref an obj  from type car or an obj from another class
            ////inheriting from car
            ////clr will allocate 4bytes for the ref at stack
            ////clr will allocate 0byte at heap
            ////---------------
            //C1 = new Car(10);
            //// new:
            //// 1- Allocate Required Bytes For The Object At Heap 16 Bytes
            //// 2- Initialize The Allocated Bytes Of The Object With The Default Values Of Its DataType
            //// 3- Call User Defined Constructor [IF Exists]
            //// 4- Assign The Address Of The Allocated Object At Heap To The Reference C1
            //Console.WriteLine(C1);
            #endregion

            #region inheritance
            //Chiled chiled=new Chiled(5,7,10);
            //Console.WriteLine(chiled);
            //هرجعله تاني ف ال over

            #endregion

            #region Relation Between Claas
            //1-imheritance : is [full time employee is an employee]
            //2-Aggregation:has
            //2.1:composition
            //2.2:Asssociation
            #endregion

            #region Access Modifiers
            //protected int x; //private            
            //private protected int y;//private      //inhearted
            //internal protected int z;//internal


            #endregion

            #region Polymorphism
            #region Overloading
            //int Result= Sum(1, 11);

            //Console.WriteLine(Result);

            #endregion

            #region Overriding
            //TypeA typeA= new TypeA(3);
            //typeA.A=1;
            //typeA.MyFun01();
            //typeA.MyFun02();
            //TypeB typeB=new TypeB(4,5);
            //typeB.A = 7;
            //typeB.B = 8;
            //typeB.MyFun01();
            //typeB.MyFun02();

            #endregion
            #endregion
        }
    }
}
