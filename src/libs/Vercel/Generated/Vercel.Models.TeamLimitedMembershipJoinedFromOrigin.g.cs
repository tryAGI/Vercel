
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamLimitedMembershipJoinedFromOrigin
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
        NsnbRedeployAttributionCard,
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
    public static class TeamLimitedMembershipJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamLimitedMembershipJoinedFromOrigin value)
        {
            return value switch
            {
                TeamLimitedMembershipJoinedFromOrigin.Bitbucket => "bitbucket",
                TeamLimitedMembershipJoinedFromOrigin.Dsync => "dsync",
                TeamLimitedMembershipJoinedFromOrigin.Feedback => "feedback",
                TeamLimitedMembershipJoinedFromOrigin.Github => "github",
                TeamLimitedMembershipJoinedFromOrigin.Gitlab => "gitlab",
                TeamLimitedMembershipJoinedFromOrigin.Import => "import",
                TeamLimitedMembershipJoinedFromOrigin.Link => "link",
                TeamLimitedMembershipJoinedFromOrigin.Mail => "mail",
                TeamLimitedMembershipJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                TeamLimitedMembershipJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                TeamLimitedMembershipJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                TeamLimitedMembershipJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                TeamLimitedMembershipJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                TeamLimitedMembershipJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                TeamLimitedMembershipJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                TeamLimitedMembershipJoinedFromOrigin.OrganizationTeams => "organization-teams",
                TeamLimitedMembershipJoinedFromOrigin.Saml => "saml",
                TeamLimitedMembershipJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamLimitedMembershipJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => TeamLimitedMembershipJoinedFromOrigin.Bitbucket,
                "dsync" => TeamLimitedMembershipJoinedFromOrigin.Dsync,
                "feedback" => TeamLimitedMembershipJoinedFromOrigin.Feedback,
                "github" => TeamLimitedMembershipJoinedFromOrigin.Github,
                "gitlab" => TeamLimitedMembershipJoinedFromOrigin.Gitlab,
                "import" => TeamLimitedMembershipJoinedFromOrigin.Import,
                "link" => TeamLimitedMembershipJoinedFromOrigin.Link,
                "mail" => TeamLimitedMembershipJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => TeamLimitedMembershipJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => TeamLimitedMembershipJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => TeamLimitedMembershipJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => TeamLimitedMembershipJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => TeamLimitedMembershipJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => TeamLimitedMembershipJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => TeamLimitedMembershipJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => TeamLimitedMembershipJoinedFromOrigin.OrganizationTeams,
                "saml" => TeamLimitedMembershipJoinedFromOrigin.Saml,
                "teams" => TeamLimitedMembershipJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}