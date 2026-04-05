
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsView
    {
        /// <summary>
        /// 
        /// </summary>
        Account,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsView value)
        {
            return value switch
            {
                GetConfigurationsView.Account => "account",
                GetConfigurationsView.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsView? ToEnum(string value)
        {
            return value switch
            {
                "account" => GetConfigurationsView.Account,
                "project" => GetConfigurationsView.Project,
                _ => null,
            };
        }
    }
}