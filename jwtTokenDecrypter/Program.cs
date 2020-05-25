using System;
using jwtDecrypterLibrary;

namespace jwtTokenDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenCryptography tc = new TokenCryptography();
            Console.WriteLine(tc.DecodeHS256("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJjbGFpbTEiOjAsImNsYWltMiI6ImNsYWltMi12YWx1ZSJ9.8pwBI_HtXqI3UgQHQ_rDRnSQRxFL1SR8fbQoS-5kM5s", "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk") ); 
        }
    }
}
