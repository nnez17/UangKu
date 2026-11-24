using System.ComponentModel.Design;
using System.Globalization;

namespace UangKu.Themes;

internal static class CurrencyFormat
{
    public static void Apply(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            Apply(control);

            if (control is TextBox textBox && IsCurrencyTextBox(textBox))
            {
                textBox.TextChanged += (_, _) => FormatNumber(textBox);
            }
        }
    }

    public static decimal Parse(string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) return 0m;
        var digits = new string(text.Where(char.IsDigit).ToArray());
        return decimal.TryParse(digits, out var val) ? val : 0m;
    }

    private static bool IsCurrencyTextBox(TextBox textBox)
    {
        return textBox.PlaceholderText.Contains("Rp") || 
            textBox.Name.Contains("jumlah", StringComparison.OrdinalIgnoreCase) || 
            textBox.Name.Contains("Nominal", StringComparison.OrdinalIgnoreCase);
    }

    public static void FormatNumber(TextBox textBox)
    {
        int cursorPosition = textBox.SelectionStart;

        int digitBefroeCursor = textBox.Text
            .Take(cursorPosition)
            .Count(c => char.IsDigit(c));

        string numericText = new string(
            textBox.Text.Where(c => char.IsDigit(c)).ToArray());

        if(string.IsNullOrEmpty(numericText))
        {
            textBox.Text = "";
            return;
        }

        numericText = numericText.TrimStart('0');

        if (numericText.Length == 0)
        {
            textBox.Text = "";
            return;
        }

        if (decimal.TryParse(numericText, out decimal value))
        {
            string formatted = value.ToString(
                "N0",
                CultureInfo.GetCultureInfo("id-ID")
                );

            textBox.Text = formatted;

            cursorPosition = 0;
            int digitCount = 0;

            while(cursorPosition < formatted.Length && digitCount < digitBefroeCursor)
            {
                if(char.IsDigit(formatted[cursorPosition]))
                {
                    digitCount++;
                }

                cursorPosition++;
            }

            textBox.SelectionStart = cursorPosition;

            if(textBox.Text == formatted)
                return;
        }
    }
}