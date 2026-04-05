
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin
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
    public static class UserEventPayloadVariant114NewOwnerTeamJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant114NewOwnerTeamJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}