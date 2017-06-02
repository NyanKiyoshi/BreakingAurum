﻿using System;
using System.Data.OleDb;

namespace BreakingBudget.Repositories
{
    public static class EcheanceRepository
    {
        public const string TABLE_NAME = "Echeances";

        public static void Create(
            OleDbConnection dbConn,
            OleDbTransaction transaction,
            int codePoste,
            DateTime dt,
            decimal amount
        )
        {
            OleDbCommand cmd = new OleDbCommand(
                string.Format(
                    @"INSERT INTO [{0}] (codePoste,  datePrelevt,   montantEcheance) 
                                 VALUES(@codePoste, @datePrelevt,  @montantEcheance)", TABLE_NAME),
                dbConn, transaction
            );

            cmd.Parameters.AddWithValue("@codePoste",       codePoste);
            cmd.Parameters.AddWithValue("@datePrelevt",     OleDbType.Date).Value = dt.Date;
            cmd.Parameters.AddWithValue("@montantEcheance", amount);

            Console.WriteLine("<- INSERT INTO Echeances: {0}, {1}, {2}", codePoste, dt, amount);
            cmd.ExecuteNonQuery();
        }
    }
}