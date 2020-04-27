### FractionsFunc
Library to handle basic arithmetic operations with fractions

### How to use it

        private void button5_Click(object sender, EventArgs e)
              {
                int num1 = 1, den1 = 600, num2 = 2, den2 = 1800, den3 = 1, num3 = 0;

                // Function to convert the fraction 
                // into it's simplest form 
                FractionsFunc.Fractions.lowest(ref num3, ref den3);
                
                //add two fractions
                FractionsFunc.Fractions.addFraction(num1, den1, num2, den2,ref num3, ref den3);
                
                //Function to subtract two fractions 
                FractionsFunc.Fractions.subtractFraction(num1, den1, num2, den2, ref num3, ref den3);
                
                //Function to multiply two fractions
                FractionsFunc.Fractions.multiplyFraction(num1, den1, num2, den2, ref num3, ref den3);
                
                //Function to divide two fractions  
                FractionsFunc.Fractions.divideFraction(num1, den1, num2, den2, ref num3, ref den3);
                
                //transform fraction into decimal with specific number of decimal digits
                decimal Result = FractionsFunc.Fractions.ConvertFraction(num3, den3,3);
                
                textBox6.Text = num1 + "/"+ den1 + " + "+num2 +"/"+ den2 + " is equal to "+ num3 + "/"+ den3;

              }
