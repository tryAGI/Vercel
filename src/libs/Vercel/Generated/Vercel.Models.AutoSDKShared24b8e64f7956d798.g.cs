#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared24b8e64f7956d798 : global::System.IEquatable<AutoSDKShared24b8e64f7956d798>
    {
        /// <summary>
        /// Build machine configuration recorded for this deployment's build. See {@link DeploymentBuildMachine}. Distinct from the team/user `resourceConfig.buildMachine`, which only carries `default`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? AutoSDKShared24b8e64f7956d798Variant1 { get; init; }
#else
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? AutoSDKShared24b8e64f7956d798Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared24b8e64f7956d798Variant1))]
#endif
        public bool IsAutoSDKShared24b8e64f7956d798Variant1 => AutoSDKShared24b8e64f7956d798Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared24b8e64f7956d798Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? value)
        {
            value = AutoSDKShared24b8e64f7956d798Variant1;
            return IsAutoSDKShared24b8e64f7956d798Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant1 PickAutoSDKShared24b8e64f7956d798Variant1() => AutoSDKShared24b8e64f7956d798Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared24b8e64f7956d798Variant1' but the value was {ToString()}.");

        /// <summary>
        /// Build machine configuration recorded for this deployment's build. See {@link DeploymentBuildMachine}. Distinct from the team/user `resourceConfig.buildMachine`, which only carries `default`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? AutoSDKShared24b8e64f7956d798Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? AutoSDKShared24b8e64f7956d798Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared24b8e64f7956d798Variant2))]
#endif
        public bool IsAutoSDKShared24b8e64f7956d798Variant2 => AutoSDKShared24b8e64f7956d798Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared24b8e64f7956d798Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? value)
        {
            value = AutoSDKShared24b8e64f7956d798Variant2;
            return IsAutoSDKShared24b8e64f7956d798Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared24b8e64f7956d798Variant2 PickAutoSDKShared24b8e64f7956d798Variant2() => AutoSDKShared24b8e64f7956d798Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared24b8e64f7956d798Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared24b8e64f7956d798(global::Vercel.AutoSDKShared24b8e64f7956d798Variant1 value) => new AutoSDKShared24b8e64f7956d798((global::Vercel.AutoSDKShared24b8e64f7956d798Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared24b8e64f7956d798Variant1?(AutoSDKShared24b8e64f7956d798 @this) => @this.AutoSDKShared24b8e64f7956d798Variant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared24b8e64f7956d798(global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? value)
        {
            AutoSDKShared24b8e64f7956d798Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798 FromAutoSDKShared24b8e64f7956d798Variant1(global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? value) => new AutoSDKShared24b8e64f7956d798(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared24b8e64f7956d798(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2 value) => new AutoSDKShared24b8e64f7956d798((global::Vercel.AutoSDKShared24b8e64f7956d798Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared24b8e64f7956d798Variant2?(AutoSDKShared24b8e64f7956d798 @this) => @this.AutoSDKShared24b8e64f7956d798Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared24b8e64f7956d798(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? value)
        {
            AutoSDKShared24b8e64f7956d798Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798 FromAutoSDKShared24b8e64f7956d798Variant2(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? value) => new AutoSDKShared24b8e64f7956d798(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared24b8e64f7956d798(
            global::Vercel.AutoSDKShared24b8e64f7956d798Variant1? autoSDKShared24b8e64f7956d798Variant1,
            global::Vercel.AutoSDKShared24b8e64f7956d798Variant2? autoSDKShared24b8e64f7956d798Variant2
            )
        {
            AutoSDKShared24b8e64f7956d798Variant1 = autoSDKShared24b8e64f7956d798Variant1;
            AutoSDKShared24b8e64f7956d798Variant2 = autoSDKShared24b8e64f7956d798Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared24b8e64f7956d798Variant2 as object ??
            AutoSDKShared24b8e64f7956d798Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKShared24b8e64f7956d798Variant1?.ToString() ??
            AutoSDKShared24b8e64f7956d798Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKShared24b8e64f7956d798Variant1 && !IsAutoSDKShared24b8e64f7956d798Variant2 || !IsAutoSDKShared24b8e64f7956d798Variant1 && IsAutoSDKShared24b8e64f7956d798Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared24b8e64f7956d798Variant1, TResult>? autoSDKShared24b8e64f7956d798Variant1 = null,
            global::System.Func<global::Vercel.AutoSDKShared24b8e64f7956d798Variant2, TResult>? autoSDKShared24b8e64f7956d798Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared24b8e64f7956d798Variant1 is { } __value0 && autoSDKShared24b8e64f7956d798Variant1 != null)
            {
                return autoSDKShared24b8e64f7956d798Variant1(__value0);
            }
            else if (AutoSDKShared24b8e64f7956d798Variant2 is { } __value1 && autoSDKShared24b8e64f7956d798Variant2 != null)
            {
                return autoSDKShared24b8e64f7956d798Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared24b8e64f7956d798Variant1>? autoSDKShared24b8e64f7956d798Variant1 = null,

            global::System.Action<global::Vercel.AutoSDKShared24b8e64f7956d798Variant2>? autoSDKShared24b8e64f7956d798Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared24b8e64f7956d798Variant1 is { } __value0)
            {
                autoSDKShared24b8e64f7956d798Variant1?.Invoke(__value0);
            }
            else if (AutoSDKShared24b8e64f7956d798Variant2 is { } __value1)
            {
                autoSDKShared24b8e64f7956d798Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared24b8e64f7956d798Variant1>? autoSDKShared24b8e64f7956d798Variant1 = null,
            global::System.Action<global::Vercel.AutoSDKShared24b8e64f7956d798Variant2>? autoSDKShared24b8e64f7956d798Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKShared24b8e64f7956d798Variant1 is { } __value0)
            {
                autoSDKShared24b8e64f7956d798Variant1?.Invoke(__value0);
            }
            else if (AutoSDKShared24b8e64f7956d798Variant2 is { } __value1)
            {
                autoSDKShared24b8e64f7956d798Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKShared24b8e64f7956d798Variant1,
                typeof(global::Vercel.AutoSDKShared24b8e64f7956d798Variant1),
                AutoSDKShared24b8e64f7956d798Variant2,
                typeof(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKShared24b8e64f7956d798 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared24b8e64f7956d798Variant1?>.Default.Equals(AutoSDKShared24b8e64f7956d798Variant1, other.AutoSDKShared24b8e64f7956d798Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared24b8e64f7956d798Variant2?>.Default.Equals(AutoSDKShared24b8e64f7956d798Variant2, other.AutoSDKShared24b8e64f7956d798Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared24b8e64f7956d798 obj1, AutoSDKShared24b8e64f7956d798 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared24b8e64f7956d798>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared24b8e64f7956d798 obj1, AutoSDKShared24b8e64f7956d798 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared24b8e64f7956d798 o && Equals(o);
        }
    }
}
