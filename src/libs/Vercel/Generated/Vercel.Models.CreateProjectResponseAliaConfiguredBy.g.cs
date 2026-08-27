
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaConfiguredBy
    {
        /// <summary>
        ///
        /// </summary>
        A,
        /// <summary>
        ///
        /// </summary>
        Cname,
        /// <summary>
        ///
        /// </summary>
        Dns01,
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaConfiguredBy value)
        {
            return value switch
            {
                CreateProjectResponseAliaConfiguredBy.A => "A",
                CreateProjectResponseAliaConfiguredBy.Cname => "CNAME",
                CreateProjectResponseAliaConfiguredBy.Dns01 => "dns-01",
                CreateProjectResponseAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => CreateProjectResponseAliaConfiguredBy.A,
                "CNAME" => CreateProjectResponseAliaConfiguredBy.Cname,
                "dns-01" => CreateProjectResponseAliaConfiguredBy.Dns01,
                "http" => CreateProjectResponseAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}