
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListSharedEnvVariableResponseDataItemSecurityIssue
    {
        /// <summary>
        ///
        /// </summary>
        FlagsSecretNeedsSplit,
        /// <summary>
        ///
        /// </summary>
        ReadableSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSharedEnvVariableResponseDataItemSecurityIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSharedEnvVariableResponseDataItemSecurityIssue value)
        {
            return value switch
            {
                ListSharedEnvVariableResponseDataItemSecurityIssue.FlagsSecretNeedsSplit => "flags-secret-needs-split",
                ListSharedEnvVariableResponseDataItemSecurityIssue.ReadableSecret => "readable-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSharedEnvVariableResponseDataItemSecurityIssue? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret-needs-split" => ListSharedEnvVariableResponseDataItemSecurityIssue.FlagsSecretNeedsSplit,
                "readable-secret" => ListSharedEnvVariableResponseDataItemSecurityIssue.ReadableSecret,
                _ => null,
            };
        }
    }
}