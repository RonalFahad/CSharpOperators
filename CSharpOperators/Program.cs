using System;

namespace CSharpOperators
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            /*********** Assignment Operator (=) ***********/
            Console . WriteLine ( "********** Assignment Operator **********\n" );
            int intNumber         = 9;
            double doubleNumber   = 3.1416;
            decimal decimalDollar = 9.00m;
            bool boolValue        = true;
            string stringName     = "C#";
            Console . WriteLine ( $"int     = {intNumber}     \n" +
                                  $"double  = {doubleNumber}  \n" +
                                  $"decimal = {decimalDollar} \n" +
                                  $"bool    = {boolValue}     \n" +
                                  $"string  = {stringName}  \n\n" );



            /*********** Arithmetic Operators (+, -, *, /, %) ***********/
            Console . WriteLine ( "********** Arithmetic Operators **********\n" );

            /*>>>>> Unary Arithmetic Operators <<<<<*/
            // Positive Operator (+number)
            int positive = +intNumber;

            // Negative Operator (-number)
            int negative = -intNumber;

            /* Increment Operator (++); number = number + 1; */
            // intNumber is assigned to postfixIncrement, then it's incremented.
            // Here intNumber == 9 and it's immediately assigned to postfixIncrement,
            // so postfixIncrement prints 9, then intNumber is incremented and becomes
            // intNumber == 10 but the value is not printed
            int postfixIncrement = intNumber++;
            // intNumber is incremented, then assigned to prefixIncrement.
            // Here intNumber == 10 and it's instantly incremented and then assigned to
            // prefixIncrement, so intNumber == 11 and prefixIncrement also prints 11
            int prefixIncrement  = ++intNumber;

            /* Decrement Operator (--); number = number - 1; */
            // intNumber is assigned to postfixDecrement, then it's decremented.
            // Here intNumber == 11 and it's immediately assigned to postfixDecrement,
            // so postfixDecrement prints 11, then intNumber is decremented and becomes
            // intNumber == 10 but the value is not printed
            int postfixDecrement = intNumber--;
            // intNumber is decremented, then assigned to prefixDecrement.
            // Here intNumber == 10 and it's instantly decremented and then assigned to
            // prefixDecrement, so intNumber == 9 and prefixDecrement also prints 9
            int prefixDecrement  = --intNumber;


            /*>>>>> Binary Arithmetic Operators <<<<<*/
            // Addition Operator (+); After any Mathematical Operation between
            // int and double, if the result is stored to an int variable, it can't
            // convert double to int, that double needs manual typecasting
            int addition = intNumber * (int) doubleNumber;

            // Subtraction Operator (-); After any Mathematical Operation between
            // double and int, if the result is stored to a double variable, it can
            // automatically convert int to double, that int doesn't need typecasting
            double subtraction = doubleNumber - intNumber;

            // Multiplication Operator (*); After any Mathematical Operation between
            // decimal and double, if the result is stored to a decimal variable, it
            // can't convert double to decimal, that double needs manual typecasting
            decimal multiplication = decimalDollar * (decimal) doubleNumber;

            // Division Operator (/); After any Mathematical Operation between
            // double and decimal, if the result is stored to a double variable, it
            // can't convert decimal to double, that decimal needs manual typecasting
            double division = doubleNumber / (double) decimalDollar;

            // Remainder Operator (%); After any Mathematical Operation between
            // int and decimal, if the result is stored to an int variable, it can't
            // convert decimal to int, that decimal needs manual typecasting
            int remainder = intNumber % (int) decimalDollar;

            Console . WriteLine ( $">>>>> Unary Arithmetic Operators <<<<<  \n" +
                                  $"Positive          : {positive}          \n" +
                                  $"Negative          : {negative}          \n" +
                                  $"Postfix Increment : {postfixIncrement}  \n" +
                                  $"Prefix Increment  : {prefixIncrement}   \n" +
                                  $"Postfix Decrement : {postfixDecrement}  \n" +
                                  $"Prefix Decrement  : {prefixDecrement} \n\n" +

                                  $">>>>> Binary Arithmetic Operators <<<<< \n" +
                                  $"Addition(+)       : {addition}          \n" +
                                  $"Subtraction(-)    : {subtraction}       \n" +
                                  $"Multiplication(*) : {multiplication}    \n" +
                                  $"Division(/)       : {division}          \n" +
                                  $"Remainder(%)      : {remainder}         \n" +
                                  $"Increment         : {postfixIncrement}\n\n" );



            /*********** Equality Operators (==, !=) ***********/
            Console . WriteLine ( "********** Equality Operators **********\n" );

            // Equality Operator (==); int and decimal are different data type but
            // they hold the same value, so they are Mathematically equal
            if ( intNumber == decimalDollar )
            {
                Console . WriteLine ( $"Equal  : {intNumber} == {decimalDollar}" );
            }
            else
            {
                Console . WriteLine ( $"Inequal: {intNumber} != {decimalDollar}" );
            }

            // Inequality Operator (!=); int and double are inequal here not because
            // they are of different data types but they hold different values
            if ( intNumber != doubleNumber )
            {
                Console . WriteLine ( $"Inequal: {intNumber} != {doubleNumber}\n\n" );
            }
            else
            {
                Console . WriteLine ( $"Equal  : {intNumber} == {doubleNumber}\n\n" );
            }



            /*********** Comparison Operators (>, <, >=, <=) ***********/
            Console . WriteLine ( "********** Comparison Operators **********\n" );

            // More than operator (>); checks if the value of left is greater than
            // the value of right or not
            if ( intNumber == decimalDollar )
            {
                Console . WriteLine ( $"{intNumber}  > {decimalDollar}: True" );
            }
            else
            {
                Console . WriteLine ( $"{intNumber}  > {decimalDollar}: False" );
            }

            // Less than operator (<); checks if the value of left is smaller than
            // the value of right or not
            if ( intNumber < decimalDollar )
            {
                Console . WriteLine ( $"{intNumber}  < {decimalDollar}: True" );
            }
            else
            {
                Console . WriteLine ( $"{intNumber}  < {decimalDollar}: False" );
            }

            // More than or equal operator (>=); checks if the value of left is greater
            // than the value of right or equal to it or none of these
            if ( intNumber >= decimalDollar )
            {
                Console . WriteLine ( $"{intNumber} >= {decimalDollar}: True" );
            }
            else
            {
                Console . WriteLine ( $"{intNumber} >= {decimalDollar}: False" );
            }

            // Less than or equal operator (<=); checks if the value of left is smaller
            // than the value of right or equal to it or none of these
            if ( intNumber <= decimalDollar )
            {
                Console . WriteLine ( $"{intNumber} <= {decimalDollar}: True" );
            }
            else
            {
                Console . WriteLine ( $"{intNumber} <= {decimalDollar}: False" );
            }
        }
    }
}