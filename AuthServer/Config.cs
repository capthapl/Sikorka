using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources(){
            return new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new ApiResource[]
            {
                new ApiResource("WebApi","Main api access")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new Client[]
            {
                new Client
                {
                   ClientId = "WebApiClient",
                   AllowedGrantTypes = GrantTypes.ClientCredentials,
                   ClientSecrets =
                    {
                        new Secret("h##rm33t1z443j4APQZ".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "WebApi" }
                }
            };
        }
    }
}
