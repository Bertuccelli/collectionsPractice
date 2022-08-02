// THREE BASIC ARRAYS
int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
bool[] boolArray = new bool[10] {true, false, true, false, true, false, true, false, true, false};

for (int idx = 0; idx < boolArray.Length; idx++){
    Console.WriteLine($"{boolArray[idx]}");
}

// LIST OF FLAVORS
List<string> flavors = new List<string>() {
    "Chocolate Fudge Brownie",
    "Mint Chocolate Chip",
    "Matcha",
    "Coffee",
    "Peanut Butter"
};

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);

// USER INFO DICTIONARY
Random randy = new Random();

Dictionary<string, string> userInfo = new Dictionary<string, string>() {
    {"Name", "Favourite Flavour"}
};

for (int idx = 0; idx < nameArray.Length; idx++) {
    userInfo.Add(nameArray[idx],
    flavors[randy.Next(flavors.Count)]);
}

foreach (KeyValuePair<string,string> entry in userInfo) {
    Console.WriteLine($" {entry.Key} -  {entry.Value}");
}