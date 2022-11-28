int[] numbersArr = {0,1,2,3,4,5,6,7,8,9};
foreach (int i in numbersArr){
Console.WriteLine(i);
}

string[] namesArr = {"Tim", "Martin", "Nikki", "Sarah"};
foreach (string i in namesArr){
    Console.WriteLine(i);
}

int[] statements = new int[10];
for (int i = 0; i < statements.Length; i++){
    if(i % 2 == 0){
        Console.WriteLine (true);
    }
    else {
        Console.WriteLine (false);
    }
}

List<string> flavorList = new List<string>(5);
flavorList.Add("Vanilla");
flavorList.Add("Chocolate");
flavorList.Add("Rocky Road");
flavorList.Add("Mint");
flavorList.Add("Strawberry");
// flavorList.RemoveAt(2);
Console.WriteLine(flavorList[2]);
Console.WriteLine(flavorList.Count);
foreach (string i in flavorList){
    Console.WriteLine(i);
}

Dictionary<string,string> preference = new Dictionary<string, string>();
preference.Add("Tim", "Mint");

preference.Add("Martin", "Vanilla");

preference.Add("Nikki", "Chocolate");

preference.Add("Sarah", "Strawberry");

foreach (KeyValuePair<string,string> entry in preference){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}