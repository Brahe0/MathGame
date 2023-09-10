int index = 1;

int deux = 2;
string name = "André";
char initial = 'a';
decimal high = 1.78m;
bool isOn = true;

string myParagraph = $@"These are the most common data types:
{index++}- int = {name}
{index++}- char = {initial}
{index++}- int = {deux}
{index++}- decimal = {high}
{index++}- bool = {isOn}";

Console.WriteLine(myParagraph);

Console.ReadLine();