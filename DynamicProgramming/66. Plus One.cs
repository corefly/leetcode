namespace DynamicProgramming;

public class PlusOneSolution
{
	public int[] PlusOne(int[] digits)
	{
		var i = digits.Length - 1;

		while (i >= 0 && digits[i] == 9)
		{
			digits[i] = 0;
			i--;
		}

		if (i >= 0)
		{
			digits[i] += 1;

			return digits;
		}

		var newdigits = new int[digits.Length + 1];

        newdigits[0] = 1;

		return newdigits;
	}
}

