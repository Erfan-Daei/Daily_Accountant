using System.Text.RegularExpressions;

namespace Accountant.Main.MainForm
{
    internal class Calculator
    {
        public double result;
        public int priority;

        public void Tax(string Text)
        {
            bool IsTax = Regex.IsMatch(Text, @"\bT\d*");
            bool IsTaxR = Regex.IsMatch(Text, @"\bR\d*");

            if (IsTax)
            {
                Text = Text.Replace("x", "*");
                MatchCollection MatchTax = Regex.Matches(Text, @"\bT(.*?)\W");

                List<double> Tx = new List<double>();
                foreach (Match m in MatchTax)
                    Tx.Add(Convert.ToDouble(m.Groups[1].Value));

                List<double> Results = new List<double>();
                for (int i = 0; i < Tx.Count; i++)
                {
                    Calculate(Tx[i], 0, "T");
                    Results.Add(result);
                }
                for (int i = 0; i < Results.Count; i++)
                {
                    Text = Text.Replace(Tx[i].ToString(), Results[i].ToString());
                }

                Text = Regex.Replace(Text, @"T", "");
                Text = Text.Replace( "*", "x");
                Parenteses(Text);
            }
            else if (IsTaxR)
            {
                Text = Text.Replace("x", "*");
                MatchCollection MatchTax = Regex.Matches(Text, @"\bR(.*?)\W");

                List<double> Tx = new List<double>();
                foreach (Match m in MatchTax)
                    Tx.Add(Convert.ToDouble(m.Groups[1].Value));

                List<double> Results = new List<double>();
                for (int i = 0; i < Tx.Count; i++)
                {
                    Calculate(Tx[i], 0, "T");
                    Calculate(Tx[i], result, "R");
                    Results.Add(result);
                }
                for (int i = 0; i < Results.Count; i++)
                {
                    Text = Text.Replace(Tx[i].ToString(), Results[i].ToString());
                }

                Text = Regex.Replace(Text, @"R", "");
                Text = Text.Replace("*", "x");
                Parenteses(Text);
            }
            else
            {
                Parenteses(Text);
            }
        }

        public void Parenteses(string Text)
        {
            bool IsParen = Regex.IsMatch(Text, @"\(.*?\)");
            if (IsParen)
            {
                MatchCollection MatchParen = Regex.Matches(Text, @"\((.*?)\)");

                List<string> Opr = new List<string>();
                foreach (Match m in MatchParen)
                    Opr.Add(m.Groups[1].Value);

                List<double> Results = new List<double>();
                for (int i = 0; i < Opr.Count; i++)
                {
                    GetText(Opr[i] + "=");
                    Results.Add(result);
                }
                for (int i = 0; i < Results.Count; i++)
                {
                    Text = Text.Replace(Opr[i], Results[i].ToString());
                }

                Text = Regex.Replace(Text, @"[\(]|[\)]", "");
                GetText(Text);
            }
            else
            {
                GetText(Text);
            }
        }

        public void GetText(string Text)
        {
            String[] GetNumber = Regex.Split(Text, @"(?<=\s)|[+\-x/%PL=]", RegexOptions.IgnoreCase);
            Array.Resize(ref GetNumber, GetNumber.Length - 1);
            MatchCollection MatchDelimiters = Regex.Matches(Text, @"[+\-x/%PL=]+");

            List<string> Delimiters = new List<string>();
            foreach (Match M in MatchDelimiters)
            {
                Delimiters.Add(M.Value);
            }

            List<double> Numbers = new List<double>();
            foreach (string number in GetNumber)
            {
                Numbers.Add(Convert.ToDouble(number));
            }
           
            DetectOperation(Numbers, Delimiters);
        }

        public void DetectOperation(List<double> N, List<string> D)
        {
            List<double> Number = N;
            List<string> Delimiter = D;

            for (int j = 0; j < Delimiter.Count; j++)
            {
                GetPriority(Number, Delimiter);

                if (priority != -1)
                {
                    Calculate(Number[priority], Number[priority + 1], Delimiter[priority]);
                    Number[priority] = result;
                    Number.RemoveRange(priority + 1, 1);
                    Delimiter.RemoveRange(priority, 1);
                    DetectOperation(Number, Delimiter);
                }
                else if (priority == -1)
                {
                    for (int i = 0; i < Delimiter.Count; i++)
                    {
                        try
                        {
                            Calculate(Number[i], Number[i + 1], Delimiter[i]);
                            Number[i] = result;
                            Number.RemoveRange(i + 1, 1);
                            Delimiter.RemoveRange(i, 1);
                            DetectOperation(Number, Delimiter);
                        }
                        catch
                        {
                            Calculate(Number[i], 0, Delimiter[i]);
                            Number[i] = result;
                            Delimiter.RemoveRange(i, 1);
                            DetectOperation(Number, Delimiter);
                        }
                        
                    }
                }
            }
        }
        public int GetPriority(List<double> N, List<string> D)
        {
            priority = -1;
            var temp1 = D.IndexOf("x");
            var temp2 = D.IndexOf("/");
            var temp3 = D.IndexOf("%");
            var temp4 = D.IndexOf("P");
            var temp5 = D.IndexOf("L");

            if (temp4 != -1 || temp5 != -1)
            {
                if (temp4 == -1)
                    temp4 = 1000;
                if (temp5 == -1)
                    temp5 = 1000;
                if (temp4 < temp5)
                    priority = temp4;
                else if (temp5 < temp4)
                    priority = temp5;
            }
            else
            {
                if (temp3 != -1)
                    priority = temp3;
                else
                {
                    if (temp1 != -1 || temp2 != -1)
                    {
                        if (temp1 == -1)
                            temp1 = 1000;
                        if (temp2 == -1)
                            temp2 = 1000;
                        if (temp1 < temp2)
                            priority = temp1;
                        if (temp2 < temp1)
                            priority = temp2;
                    }
                    else
                    {
                        priority = -1;
                    }
                }
            }
            return priority;
        }
        public double Calculate(double n1, double n2, string D)
        {
            switch (D)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "x":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 * n2 / 100;
                    break;
                case "P":
                    result = n1 + (n1 * n2 / 100);
                    break;
                case "L":
                    result = n1 - (n1 * n2 / 100);
                    break;
                case "=":
                    result = n1;
                    break;
                case "T":
                    if (n1 < 5000000)
                        result = 0;

                    if (n1 >= 5000000 && n1 <= 15000000)
                        result = (n1 - 5600000) * 10 / 100;

                    if (n1 >= 15000000 && n1 <= 20000000)
                        result = ((n1 - 15000000) * 15 / 100) + ((15000000 - 5600000) * 10 / 100);

                    if (n1 >= 25000000 && n1 <= 35000000)
                        result = (n1 - 25000000) * 20 / 100 + ((25000000 - 15000000) * 15 / 100) + ((15000000 - 5600000) * 10 / 100);

                    if (n1 >= 35000000)
                        result = ((n1 - 35000000) * 30 / 100) + ((35000000 - 25000000) * 20 / 100) + ((25000000 - 15000000) * 15 / 100) + ((15000000 - 5600000) * 10 / 100);
                    break;
                case "R":
                    result = n1 - n2;
                    break;
            }
            return result;
        }
    }
}
