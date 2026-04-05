
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestAccessToTeamResponseJoinedFromOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Dsync,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        Mail,
        /// <summary>
        /// 
        /// </summary>
        NsnbAutoApprove,
        /// <summary>
        /// 
        /// </summary>
        NsnbHobbyUpgrade,
        /// <summary>
        /// 
        /// </summary>
        NsnbInvite,
        /// <summary>
        /// 
        /// </summary>
        NsnbRedeploy,
        /// <summary>
        /// 
        /// </summary>
        NsnbRequestAccess,
        /// <summary>
        /// 
        /// </summary>
        NsnbViewerUpgrade,
        /// <summary>
        /// 
        /// </summary>
        OrganizationTeams,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestAccessToTeamResponseJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAccessToTeamResponseJoinedFromOrigin value)
        {
            return value switch
            {
                RequestAccessToTeamResponseJoinedFromOrigin.Bitbucket => "bitbucket",
                RequestAccessToTeamResponseJoinedFromOrigin.Dsync => "dsync",
                RequestAccessToTeamResponseJoinedFromOrigin.Feedback => "feedback",
                RequestAccessToTeamResponseJoinedFromOrigin.Github => "github",
                RequestAccessToTeamResponseJoinedFromOrigin.Gitlab => "gitlab",
                RequestAccessToTeamResponseJoinedFromOrigin.Import => "import",
                RequestAccessToTeamResponseJoinedFromOrigin.Link => "link",
                RequestAccessToTeamResponseJoinedFromOrigin.Mail => "mail",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                RequestAccessToTeamResponseJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                RequestAccessToTeamResponseJoinedFromOrigin.OrganizationTeams => "organization-teams",
                RequestAccessToTeamResponseJoinedFromOrigin.Saml => "saml",
                RequestAccessToTeamResponseJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAccessToTeamResponseJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => RequestAccessToTeamResponseJoinedFromOrigin.Bitbucket,
                "dsync" => RequestAccessToTeamResponseJoinedFromOrigin.Dsync,
                "feedback" => RequestAccessToTeamResponseJoinedFromOrigin.Feedback,
                "github" => RequestAccessToTeamResponseJoinedFromOrigin.Github,
                "gitlab" => RequestAccessToTeamResponseJoinedFromOrigin.Gitlab,
                "import" => RequestAccessToTeamResponseJoinedFromOrigin.Import,
                "link" => RequestAccessToTeamResponseJoinedFromOrigin.Link,
                "mail" => RequestAccessToTeamResponseJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => RequestAccessToTeamResponseJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => RequestAccessToTeamResponseJoinedFromOrigin.OrganizationTeams,
                "saml" => RequestAccessToTeamResponseJoinedFromOrigin.Saml,
                "teams" => RequestAccessToTeamResponseJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}