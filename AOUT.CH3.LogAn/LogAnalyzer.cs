using System;

namespace AOUT.CH3.LogAn
{
    public class LogAnalyzer
    {
        private bool wasLastFileNameValid;

        public bool WasLastFileNameValid
        {
            get { return wasLastFileNameValid; }
            set { wasLastFileNameValid = value; }
        }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("имя файла долно быть задано");
            }

            if (!fileName.ToLower().EndsWith(".SLF",
                StringComparison.CurrentCultureIgnoreCase))
            {               
                return false;
            }

            WasLastFileNameValid = true;
            return true;
        }
    }
}
