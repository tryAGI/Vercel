
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTeamMembersResponseMemberJoinedFromOrigin
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
    public static class GetTeamMembersResponseMemberJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamMembersResponseMemberJoinedFromOrigin value)
        {
            return value switch
            {
                GetTeamMembersResponseMemberJoinedFromOrigin.Bitbucket => "bitbucket",
                GetTeamMembersResponseMemberJoinedFromOrigin.Dsync => "dsync",
                GetTeamMembersResponseMemberJoinedFromOrigin.Feedback => "feedback",
                GetTeamMembersResponseMemberJoinedFromOrigin.Github => "github",
                GetTeamMembersResponseMemberJoinedFromOrigin.Gitlab => "gitlab",
                GetTeamMembersResponseMemberJoinedFromOrigin.Import => "import",
                GetTeamMembersResponseMemberJoinedFromOrigin.Link => "link",
                GetTeamMembersResponseMemberJoinedFromOrigin.Mail => "mail",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                GetTeamMembersResponseMemberJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                GetTeamMembersResponseMemberJoinedFromOrigin.OrganizationTeams => "organization-teams",
                GetTeamMembersResponseMemberJoinedFromOrigin.Saml => "saml",
                GetTeamMembersResponseMemberJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamMembersResponseMemberJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetTeamMembersResponseMemberJoinedFromOrigin.Bitbucket,
                "dsync" => GetTeamMembersResponseMemberJoinedFromOrigin.Dsync,
                "feedback" => GetTeamMembersResponseMemberJoinedFromOrigin.Feedback,
                "github" => GetTeamMembersResponseMemberJoinedFromOrigin.Github,
                "gitlab" => GetTeamMembersResponseMemberJoinedFromOrigin.Gitlab,
                "import" => GetTeamMembersResponseMemberJoinedFromOrigin.Import,
                "link" => GetTeamMembersResponseMemberJoinedFromOrigin.Link,
                "mail" => GetTeamMembersResponseMemberJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => GetTeamMembersResponseMemberJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => GetTeamMembersResponseMemberJoinedFromOrigin.OrganizationTeams,
                "saml" => GetTeamMembersResponseMemberJoinedFromOrigin.Saml,
                "teams" => GetTeamMembersResponseMemberJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}