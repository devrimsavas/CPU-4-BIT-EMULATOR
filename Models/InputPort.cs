namespace WinFormsApp1.Models
{
    public static class InputPort
    {
        private static bool[] _currentCode = new bool[4];
        private static bool[] _currentPage = new bool[4];

        public static void SetKey(bool[] page, bool[] code)
        {
            _currentPage = (bool[])page.Clone();
            _currentCode = (bool[])code.Clone();
        }

        public static void ClearKey()
        {
            _currentCode = new bool[] { false, false, false, false };
            _currentPage = new bool[] { false, false, false, false };
        }

        public static bool[] ReadCode() => (bool[])_currentCode.Clone();
        public static bool[] ReadPage() => (bool[])_currentPage.Clone();
    }
}