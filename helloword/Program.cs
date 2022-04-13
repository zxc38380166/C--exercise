// See https://aka.ms/new-console-template for more information
//System.Console.WriteLine("my name is otis");
//string name = "my name is otis"; //字串 string
////char sex = "a";                //字元 "char"
//int age = 23;                    //整數 int 160
//double height = 172.3;           //浮點數 double 160.5
//bool is_male = true;

////資料型態練習
//System.Console.WriteLine (
//   "我的名子叫"+name+"\n我"+age+"歲\n"+ "身高"+height+"公分"
//);
//System.Console.WriteLine("my name is otis".Length); //字串數量
//System.Console.WriteLine(name.ToUpper()); //0轉換完大寫
//System.Console.WriteLine(name.Contains("is")); // 是否含有is字串
//System.Console.WriteLine(name[2]);//取得第二位
//System.Console.WriteLine(name.IndexOf('t')); //取得值為t的單位
//System.Console.WriteLine(name.Substring(2,5)); //從第二位開始取得,並取的第二位後的5個單位  
//System.Console.WriteLine((2+7)/3);// 數學公式()先計算  
//System.Console.WriteLine(System.Math.Abs(-10)); //絕對值
//System.Console.WriteLine(System.Math.Pow(2,4));//2的4次方
//System.Console.WriteLine(System.Math.Sqrt(64));//開根號
//System.Console.WriteLine(System.Math.Max(12,5));//回傳大值,min用法反之
//System.Console.WriteLine(System.Math.Round(3.5));//四捨五入

////取得用戶輸入
//System.Console.Write("輸入姓名 :　");//只用write則不換行
//string name1 = System.Console.ReadLine();
//System.Console.Write("輸入年紀 :　");
//string age1 = System.Console.ReadLine();    
//System.Console.WriteLine("你好啊"+age1+"歲的"+name1);

////陣列
//int[] scores = { 50, 20, 30, 40, 10 };
//System.Console.WriteLine(scores[0]);//取得第0位
//string[] phones = new string[10];//創建字串陣列,並限定每個空間只能放入10個字串
//phones[0] = "0986074168";
//System.Console.WriteLine("我的電話是"+phones[0]);

////判斷式(實做計算機)
//System.Console.WriteLine("請輸入第一個數字");
//double num1 = System.Convert.ToDouble( System.Console.ReadLine() );
//System.Console.WriteLine("請輸入運算符號");
//string oper = System.Console.ReadLine();
//System.Console.WriteLine("請輸入第二個數字");
//double num2 = System.Convert.ToDouble(System.Console.ReadLine());
//if (oper == "+")
//{
//    System.Console.WriteLine( num1 + num2);
//}
//else if (oper == "-")
//{
//    System.Console.WriteLine( num1 -num2);
//}
//else if (oper == "*")
//{
//    System.Console.WriteLine( num1 * num2);
//}
//else if (oper == "/")
//{
//    System.Console.WriteLine( num1 / num2);
//}
//else {
//    System.Console.WriteLine("請輸入正確的運算符號");
//}

////迴圈
//int num3 = 1;
//while (num3<=5) {
//    System.Console.Write(num3);
//    num3++;
//}
//int[] demo = { 10,20,30,40};
//for (int i = 0; i < demo.Length; i++) {
//    int[] demo1 ={10+i  };
//    System.Console.WriteLine(demo1[0]);
//};

Person person1 = new Person();  //創建物件並取得物件的值
person1.height = 172.5;
person1.age = 23;
person1.name = "otis";
System.Console.WriteLine(person1.name);