//  Armstrong Number
using System;
public class Program 
{
	static void Main( string[] args ) 
	{
		
		int num ;
		int result = 0 ;
		int digit ;
		int toadd ;
		Console.WriteLine("Enter the Number");
		num = int.Parse(Console.ReadLine());
		int ognum = num;
		int lengthofnum = num.ToString().Length;
		while(num > 0 ){
		digit = num % 10;
		toadd = (int)Math.Pow(digit,lengthofnum);
		result += toadd;
		num /= 10 ;
		};
		if( result == ognum ){
		Console.WriteLine("The Number "+ ognum + " is an Armstrong Number");
		}
		else{
		Console.WriteLine("The Number "+ ognum + " is not an Armstrong Number");
		}	
			
	}


}