﻿namespace BreakingBudget.Repositories
{
    static class TypeTransactionRepository
    {
        public const string TABLE_NAME = "TypeTransaction";

        public class TypeTransaction
        {
            public int codeType { get; set; }
            public string libType { get; set; }

            override public string ToString()
            {
                return this.libType;
            }
        }
    }
}