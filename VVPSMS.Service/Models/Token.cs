﻿namespace VVPSMS.Service.Models
{
    public class Token
    {
        public string? AccessToken { get; set; }
        public DateTime AccessTokenExpiry { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
    }

}
