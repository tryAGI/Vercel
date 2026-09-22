#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared78353984d471628d : global::System.IEquatable<AutoSDKShared78353984d471628d>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared78353984d471628dVariant1? AutoSDKShared78353984d471628dVariant1 { get; init; }
#else
        public global::Vercel.AutoSDKShared78353984d471628dVariant1? AutoSDKShared78353984d471628dVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared78353984d471628dVariant1))]
#endif
        public bool IsAutoSDKShared78353984d471628dVariant1 => AutoSDKShared78353984d471628dVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared78353984d471628dVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared78353984d471628dVariant1? value)
        {
            value = AutoSDKShared78353984d471628dVariant1;
            return IsAutoSDKShared78353984d471628dVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared78353984d471628dVariant1 PickAutoSDKShared78353984d471628dVariant1() => IsAutoSDKShared78353984d471628dVariant1
            ? AutoSDKShared78353984d471628dVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared78353984d471628dVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared238fc1521601aa81? Shared238fc1521601aa81 { get; init; }
#else
        public global::Vercel.AutoSDKShared238fc1521601aa81? Shared238fc1521601aa81 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared238fc1521601aa81))]
#endif
        public bool IsShared238fc1521601aa81 => Shared238fc1521601aa81 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared238fc1521601aa81(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared238fc1521601aa81? value)
        {
            value = Shared238fc1521601aa81;
            return IsShared238fc1521601aa81;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared238fc1521601aa81 PickShared238fc1521601aa81() => IsShared238fc1521601aa81
            ? Shared238fc1521601aa81!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared238fc1521601aa81' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared78353984d471628d(global::Vercel.AutoSDKShared78353984d471628dVariant1 value) => new AutoSDKShared78353984d471628d((global::Vercel.AutoSDKShared78353984d471628dVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared78353984d471628dVariant1?(AutoSDKShared78353984d471628d @this) => @this.AutoSDKShared78353984d471628dVariant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78353984d471628d(global::Vercel.AutoSDKShared78353984d471628dVariant1? value)
        {
            AutoSDKShared78353984d471628dVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared78353984d471628d FromAutoSDKShared78353984d471628dVariant1(global::Vercel.AutoSDKShared78353984d471628dVariant1? value) => new AutoSDKShared78353984d471628d(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared78353984d471628d(global::Vercel.AutoSDKShared238fc1521601aa81 value) => new AutoSDKShared78353984d471628d((global::Vercel.AutoSDKShared238fc1521601aa81?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared238fc1521601aa81?(AutoSDKShared78353984d471628d @this) => @this.Shared238fc1521601aa81;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78353984d471628d(global::Vercel.AutoSDKShared238fc1521601aa81? value)
        {
            Shared238fc1521601aa81 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared78353984d471628d FromShared238fc1521601aa81(global::Vercel.AutoSDKShared238fc1521601aa81? value) => new AutoSDKShared78353984d471628d(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared78353984d471628d(
            global::Vercel.AutoSDKShared78353984d471628dVariant1? autoSDKShared78353984d471628dVariant1,
            global::Vercel.AutoSDKShared238fc1521601aa81? shared238fc1521601aa81
            )
        {
            AutoSDKShared78353984d471628dVariant1 = autoSDKShared78353984d471628dVariant1;
            Shared238fc1521601aa81 = shared238fc1521601aa81;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared238fc1521601aa81 as object ??
            AutoSDKShared78353984d471628dVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKShared78353984d471628dVariant1?.ToString() ??
            Shared238fc1521601aa81?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKShared78353984d471628dVariant1 && !IsShared238fc1521601aa81 || !IsAutoSDKShared78353984d471628dVariant1 && IsShared238fc1521601aa81;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared78353984d471628dVariant1, TResult>? autoSDKShared78353984d471628dVariant1 = null,
            global::System.Func<global::Vercel.AutoSDKShared238fc1521601aa81, TResult>? shared238fc1521601aa81 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared78353984d471628dVariant1 && autoSDKShared78353984d471628dVariant1 != null)
            {
                return autoSDKShared78353984d471628dVariant1(AutoSDKShared78353984d471628dVariant1!);
            }
            else if (IsShared238fc1521601aa81 && shared238fc1521601aa81 != null)
            {
                return shared238fc1521601aa81(Shared238fc1521601aa81!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared78353984d471628dVariant1>? autoSDKShared78353984d471628dVariant1 = null,

            global::System.Action<global::Vercel.AutoSDKShared238fc1521601aa81>? shared238fc1521601aa81 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared78353984d471628dVariant1)
            {
                autoSDKShared78353984d471628dVariant1?.Invoke(AutoSDKShared78353984d471628dVariant1!);
            }
            else if (IsShared238fc1521601aa81)
            {
                shared238fc1521601aa81?.Invoke(Shared238fc1521601aa81!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared78353984d471628dVariant1>? autoSDKShared78353984d471628dVariant1 = null,
            global::System.Action<global::Vercel.AutoSDKShared238fc1521601aa81>? shared238fc1521601aa81 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared78353984d471628dVariant1)
            {
                autoSDKShared78353984d471628dVariant1?.Invoke(AutoSDKShared78353984d471628dVariant1!);
            }
            else if (IsShared238fc1521601aa81)
            {
                shared238fc1521601aa81?.Invoke(Shared238fc1521601aa81!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKShared78353984d471628dVariant1,
                typeof(global::Vercel.AutoSDKShared78353984d471628dVariant1),
                Shared238fc1521601aa81,
                typeof(global::Vercel.AutoSDKShared238fc1521601aa81),
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
        public bool Equals(AutoSDKShared78353984d471628d other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared78353984d471628dVariant1?>.Default.Equals(AutoSDKShared78353984d471628dVariant1, other.AutoSDKShared78353984d471628dVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared238fc1521601aa81?>.Default.Equals(Shared238fc1521601aa81, other.Shared238fc1521601aa81)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared78353984d471628d obj1, AutoSDKShared78353984d471628d obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared78353984d471628d>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared78353984d471628d obj1, AutoSDKShared78353984d471628d obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared78353984d471628d o && Equals(o);
        }
    }
}
