// Prime Number
using System;
public class Program 
{

	static void Main( string[] args ) 
	{
		int num ;
		Console.WriteLine("Enter the Number");
		num = int.Parse(Console.ReadLine());
		int loopend = Math.Sqrt(num) ;
		bool isprime = true;

		if( num < 2 ){
		isprime =  false;
		}
		else{
		for( int i = 2; i <= loopend ;i++ )
		{
			if ( num % i == 0 )
			{	
				isprime = false ; 
				break ;
			}	 	
		}
		}
		
		if( isprime )
		{
		Console.WriteLine("The Number "+ num + "is Prime");
		}
		else
		{
		Console.WriteLine("The Number "+ num + "is Not Prime");
		}
			
			
	}
}