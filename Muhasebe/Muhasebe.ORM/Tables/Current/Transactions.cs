using System;
using System.Data;
using System.Linq;


namespace Muhasebe.ORM.Tables.Current
{
    public class Transactions : ORMBase<Entity.Current>
    {
        /// <summary>
        /// Detect usable code and return.
        /// </summary>
        /// <returns></returns>
        public int CreateCurrentCode()
        {
            int[] codeNumbers = DetectAlreadyHaveCode();
            for (int k = 1; k <= codeNumbers.Length + 1; k++)
                if (!codeNumbers.Contains(k))
                    return k;
            return -1;
        }
            /// <summary>
        /// If return true, Database have this code number. Else it is usable code.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CurrentCodeControl(int code)
        {
            int[] codeNumbers = DetectAlreadyHaveCode();
            if (codeNumbers.Contains(code))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Detects all codes in database and return as array.
        /// </summary>
        /// <returns></returns>
        private int[] DetectAlreadyHaveCode()
        {
            DataRow[] rows = SelectDB().Select();
            int rowsLength = rows.Length;
            int[] alreadyHaveCodeNumbers = new int[rowsLength];
            // We detect which codes we have and save.
            for (int i = 0; i < rowsLength; i++)
                alreadyHaveCodeNumbers[i] = Convert.ToInt32(rows[i].ItemArray[1].ToString());
            
            return alreadyHaveCodeNumbers;
        }
    }
}
