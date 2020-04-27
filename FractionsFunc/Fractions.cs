using System;

namespace FractionsFunc
{
    public class Fractions
    {
        // Function to return gcd of a and b 
         public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        // Function to convert the obtained fraction 
        // into it's simplest form 
        public static void lowest( ref int den3, ref int num3)
        {
            // Finding gcd of both terms 
            int common_factor = gcd(num3, den3);

            // Converting both terms into simpler  
            // terms by dividing them by common factor  
            den3 = den3 / common_factor;
            num3 = num3 / common_factor;
        }

        //Function to add two fractions 
        public static void addFraction(int num1, int den1, int num2,
                         int den2,ref int num3,ref int den3)
        {
            // Finding gcd of den1 and den2 
            den3 = gcd(den1, den2);

            // Denominator of final fraction obtained 
            // finding LCM of den1 and den2 
            // LCM * GCD = a * b  
            den3 = (den1 * den2) / den3;

            // Changing the fractions to have same denominator 
            // Numerator of the final fraction obtained 
            num3 = (num1) * (den3 / den1) + (num2) * (den3 / den2);

            // Calling function to convert final fraction 
            // into it's simplest form 
            lowest(ref den3,ref num3);
        }

        //Function to subtract two fractions 
        public static void subtractFraction(int num1, int den1, int num2,
                         int den2,ref int num3,ref int den3)
        {
            // Finding gcd of den1 and den2 
            den3 = gcd(den1, den2);

            // Denominator of final fraction obtained 
            // finding LCM of den1 and den2 
            // LCM * GCD = a * b  
            den3 = (den1 * den2) / den3;

            // Changing the fractions to have same denominator 
            // Numerator of the final fraction obtained 
            num3 = (num1) * (den3 / den1) - (num2) * (den3 / den2);

            // Calling function to convert final fraction 
            // into it's simplest form 
            lowest(ref den3,ref num3);
        }

        //Function to multiply two fractions
        public static void multiplyFraction(int num1, int den1, int num2,
                         int den2,ref int num3,ref int den3)
        {
            // multiply the denominators
            den3 = den1 * den2;

            // multiply the numeretors
            num3 = num1 * num2;

            // Calling function to convert final fraction 
            // into it's simplest form 
            lowest(ref  den3, ref num3);
        }

        //Function to divide two fractions  
        public static void divideFraction(int num1, int den1, int num2,
                         int den2,ref int num3,ref int den3)
        {

            // invert the second function
            num3 = num2;
            num2 = den2;
            den2 = num3;

            // multiply the denominators
            den3 = den1 * den2;

            // multiply the numeretors
            num3 = num1 * num2;

            // Calling function to convert final fraction 
            // into it's simplest form 
            lowest(ref  den3,ref num3);
        }

        //transform fraction into decimal with specific number of decimal digits
        public static decimal ConvertFraction(int num1, int den1, int Decimals)
        {

            decimal result = decimal.Round(Convert.ToDecimal(num1) / Convert.ToDecimal(den1), Decimals);


            return result;
        }
    }
}
