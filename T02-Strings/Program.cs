using System.Globalization;
using System.Text;
using System.Xml.Linq;
string name = "Petr";
string s1 = "Ahoj";
string s2 = $"Ahoj {name}!";           // Interpolace
string s3 = @"Více\rádkový
text";  
/*// Verbatim
string s4 = """Raw string s
"uvozovkami" a
více řádky""";                        // Raw string
*/
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

string s4 = "První \n Druhý řádek";
Console.WriteLine(s4);

string s = "Hello";
char first = s[0];     // 'H'
Console.WriteLine(s[1]);  // 'e'

// Imutabilita - neměnnost
//s[0] = 'h';  // Chyba: string je neměnný

int len = s.Length;                    // 5
bool empty = string.IsNullOrEmpty(s);  // false
bool white = string.IsNullOrWhiteSpace("   ");  // true

// ❌ NEefektivní (vytváří nové stringy)
string result = "A" + "B" + "C";

// ✅ Efektivní (StringBuilder)
StringBuilder sb = new();
sb.Append("A").Append("B").Append("C");
string res = sb.ToString();
Console.WriteLine(res);

// Moderní způsoby
string[] arr = new[] { "A", "B", "C" };
string joined = string.Concat(arr);
Console.WriteLine(joined);
string formatted = string.Format("Hodnota {0}", 42);
Console.WriteLine(formatted);

string s5 = "The mountains are behind the clouds today.";
string peaks = s5.Replace("mountains", "peaks");     // "The peaks are..."
string noSpace = s5.Replace(' ', '_');               // "The_mountains_are..."
string trimmed = s5.Remove(0, 4);                    // "mountains are..."

string source = "   text   ";
string trimmed2 = source.Trim();        // "text"
string trimStart = source.TrimStart(); // "text   "
string trimEnd = source.TrimEnd();     // "   text"
Console.WriteLine($"'{trimmed2}'");
Console.WriteLine($"'{trimStart}'");
Console.WriteLine($"'{trimEnd}'");
Console.WriteLine($"'{source}'");

string txt = "Šílená čivava";
Console.WriteLine(txt.ToUpper());      // "ŠÍLENÁ ČIVAVA"
Console.WriteLine(txt.ToLower());      // "šílená čivava"
char[] chars = txt.ToCharArray();      // ['Š','í','l',...]
string fromChars = new string(chars);  // "Šílená čivava"

var txt2 = RemoveDiacritics(txt);
Console.WriteLine(txt2);  // "Silena civava"
static string RemoveDiacritics(string text)
{
    string normalized = text.Normalize(NormalizationForm.FormD);
    StringBuilder sb = new();
    foreach (char c in normalized)
    {
        if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            sb.Append(c);
    }
    return sb.ToString().Normalize(NormalizationForm.FormC);
}
// "Šílená čivava" → "Silena civava"

DateTime date = new DateTime(2023, 2, 28, 10, 30, 0);
string city = "Liberec";
int temp = -5;

string output = String.Format("At {0} in {1}, temp {2}°C", date, city, temp);
// "At 28. 2. 2023 10:30:00 in Liberec, temp -5°C"
Console.WriteLine(output);

decimal price = 1234.567m;
Console.WriteLine(price.ToString("C2"));           // 1 234,57 Kč
Console.WriteLine(price.ToString("F2"));           // 1234.57
Console.WriteLine(price.ToString("P1"));           // 123 456,7 %

// Česky
Console.WriteLine(price.ToString("C2",
    CultureInfo.CreateSpecificCulture("cs-CZ")));  // 1 234,56 Kč

// Americky  
Console.WriteLine(price.ToString("C2",
    CultureInfo.CreateSpecificCulture("en-US")));  // $1,234.56

// Dánsky
Console.WriteLine(price.ToString("C2",
    CultureInfo.CreateSpecificCulture("da-DK")));  // 1.234,56 kr

