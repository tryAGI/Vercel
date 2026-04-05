
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestProjects
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainRequestProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestProjects value)
        {
            return value switch
            {
                UpdateDrainRequestProjects.All => "all",
                UpdateDrainRequestProjects.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestProjects? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateDrainRequestProjects.All,
                "some" => UpdateDrainRequestProjects.Some,
                _ => null,
            };
        }
    }
}