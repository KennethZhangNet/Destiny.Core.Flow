﻿using Destiny.Core.Flow.Entity;
using System;
using System.ComponentModel;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// 客户端实体
    /// </summary>
    [DisplayName()]
    public class ClientBase : IEntity<Guid>
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DisplayName("主键")]
        public Guid Id { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        [DisplayName("是否启用")]
        public bool Enabled { get; set; } = true;
        /// <summary>
        /// 客户端Id
        /// </summary>
        [DisplayName("客户端Id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 协议类型
        /// </summary>
        [DisplayName("协议类型")]
        public string ProtocolType { get; set; } = "oidc";

        public bool RequireClientSecret { get; set; } = true;

        public string ClientName { get; set; }

        public string Description { get; set; }

        public string ClientUri { get; set; }

        public string LogoUri { get; set; }

        public bool RequireConsent { get; set; }

        public bool AllowRememberConsent { get; set; } = true;

        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }

        public bool RequirePkce { get; set; } = true;

        public bool AllowPlainTextPkce { get; set; }

        public bool RequireRequestObject { get; set; }

        public bool AllowAccessTokensViaBrowser { get; set; }

        public string FrontChannelLogoutUri { get; set; }

        public bool FrontChannelLogoutSessionRequired { get; set; } = true;

        public string BackChannelLogoutUri { get; set; }

        public bool BackChannelLogoutSessionRequired { get; set; } = true;

        public bool AllowOfflineAccess { get; set; }

        public int IdentityTokenLifetime { get; set; } = 300;

        public string AllowedIdentityTokenSigningAlgorithms { get; set; }

        public int AccessTokenLifetime { get; set; } = 3600;

        public int AuthorizationCodeLifetime { get; set; } = 300;


        public int? ConsentLifetime { get; set; }

        public int AbsoluteRefreshTokenLifetime { get; set; } = 2592000;

        public int SlidingRefreshTokenLifetime { get; set; } = 1296000;

        public int RefreshTokenUsage { get; set; } = 1;


        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }

        public int RefreshTokenExpiration { get; set; } = 1;

        public int AccessTokenType { get; set; }

        public bool EnableLocalLogin { get; set; } = true;

        public bool IncludeJwtId { get; set; }


        public bool AlwaysSendClientClaims { get; set; }

        public string ClientClaimsPrefix { get; set; } = "client_";


        public string PairWiseSubjectSalt { get; set; }


        public DateTime Created { get; set; } = DateTime.UtcNow;


        public DateTime? Updated { get; set; }

        public DateTime? LastAccessed { get; set; }

        public int? UserSsoLifetime { get; set; }

        public string UserCodeType { get; set; }

        public int DeviceCodeLifetime { get; set; } = 300;


        public bool NonEditable { get; set; }

        #region IdentityServer4原始导航属性

        //public List<ClientClaim> Claims{get;set;}

        //public List<ClientCorsOrigin> AllowedCorsOrigins { get; set; }

        //public List<ClientProperty> Properties { get; set; }

        //public List<ClientIdPRestriction> IdentityProviderRestrictions{get;set;}

        //public List<ClientRedirectUri> RedirectUris { get; set; }

        //public List<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }

        //public List<ClientSecret> ClientSecrets{get;set;}

        //public List<ClientScope> AllowedScopes{get;set;}

        //public List<ClientGrantType> AllowedGrantTypes { get; set; }

        #endregion
    }
}