
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Docker/OCI build instruction associated with an image layer.
    /// </summary>
    public enum VcrImageLayerVariant3Operation
    {
        /// <summary>
        ///
        /// </summary>
        Add,
        /// <summary>
        ///
        /// </summary>
        Arg,
        /// <summary>
        ///
        /// </summary>
        Cmd,
        /// <summary>
        ///
        /// </summary>
        Copy,
        /// <summary>
        ///
        /// </summary>
        Entrypoint,
        /// <summary>
        ///
        /// </summary>
        Env,
        /// <summary>
        ///
        /// </summary>
        Expose,
        /// <summary>
        ///
        /// </summary>
        From,
        /// <summary>
        ///
        /// </summary>
        Healthcheck,
        /// <summary>
        ///
        /// </summary>
        Label,
        /// <summary>
        ///
        /// </summary>
        Onbuild,
        /// <summary>
        ///
        /// </summary>
        Run,
        /// <summary>
        ///
        /// </summary>
        Shell,
        /// <summary>
        ///
        /// </summary>
        Stopsignal,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        User,
        /// <summary>
        ///
        /// </summary>
        Volume,
        /// <summary>
        ///
        /// </summary>
        Workdir,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant3OperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant3Operation value)
        {
            return value switch
            {
                VcrImageLayerVariant3Operation.Add => "ADD",
                VcrImageLayerVariant3Operation.Arg => "ARG",
                VcrImageLayerVariant3Operation.Cmd => "CMD",
                VcrImageLayerVariant3Operation.Copy => "COPY",
                VcrImageLayerVariant3Operation.Entrypoint => "ENTRYPOINT",
                VcrImageLayerVariant3Operation.Env => "ENV",
                VcrImageLayerVariant3Operation.Expose => "EXPOSE",
                VcrImageLayerVariant3Operation.From => "FROM",
                VcrImageLayerVariant3Operation.Healthcheck => "HEALTHCHECK",
                VcrImageLayerVariant3Operation.Label => "LABEL",
                VcrImageLayerVariant3Operation.Onbuild => "ONBUILD",
                VcrImageLayerVariant3Operation.Run => "RUN",
                VcrImageLayerVariant3Operation.Shell => "SHELL",
                VcrImageLayerVariant3Operation.Stopsignal => "STOPSIGNAL",
                VcrImageLayerVariant3Operation.Unknown => "UNKNOWN",
                VcrImageLayerVariant3Operation.User => "USER",
                VcrImageLayerVariant3Operation.Volume => "VOLUME",
                VcrImageLayerVariant3Operation.Workdir => "WORKDIR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant3Operation? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => VcrImageLayerVariant3Operation.Add,
                "ARG" => VcrImageLayerVariant3Operation.Arg,
                "CMD" => VcrImageLayerVariant3Operation.Cmd,
                "COPY" => VcrImageLayerVariant3Operation.Copy,
                "ENTRYPOINT" => VcrImageLayerVariant3Operation.Entrypoint,
                "ENV" => VcrImageLayerVariant3Operation.Env,
                "EXPOSE" => VcrImageLayerVariant3Operation.Expose,
                "FROM" => VcrImageLayerVariant3Operation.From,
                "HEALTHCHECK" => VcrImageLayerVariant3Operation.Healthcheck,
                "LABEL" => VcrImageLayerVariant3Operation.Label,
                "ONBUILD" => VcrImageLayerVariant3Operation.Onbuild,
                "RUN" => VcrImageLayerVariant3Operation.Run,
                "SHELL" => VcrImageLayerVariant3Operation.Shell,
                "STOPSIGNAL" => VcrImageLayerVariant3Operation.Stopsignal,
                "UNKNOWN" => VcrImageLayerVariant3Operation.Unknown,
                "USER" => VcrImageLayerVariant3Operation.User,
                "VOLUME" => VcrImageLayerVariant3Operation.Volume,
                "WORKDIR" => VcrImageLayerVariant3Operation.Workdir,
                _ => null,
            };
        }
    }
}