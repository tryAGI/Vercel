
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin
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
    public static class UserEventPayloadVariant115NewOwnerTeamJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant115NewOwnerTeamJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}