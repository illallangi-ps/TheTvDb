using System;

namespace Illallangi.TheTvDb.Tokens
{
    public interface IToken
    {
        string Token { get; set; }
        DateTime Expiry { get; set; }
        DateTime Refresh { get; set; }
    }
}