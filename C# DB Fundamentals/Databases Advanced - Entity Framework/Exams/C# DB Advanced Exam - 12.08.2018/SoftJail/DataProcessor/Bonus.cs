﻿namespace SoftJail.DataProcessor
{

    using Data;
    using System;

    public class Bonus
    {
        public static string ReleasePrisoner(SoftJailDbContext context, int prisonerId)
        {
            var prisoner = context.Prisoners.Find(prisonerId);
            if (prisoner.ReleaseDate != null)
            {
                prisoner.ReleaseDate = DateTime.Now;
                prisoner.CellId = null;

                return $"Prisoner {prisoner.FullName} released";
            }
            else
            {
                return $"Prisoner {prisoner.FullName} is sentenced to life";
            }
        }
    }
}
