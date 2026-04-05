
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A string representing the permission for projects. Possible values are `all` or `selected`.<br/>
    /// Example: all
    /// </summary>
    public enum GetConfigurationResponseVariant1ProjectSelection
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant1ProjectSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1ProjectSelection value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1ProjectSelection.All => "all",
                GetConfigurationResponseVariant1ProjectSelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1ProjectSelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetConfigurationResponseVariant1ProjectSelection.All,
                "selected" => GetConfigurationResponseVariant1ProjectSelection.Selected,
                _ => null,
            };
        }
    }
}