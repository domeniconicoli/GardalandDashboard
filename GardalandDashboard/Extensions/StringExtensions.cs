namespace GardalandDashboard.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Crops a string without throwing exceptions
        /// </summary>
        public static string SafeSubstringWithEllipsize(this string text, int start, int length)
        {
            return text.Length <= start ? ""
                : text.Length - start <= length ? text.Substring(start)
                : text.Substring(start, length).Ellipsize();
        }

        public static string Ellipsize(this string text)
        {
            return text + "…";
        }
    }
}
