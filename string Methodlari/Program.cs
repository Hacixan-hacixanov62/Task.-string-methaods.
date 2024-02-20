

//Homework task.

//string ResultOfNumber(string text)
//{
//    string word = "";
//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        if (text[i] == text[i])
//        {
//            word += text[i];
//        }
//    }
//    return word;
//}

//Console.WriteLine(ResultOfNumber("Wincestr"));






///// Dersin Praktikasi.


//int[] arr = { 1, 23, 4, 5 };
//arr[1] = 100;
//List<int> datas = new() { 1, 2, 3, 4 };
//datas.Add(100);
//string name = "Test";
//string newName = name + "salam";


// string name = "test";
//// name = "salam";

//using System.Text;

//StringBuilder str = new StringBuilder ("salam");
//str.Append("sagol");


//int age = 100;

//Console.WriteLine(age.GetType());


//int age = 100;

//Console.WriteLine(age.ToString() .GetType());


//string surname = "test";

////Console.WriteLine(surname.Length);


//string str1 = "salam";
//string str2 = " necesiz ?";

//string result = string.Concat(str1, str2);

//Console.WriteLine(result); 


//string result = "";

//string result2 = string.Empty;

//var result3 = result2 + "salam";


//string text = string.Empty;

//if (string.IsNullOrEmpty (text))
//{
//    Console.WriteLine("empty");

//}
//else
//{
//    Console.WriteLine("fill");

//}



//string text = "s";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");

//}
//else
//{
//    Console.WriteLine("fill");




//string text = "   ";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");

//}
//else
//{
//    Console.WriteLine("fill");

//}




//string text = "   ";

//if (string.IsNullOrWhiteSpace (text))
//{
//    Console.WriteLine("empty");

//}
//else
//{
//    Console.WriteLine("fill");

////}

//string text = "Azerbaijan";

//Console.WriteLine(text.ToUpper());


//string text = "Azerbaijan";

//Console.WriteLine(text.ToLower());


//Console.WriteLine("Apple" == "apple");

//string str1 = "Apple";
//string str2 = "apple";

//Console.WriteLine(str1==str2);


//string str1 = "Apple";
//string str2 = "apple";

//Console.WriteLine(str1.ToLower() == str2.ToLower());


//string str1 = "   Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());


//string str1 = "  Apple ";
//string str2 = "apple";

//Console.WriteLine(str1.Equals(str2));



//string str1 = "  Apple ";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower ().Equals(str2.Trim().ToLower()));


//string str1 = "  Apple ";
//string str2 = "apple";

//Console.WriteLine(CheckStr (str1).Equals (CheckStr(str2)));


//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}


//string str = "This is the \"Salam\" class.";

//Console.WriteLine( str);



//string str = "This is the \"Salam\" class.";

//Console.WriteLine(str);

//string message = $"Welcome to {str} " ;


//string text = "Azerbaycan";

//Console.WriteLine(string.Format(text));


//string authors = "Mhens - Chand, Henry - He, Chris - Love, Raj Beniwal,Praveen Kumar";
////Console.WriteLine(  authors);


//string[] authorsList= authors.Split(" - ");      

//foreach (var  item  in authorsList)
//{   
//    Console.WriteLine(item);
//}.


//string text = "Salam  Azerbaycan";

//Console.WriteLine(text.Replace("Salam", "sagol"));



//string text = "Salam  Azerbaycan";

//Console.WriteLine(text.Substring(2));

///}



//string text = "Salam  Azerbaycan jfddsafoewkadoickvdsockp";

//Console.WriteLine (text.Substring(0,5));


//string text = "Salam  Azerbaycan jfddsafoewkadoickvdsockp";

//string result = text.Substring(0, 5) + "...";

//Console.WriteLine(result);



//string text = "Salam  Azerbaycan";

//Console.WriteLine(text. Contains("Az"));


//bool CheckCharInStr (string text,string letter)
//{
//    return text.Trim().ToLower().Contains(letter.Trim().ToLower());
//}

//;

//Console.WriteLine(CheckCharInStr("Baku","B"));



//bool CheckCharInStr(string text, string letter)
//{
//    return text.Trim().ToLower().Contains(letter.Trim().ToLower());
//}


//Console.WriteLine("Add text: ");
//string text = Console.ReadLine();

//Console.WriteLine("Add search text ");
//string serachtex = Console.ReadLine(); 

//if (CheckCharInStr(text, serachtex))
//{
//    Console.WriteLine("Found");

//}
//else
//{
//    Console.WriteLine("Notfound");

//}
