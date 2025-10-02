const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = input.Substring(input.IndexOf("<span>")+6, input.IndexOf("</span>") - (input.IndexOf("<span>") + 6));
string output = input.Substring(input.IndexOf("<div>")+5, input.IndexOf("</div>") - (input.IndexOf("<div>") + 5));

// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);