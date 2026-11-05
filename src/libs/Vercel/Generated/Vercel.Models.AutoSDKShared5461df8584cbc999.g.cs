#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared5461df8584cbc999 : global::System.IEquatable<AutoSDKShared5461df8584cbc999>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>? Shared72e1b2fb4c47fe77 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>? Shared72e1b2fb4c47fe77 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared72e1b2fb4c47fe77))]
#endif
        public bool IsShared72e1b2fb4c47fe77 => Shared72e1b2fb4c47fe77 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared72e1b2fb4c47fe77(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>? value)
        {
            value = Shared72e1b2fb4c47fe77;
            return IsShared72e1b2fb4c47fe77;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10> PickShared72e1b2fb4c47fe77() => Shared72e1b2fb4c47fe77 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared72e1b2fb4c47fe77' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? AutoSDKShared5461df8584cbc999Variant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? AutoSDKShared5461df8584cbc999Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared5461df8584cbc999Variant2))]
#endif
        public bool IsAutoSDKShared5461df8584cbc999Variant2 => AutoSDKShared5461df8584cbc999Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared5461df8584cbc999Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? value)
        {
            value = AutoSDKShared5461df8584cbc999Variant2;
            return IsAutoSDKShared5461df8584cbc999Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22> PickAutoSDKShared5461df8584cbc999Variant2() => AutoSDKShared5461df8584cbc999Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared5461df8584cbc999Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared5461df8584cbc999(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22> value) => new AutoSDKShared5461df8584cbc999((global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>?(AutoSDKShared5461df8584cbc999 @this) => @this.AutoSDKShared5461df8584cbc999Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared5461df8584cbc999(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? value)
        {
            AutoSDKShared5461df8584cbc999Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared5461df8584cbc999 FromAutoSDKShared5461df8584cbc999Variant2(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? value) => new AutoSDKShared5461df8584cbc999(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared5461df8584cbc999(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>? shared72e1b2fb4c47fe77,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>? autoSDKShared5461df8584cbc999Variant2
            )
        {
            Shared72e1b2fb4c47fe77 = shared72e1b2fb4c47fe77;
            AutoSDKShared5461df8584cbc999Variant2 = autoSDKShared5461df8584cbc999Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared5461df8584cbc999Variant2 as object ??
            Shared72e1b2fb4c47fe77 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared72e1b2fb4c47fe77?.ToString() ??
            AutoSDKShared5461df8584cbc999Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared72e1b2fb4c47fe77 && !IsAutoSDKShared5461df8584cbc999Variant2 || !IsShared72e1b2fb4c47fe77 && IsAutoSDKShared5461df8584cbc999Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>, TResult>? shared72e1b2fb4c47fe77 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>, TResult>? autoSDKShared5461df8584cbc999Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared72e1b2fb4c47fe77 is { } __value0 && shared72e1b2fb4c47fe77 != null)
            {
                return shared72e1b2fb4c47fe77(__value0);
            }
            else if (AutoSDKShared5461df8584cbc999Variant2 is { } __value1 && autoSDKShared5461df8584cbc999Variant2 != null)
            {
                return autoSDKShared5461df8584cbc999Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>>? shared72e1b2fb4c47fe77 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>>? autoSDKShared5461df8584cbc999Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared72e1b2fb4c47fe77 is { } __value0)
            {
                shared72e1b2fb4c47fe77?.Invoke(__value0);
            }
            else if (AutoSDKShared5461df8584cbc999Variant2 is { } __value1)
            {
                autoSDKShared5461df8584cbc999Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>>? shared72e1b2fb4c47fe77 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>>? autoSDKShared5461df8584cbc999Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared72e1b2fb4c47fe77 is { } __value0)
            {
                shared72e1b2fb4c47fe77?.Invoke(__value0);
            }
            else if (AutoSDKShared5461df8584cbc999Variant2 is { } __value1)
            {
                autoSDKShared5461df8584cbc999Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared72e1b2fb4c47fe77,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>),
                AutoSDKShared5461df8584cbc999Variant2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>),
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
        public bool Equals(AutoSDKShared5461df8584cbc999 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede10df3c22a339c10>?>.Default.Equals(Shared72e1b2fb4c47fe77, other.Shared72e1b2fb4c47fe77) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5461df8584cbc999Variant22>?>.Default.Equals(AutoSDKShared5461df8584cbc999Variant2, other.AutoSDKShared5461df8584cbc999Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared5461df8584cbc999 obj1, AutoSDKShared5461df8584cbc999 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared5461df8584cbc999>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared5461df8584cbc999 obj1, AutoSDKShared5461df8584cbc999 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared5461df8584cbc999 o && Equals(o);
        }
    }
}
