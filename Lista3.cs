using System;
using System.Linq;

public class Program
{
	// Kod można odpalic w edytorze online https://dotnetfiddle.net/
	public static void Main()
	{
		Console.WriteLine(EncodeBase64("WSB_DW"));
		Console.WriteLine(DecodeBase64("V1NCX0RX"));
		Console.WriteLine(GeneratePassword());
	}
	
	// Enkodowanie ciągu znaków metodą base64
	public static string EncodeBase64(string text)
	{
		var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
		return Convert.ToBase64String(textBytes);
	}
	
	// Dekodowanie ciągu znaków zakodowanego metodą base64 (Dodatek)
	public static string DecodeBase64(string base64)
	{
		try
		{
			var textBytes = Convert.FromBase64String(base64);
			return System.Text.Encoding.UTF8.GetString(textBytes);
		}
		catch (FormatException ex)
		{
			return "Podany ciąg znaków nie jest zakodowany metodą base64";
		}
	}
	
	// Generowanie hasła
	public static string GeneratePassword()
	{
		var chars = "@#$%^&*~[]=><AaBbCcDdEeFfGgHhIjJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789!@#$%^&*~[]=><";
		var random = new Random();
		
		return new string(Enumerable.Repeat(chars, 15)
        .Select(s => s[random.Next(s.Length)]).ToArray());
	}
}
