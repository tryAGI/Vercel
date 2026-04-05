
#nullable enable

namespace Vercel
{
    /// <summary>
    /// "The `ADMIN` role, by default, is provided to users capable of installing integrations, while the `USER` role can be granted to Vercel users with the Vercel `Billing` or Vercel `Viewer` role, which are considered to be Read-Only roles."
    /// </summary>
    public enum GetMemberResponseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMemberResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMemberResponseRole value)
        {
            return value switch
            {
                GetMemberResponseRole.Admin => "ADMIN",
                GetMemberResponseRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMemberResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => GetMemberResponseRole.Admin,
                "USER" => GetMemberResponseRole.User,
                _ => null,
            };
        }
    }
}