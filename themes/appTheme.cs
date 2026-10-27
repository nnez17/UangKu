namespace UangKu.Themes;

internal static class AppTheme
{
    public static void Apply(Control parent, params Button[] menu)
    {
        foreach (Control control in parent.Controls.Cast<Control>().ToArray())
        {
            Apply(control, menu);
            if (control is Button button)
            {
                button.FlatAppearance.BorderSize = 0;
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.MouseOverBackColor = button.ForeColor == Color.White
                    ? Color.FromArgb(17, 109, 90) : Color.FromArgb(221, 239, 231);
                Round(button, 8, !menu.Contains(button) && button.ForeColor != Color.White);
            }
            else if (control is Panel card && card.Name.StartsWith("card"))
            {
                card.BorderStyle = BorderStyle.None;
                Round(card, 16, card.BackColor == Color.White);
            }
            else if (control is Panel && control.Name.EndsWith("Track")) Round(control, 5, false);
            else if (control is TextBox text)
            {
                var frame = new Panel
                {
                    Name = text.Name + "Frame", Bounds = text.Bounds, Anchor = text.Anchor,
                    BackColor = text.BackColor, Padding = new Padding(10, 8, 10, 8),
                    TabIndex = text.TabIndex
                };
                parent.Controls.Add(frame);
                frame.Controls.Add(text);
                text.BorderStyle = BorderStyle.None;
                text.Dock = DockStyle.Fill;
                text.TabIndex = 0;
                Round(frame, 8, true);
            }
        }
    }

    private static void Round(Control control, int radius, bool border)
    {
        System.Drawing.Drawing2D.GraphicsPath Outline(Rectangle bounds)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = Math.Min(radius * 2 * control.DeviceDpi / 96, Math.Min(bounds.Width, bounds.Height));
            path.AddRoundedRectangle(bounds, new Size(diameter, diameter));
            return path;
        }
        void UpdateRegion()
        {
            if (control.Width <= 0 || control.Height <= 0) return;
            using var path = Outline(control.ClientRectangle);
            var old = control.Region;
            control.Region = new Region(path);
            old?.Dispose();
        }
        control.Resize += (_, _) => UpdateRegion();
        if (border) control.Paint += (_, e) =>
        {
            if (control.Width < 3 || control.Height < 3) return;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var path = Outline(new Rectangle(1, 1, control.Width - 3, control.Height - 3));
            using var pen = new Pen(Color.FromArgb(229, 237, 232));
            e.Graphics.DrawPath(pen, path);
        };
        UpdateRegion();
    }
}
