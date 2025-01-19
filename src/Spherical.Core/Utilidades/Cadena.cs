﻿namespace Spherical.Core.Creative
{
    public static class Cadena
    {
        public static string CodigoAleatorio(this int longitud)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, longitud)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}