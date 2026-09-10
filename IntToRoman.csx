public string IntToRoman(int num)
{
    string s = num.ToString();
    int len = s.Length;
    int temp = num;
    var roman = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
        switch (len)
        {
            case 4:
                len--;
                int fac = temp / 1000;
                Console.WriteLine(fac);
                for (int j = 0; j < fac; j++) roman.Append('M');
                break;

            case 3:
                len--;
                int fac1 = (temp / 100) % 10;

                if (fac1 < 4)
                {
                    for (int j = 0; j < fac1; j++) roman.Append('C');
                }
                else if (fac1 == 4) { roman.Append("CD"); break; }
                else if (fac1 < 9)
                {
                    roman.Append('D');
                    for (int j = 0; j < fac1 - 5; j++) roman.Append('C');
                }
                else if (fac1 == 9) { roman.Append("CM"); break; }

                break;

            case 2:
                len--;
                int fac2 = (temp / 10) % 10;
                if (fac2 < 4)
                {
                    for (int j = 0; j < fac2; j++) roman.Append('X');
                }
                else if (fac2 == 4) { roman.Append("XL"); break; }
                else if (fac2 < 9)
                {
                    roman.Append('L');
                    for (int j = 0; j < fac2 - 5; j++) roman.Append('X');
                }
                else if (fac2 == 9) { roman.Append("XC"); break; }

                break;

            case 1:
                len--;
                int fac3 = temp % 10;

                if (fac3 < 4)
                {
                    for (int j = 0; j < fac3; j++) roman.Append('I');
                }
                else if (fac3 == 4) { roman.Append("IV"); break; }
                else if (fac3 < 9)
                {
                    roman.Append('V');
                    for (int j = 0; j < fac3 - 5; j++) roman.Append('I');
                }
                else if (fac3 == 9) { roman.Append("IX"); break; }

                break;

            default:
                break;


        }
    }
    return roman.ToString();
}
