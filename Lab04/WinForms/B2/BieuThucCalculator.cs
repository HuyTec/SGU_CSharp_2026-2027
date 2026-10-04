using System.Globalization;

namespace WinForms.B21;

public static class BieuThucCalculator
{
    public static double Tinh(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            throw new FormatException("Biểu thức không được để trống.");

        var parser = new Parser(expression);
        double result = parser.ParseExpression(true);
        parser.SkipWhiteSpace();

        if (!parser.IsEnd)
            throw new FormatException("Biểu thức sai cú pháp hoặc chứa ký tự không hợp lệ.");

        if (double.IsNaN(result) || double.IsInfinity(result))
            throw new FormatException("Kết quả không hợp lệ.");

        return result;
    }

    private sealed class Parser
    {
        private readonly string expression;
        private int position;

        public Parser(string expression)
        {
            this.expression = expression;
        }

        public bool IsEnd => position >= expression.Length;

        public double ParseExpression(bool allowUnary)
        {
            double value = ParseTerm(allowUnary);

            while (true)
            {
                SkipWhiteSpace();
                if (Match('+'))
                    value += ParseTerm(false);
                else if (Match('-'))
                    value -= ParseTerm(false);
                else
                    return value;
            }
        }

        private double ParseTerm(bool allowUnary)
        {
            double value = ParsePower(allowUnary);

            while (true)
            {
                SkipWhiteSpace();
                if (Match('*'))
                    value *= ParsePower(false);
                else if (Match('/'))
                {
                    double divisor = ParsePower(false);
                    if (divisor == 0)
                        throw new DivideByZeroException("Không thể chia cho 0.");
                    value /= divisor;
                }
                else
                    return value;
            }
        }

        private double ParsePower(bool allowUnary)
        {
            double value = ParsePrimary(allowUnary);
            SkipWhiteSpace();

            if (Match('^'))
                value = Math.Pow(value, ParsePower(false));

            return value;
        }

        private double ParsePrimary(bool allowUnary)
        {
            SkipWhiteSpace();

            if (Match('-'))
            {
                if (!allowUnary)
                    throw new FormatException("Dấu trừ chỉ được đứng đầu hoặc ngay sau dấu mở ngoặc.");
                return -ParsePrimary(false);
            }

            if (Match('('))
            {
                double value = ParseExpression(true);
                Require(')', "Thiếu dấu đóng ngoặc.");
                return value;
            }

            if (StartsWith("sqrt"))
            {
                position += 4;
                SkipWhiteSpace();
                Require('(', "Hàm sqrt phải có dạng sqrt(...).");
                double value = ParseExpression(true);
                Require(')', "Thiếu dấu đóng ngoặc của hàm sqrt.");
                if (value < 0)
                    throw new ArithmeticException("Không thể tính căn bậc hai của số âm.");
                return Math.Sqrt(value);
            }

            return ParseNumber();
        }

        private double ParseNumber()
        {
            SkipWhiteSpace();
            int start = position;
            bool hasDigit = false;

            while (!IsEnd && char.IsDigit(expression[position]))
            {
                position++;
                hasDigit = true;
            }

            if (!IsEnd && expression[position] == '.')
            {
                position++;
                while (!IsEnd && char.IsDigit(expression[position]))
                {
                    position++;
                    hasDigit = true;
                }
            }

            if (!hasDigit)
                throw new FormatException("Thiếu số hoặc biểu thức sai cú pháp.");

            string text = expression[start..position];
            if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                throw new FormatException("Số trong biểu thức không hợp lệ.");

            return value;
        }

        public void SkipWhiteSpace()
        {
            while (!IsEnd && char.IsWhiteSpace(expression[position]))
                position++;
        }

        private bool StartsWith(string value)
        {
            return expression.AsSpan(position).StartsWith(value, StringComparison.Ordinal);
        }

        private bool Match(char character)
        {
            SkipWhiteSpace();
            if (!IsEnd && expression[position] == character)
            {
                position++;
                return true;
            }

            return false;
        }

        private void Require(char character, string message)
        {
            if (!Match(character))
                throw new FormatException(message);
        }
    }
}
