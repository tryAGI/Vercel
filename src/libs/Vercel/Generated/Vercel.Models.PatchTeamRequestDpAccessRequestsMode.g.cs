
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Controls who can request access to protected deployments.<br/>
    /// Example: none
    /// </summary>
    public enum PatchTeamRequestDpAccessRequestsMode
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        EmailDomain,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDpAccessRequestsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDpAccessRequestsMode value)
        {
            return value switch
            {
                PatchTeamRequestDpAccessRequestsMode.All => "all",
                PatchTeamRequestDpAccessRequestsMode.EmailDomain => "email-domain",
                PatchTeamRequestDpAccessRequestsMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDpAccessRequestsMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchTeamRequestDpAccessRequestsMode.All,
                "email-domain" => PatchTeamRequestDpAccessRequestsMode.EmailDomain,
                "none" => PatchTeamRequestDpAccessRequestsMode.None,
                _ => null,
            };
        }
    }
}