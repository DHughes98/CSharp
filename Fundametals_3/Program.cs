static void PrintList(List<string> MyList){
    foreach (string i in MyList){
        Console.WriteLine(i);
    }
}


static void SumOfNumbers(List<int> IntList){
    int tot = 0;
    for (int i = 0; i < IntList.Count; i++){
        tot += IntList[i];
        Console.WriteLine(tot);
      }
}


static int FindMax(List<int> IntList){
    var maxValue = 0;
    for (int i = 0; i < IntList.Count; i++){
        if (i > maxValue){
            maxValue = i;
        }
        Console.WriteLine(i);
}
}

static List<int> SquareValues(List<int> IntList){
    
}


static void PrintDictionary(Dictionary<string,string> MyDictionary){
    foreach (KeyValuePair<string,string> entry in MyDictionary){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
}



// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers){

}




