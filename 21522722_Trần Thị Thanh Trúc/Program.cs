/* bài 1
 Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
*/
using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        return (flower1 % 2 != flower2 % 2);
    }
}

/* bài 2
 Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/

using System;
class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        double avg = 0;
        double sum = 0;
        if (array.Length != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;
            return avg;
        }
        return 0;
    }
}

/* bài 3
 Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]
*/
using System;
public class Kata
{
    public static int[] Maps(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            x[i] *= 2;
        }
        return x;
    }
}

/* bài 4
 You were camping with your friends far away from home, but when it's time to go back, you realize that your fuel is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.

Considering these factors, write a function that tells you if it is possible to get to the pump or not.

Function should return true if it is possible and false if not.
*/
using System;

public static class Kata
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        uint result = mpg * fuelLeft;
        if (distanceToPump <= result)
        {
            return true;
        }
        return false;
    }
}

/* bài 5
 There was a test in your class and you passed it. Congratulations!
But you're an ambitious person. You want to know if you're better than the average student in your class.

You receive an array with your peers' test scores. Now calculate the average and compare your score!

Return True if you're better, else False!

Note:
Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!
*/
using System;
public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        double sum = 0;
        for (int i = 0; i < ClassPoints.Length; i++)
        {
            sum += ClassPoints[i];
        }
        sum += YourPoints;
        double avg = sum / (ClassPoints.Length + 1);
        if (YourPoints > avg)
            return true;
        else
            return false;
    }
}

/* bài 6
 A hero is on his way to the castle to complete his mission. However, he's been told that the castle is surrounded with a couple of powerful dragons! each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. Assuming he's gonna grab a specific given number of bullets and move forward to fight another specific given number of dragons, will he survive?

Return True if yes, False otherwise :)
*/
using System;
class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        if (bullets >= dragons * 2)
            return true;
        else
            return false;
    }
}

/* bài 7
 Your function takes two arguments:

current father's age (years)
current age of his son (years)
Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old). The answer is always greater or equal to 0, no matter if it was in the past or it is in the future.
*/
using System;
namespace Solution
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - sonYears * 2);
        }
    }
}

/* bài 8
 This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
 */
using System;
public class Multiplier
{
    public static int Multiply(int x)
    {
        if (x % 2 == 0)
            return x * 8;
        else
            return x * 9;
    }
}

/* bài 9
 It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry with strings with less than two characters.
*/
using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Substring(1, (s.Length - 2));
    }
}

/* bài 10
 Who remembers back to their time in the schoolyard, when girls would take a flower and tear its petals, saying each of the following phrases each time a petal was torn:

"I love you"
"a little"
"a lot"
"passionately"
"madly"
"not at all"
If there are more than 6 petals, you start over with "I love you" for 7 petals, "a little" for 8 petals and so on.

When the last petal was torn there were cries of excitement, dreams, surging thoughts and emotions.

Your goal in this kata is to determine which phrase the girls would say at the last petal for a flower of a given number of petals. The number of petals is always greater than 0.
*/
using System;

public class Kata
{
    public static string HowMuchILoveYou(int nb_petals)
    {
        switch (nb_petals % 6)
        {
            case 1: return "I love you";
            case 2: return "a little";
            case 3: return "a lot";
            case 4: return "passionately";
            case 5: return "madly";
            case 0: return "not at all";
            default: return "";
        }
    }
}