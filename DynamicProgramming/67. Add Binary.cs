using System.Text;

namespace DynamicProgramming;
public class AddBinarySolution
{
    public string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();
        var i = a.Length - 1;
        var j = b.Length - 1;
        var carry = 0;

        while (i >= 0 || j >= 0) {
            var sum = carry;
            if (i >= 0) {
                sum += a[i--] - '0';
            }
            if (j >= 0) {
                sum += b[j--] - '0';
            }

            sb.Insert(0, sum % 2);

            carry = sum / 2;
        }

        if (carry > 0) {
            sb.Insert(0, 1);
        }

        return sb.ToString();
    }
}
