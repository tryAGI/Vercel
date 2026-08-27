
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Controls who can request access to protected deployments.
    /// </summary>
    public enum TeamDpAccessRequestsMode
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
    public static class TeamDpAccessRequestsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDpAccessRequestsMode value)
        {
            return value switch
            {
                TeamDpAccessRequestsMode.All => "all",
                TeamDpAccessRequestsMode.EmailDomain => "email-domain",
                TeamDpAccessRequestsMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDpAccessRequestsMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => TeamDpAccessRequestsMode.All,
                "email-domain" => TeamDpAccessRequestsMode.EmailDomain,
                "none" => TeamDpAccessRequestsMode.None,
                _ => null,
            };
        }
    }
}