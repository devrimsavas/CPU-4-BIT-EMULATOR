using System.Drawing;

namespace WinFormsApp1.Models
{
    public static class RenderEffects
    {
        public enum Effect
        {
            None = 1,
            Scanline = 2,
            PhosphorGlow = 3,
            RGBMask = 4,
            Vignette = 5,
            CRTFull = 6
        }

        public static Effect ActiveEffect = Effect.None;

        public static Color Apply(Color c, int x, int y)
        {
            switch (ActiveEffect)
            {
                case Effect.Scanline:
                    if (y % 2 != 0)
                        c = Color.FromArgb(c.A, c.R / 2, c.G / 2, c.B / 2);
                    return c;

                case Effect.PhosphorGlow:
                    return Color.FromArgb(c.A,
                        Math.Min(255, c.R + 30),
                        Math.Min(255, c.G + 30),
                        Math.Min(255, c.B + 30));

                case Effect.RGBMask:
                    int sub = x % 3;
                    if (sub == 0) return Color.FromArgb(c.A, c.R, c.G / 2, c.B / 2);
                    if (sub == 1) return Color.FromArgb(c.A, c.R / 2, c.G, c.B / 2);
                    return Color.FromArgb(c.A, c.R / 2, c.G / 2, c.B);

                case Effect.Vignette:
                    float dx = (x - 256) / 256f;
                    float dy = (y - 256) / 256f;
                    float v = Math.Max(0, Math.Min(1, 1f - (dx * dx + dy * dy) * 0.3f));
                    return Color.FromArgb(c.A, (int)(c.R * v), (int)(c.G * v), (int)(c.B * v));

                case Effect.CRTFull:
                    // scanline
                    if (y % 2 != 0)
                        c = Color.FromArgb(c.A, c.R / 2, c.G / 2, c.B / 2);
                    // vignette — daha hafif, 0.8 yerine 0.3 carpani
                    float dx2 = (x - 256) / 256f;
                    float dy2 = (y - 256) / 256f;
                    float v2 = Math.Max(0, Math.Min(1, 1f - (dx2 * dx2 + dy2 * dy2) * 0.3f));
                    return Color.FromArgb(c.A, (int)(c.R * v2), (int)(c.G * v2), (int)(c.B * v2));

                default:
                    return c;
            }
        }
    }
}