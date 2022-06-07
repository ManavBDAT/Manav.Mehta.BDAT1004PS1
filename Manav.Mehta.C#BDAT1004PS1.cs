/*
Question 1 C# 
Task : What data type is each of the following?
*/

5 : Integer
5.0 : Float
5 > 1 : Boolean
'5' : Char
5 * 2 : Integer 
'5' * 2 : String
'5' + '2' : String
5 / 2 : Float 
5 % 2 : Integer 
{5, 2, 1} : Integer 
5 == 3 : Boolean
Pi (the number) : Float 


// Question 2 C#
// Task 1: How many letters are there in 'Supercalifragilisticexpialidocious'? 

String s = "Supercalifragilisticexpialidocious";
int count = 0;
foreach (char c in s)
{
  count++;
}

Console.WriteLine("Total Count in "+ s + " is : " +count);

// Question 2 C#
// Task 2: Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring?
string str = "Supercalifragilisticexpialidocious";
string findString = "ice";
Boolean result = str.Contains(findString);
Console.WriteLine("Does " + str + " contains " + findString + "? :" + result);

/* Question 2 C# 
 Task 3 : Which of the following words is the longest:  Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or 
 Bababadalgharaghtakamminarronnkonn? */
 
string str1 = "Supercalifragilisticexpialidocious";
string str2 = "Honorificabilitudinitatibus";
string str3 = "Bababadalgharaghtakamminarronnkonn";
 
int count1 = 0;
int count2 = 0;
int count3 = 0;

foreach (char c in str1)
{
  count1++;
}

foreach (char c in str2)
{
  count2++;
}

foreach (char c in str3)
{
  count3++;
}


Console.WriteLine("Total Count in "+ str1 + " is : " +count1);
Console.WriteLine("Total Count in "+ str2 + " is : " +count2);
Console.WriteLine("Total Count in "+ str3 + " is : " +count3);


if(count1 > count2){
    if(count1 > count3){
        Console.WriteLine(str1 + " is largest.");
    }
    else if(count1 == count3){
        Console.WriteLine(str1 + " and " + str3 + " is same lenght.");
    }
    else{
        Console.WriteLine(str3 + " is largest.");
    }
}
else{
        if(count2 > count3){
            Console.WriteLine(str2 + " is largest.");
        }
        else if(count2 == count3){
            Console.WriteLine(str2 + " and " + str3 + " is same lenght.");
        }
        else{
            Console.WriteLine(str3 + " is largest.");
        }
    }

 

/* Question 2 C#
 Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian', 
'Bartok', 'Bellini', 'Buxtehude', 'Bernstein'. Which one comes last? */

Dictionary<string, int> myDict = new Dictionary<string, int>();

myDict.Add("Berlioz",1);
myDict.Add("Borodin",2);
myDict.Add("Brian",3);
myDict.Add("Bartok",4);
myDict.Add("Bellini",5);
myDict.Add("Buxtehude",6);
myDict.Add("Bernstein",7);

List<KeyValuePair<string, int>> myList = myDict.ToList();

myDict.Sort(
    delegate(KeyValuePair<string, string> pair1,
    KeyValuePair<string, string> pair2)
    {
        return pair1.Value.CompareTo(pair2.Value);
    }
);



// Question 3 C#
// Task : Implement function triangleArea(a,b,c) that takes as input the lengths of the 3 sides of a triangle and returns the area of the triangle.
//By Heron's formula, the area of a triangle with side lengths a, b, and c is s(s − a)(s −b)(s −c), where s = (a + b + c)/2



public void triangleArea(double side1, double side2,double side3)
{
        double semiperimeter = (side1 + side2 + side3) / 2;
        Console.WriteLine(semiperimeter);
        
        double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        Console.Write("Area of a Triangle = " + Area);
}

triangleArea(2,2,2);

// Question 4 C#
// Task : Write a program in C# Sharp to separate odd and even integers in separate arrays. 


int[] arr1 = new int[10];
int[] arr2 = new int[10];
int[] arr3 = new int[10];
int i, j = 0, k = 0, n;


Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
Console.Write("------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input {0} elements in the array :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("element - {0} : ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < n; i++)
{
    if (arr1[i] % 2 == 0)
    {
        arr2[j] = arr1[i];
        j++;
    }
    else
    {
        arr3[k] = arr1[i];
        k++;
    }
}

Console.Write("\nThe Even elements are : \n");
for (i = 0; i < j; i++)
{
    Console.Write("{0} ", arr2[i]);
}

Console.Write("\nThe Odd elements are :\n");
for (i = 0; i < k; i++)
{
    Console.Write("{0} ", arr3[i]);
}
Console.Write("\n\n");


// Question 5 C#
/* Task A : Write a function inside(x,y,x1,y1,x2,y2) that returns True or False
depending on whether the point(x,y)lies in the rectangle with lower left
corner (x1,y1) and upper right corner (x2,y2). */

bool result;

public void inside(double x, double y, double x1,double y1, double x2, double y2)
{
    if (x > x1 && x < x2 && y > y1 && y < y2){
        result = true;
        Console.WriteLine(result);
    }
     
    else{
        result = false;
        Console.WriteLine(result);
    }
    
}

inside(1,1,0,0,2,3);
inside(-1,-1,0,0,2,3);

// Question 5 C#
/* Task B : Use function inside()from part a. to write an expression that tests whether
the point (1,1) lies in both of the following rectangles: one with lower left
corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other with lower
left corner (0.5, 0.2) and upper right corner (1.1, 2). */


static float area(double x1, double y1, double x2, double y2, double x3, double y3)
{
    return (float)Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
}

static bool check(double x, double y,double x1, double y1, double x2,
                      double y2, double x3, double y3, 
                   double x4, double y4)
    {
          
        float A = area(x1, y1, x2, y2, x3, y3) + 
                  area(x1, y1, x4, y4, x3, y3);
      
        float A1 = area(x, y, x1, y1, x2, y2);
      
        float A2 = area(x, y, x2, y2, x3, y3);
      
        float A3 = area(x, y, x3, y3, x4, y4);
      
        float A4 = area(x, y, x1, y1, x4, y4);
      
        return (A == A1 + A2 + A3 + A4);
    }



if (check(1,1,0.3,0.5,1.1,0.7,0.5,0.2,1.1,2))
{
    Console.Write("Given point lies in both triangles.");
}
            
else{
    Console.Write("Given point do not lies in both triangles.");
}


