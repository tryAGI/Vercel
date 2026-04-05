
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2ProjectAccessVariant1Access
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2ProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2ProjectAccessVariant1Access value)
        {
            return value switch
            {
                GetDrainResponseVariant2ProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2ProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetDrainResponseVariant2ProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}