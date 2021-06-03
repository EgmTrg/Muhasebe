using System;
using System.Data;
using System.Linq;


namespace Muhasebe.ORM.Tables.Current
{
    public class Transactions : ORMBase<Entity.Current>
    {
        public int CurrentCode()
        {
            DataRow[] rows = SelectDB().Select();
            int rowsLength = rows.Length;
            int[] alreadyHaveCodeNumbers = new int[rowsLength];
            for (int i = 0; i < rowsLength; i++)
                alreadyHaveCodeNumbers[i] = Convert.ToInt32(rows[i].ItemArray[1].ToString());

            for (int k = 1; k < rowsLength+1; k++)
                if (!alreadyHaveCodeNumbers.Contains(k))
                    return k;
            return -1;
        }
    }
}
