using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SocietyCare.AuthenticateData
{
    public class Utilities
    {
        public static Claim[] GetTokenClaims(string sub)
        {
            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            // You can add other claims here, if you want:
            return new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, sub),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
        }
        public static TokenDetails GenerateTokens(string email)
        {
            DateTime now = DateTime.Now;
            var result =new TokenDetails();
            var accessJwt = new JwtSecurityToken(issuer: Startup.userTokenOptions.Issuer, audience: Startup.userTokenOptions.Audience, claims: GetTokenClaims(email), notBefore: now, expires: now.Add(Startup.userTokenOptions.AccessExpiration), signingCredentials: Startup.userTokenOptions.SigningCredentials);

            try
            {
                var encodedAccessJwt = new JwtSecurityTokenHandler().WriteToken(accessJwt);

                var refreshJwt = new JwtSecurityToken(issuer: Startup.userTokenOptions.Issuer, audience: Startup.userTokenOptions.Audience, claims: GetTokenClaims(email), notBefore: now, expires: now.Add(Startup.userTokenOptions.RefreshExpiration), signingCredentials: Startup.userTokenOptions.SigningCredentials);
                var encodedRefreshJwt = new JwtSecurityTokenHandler().WriteToken(refreshJwt);
                 result = new TokenDetails
                {
                    access_token = encodedAccessJwt,
                    access_token_expires_in = (int)Startup.userTokenOptions.AccessExpiration.TotalSeconds,
                    refresh_token = encodedRefreshJwt,
                    refresh_token_expires_in = (int)Startup.userTokenOptions.RefreshExpiration.TotalSeconds,
                };
            }
            catch(Exception ex)
            {

            }

            return result;
        }
    }
}
