#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedc330b43ff6fc3599 : global::System.IEquatable<AutoSDKSharedc330b43ff6fc3599>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedd60af9eb328d9316? Sharedd60af9eb328d9316 { get; init; }
#else
        public global::Vercel.AutoSDKSharedd60af9eb328d9316? Sharedd60af9eb328d9316 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedd60af9eb328d9316))]
#endif
        public bool IsSharedd60af9eb328d9316 => Sharedd60af9eb328d9316 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedd60af9eb328d9316(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedd60af9eb328d9316? value)
        {
            value = Sharedd60af9eb328d9316;
            return IsSharedd60af9eb328d9316;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedd60af9eb328d9316 PickSharedd60af9eb328d9316() => Sharedd60af9eb328d9316 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedd60af9eb328d9316' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared5d941fd0946ddd47? Shared5d941fd0946ddd47 { get; init; }
#else
        public global::Vercel.AutoSDKShared5d941fd0946ddd47? Shared5d941fd0946ddd47 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared5d941fd0946ddd47))]
#endif
        public bool IsShared5d941fd0946ddd47 => Shared5d941fd0946ddd47 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared5d941fd0946ddd47(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared5d941fd0946ddd47? value)
        {
            value = Shared5d941fd0946ddd47;
            return IsShared5d941fd0946ddd47;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared5d941fd0946ddd47 PickShared5d941fd0946ddd47() => Shared5d941fd0946ddd47 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared5d941fd0946ddd47' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc330b43ff6fc3599(global::Vercel.AutoSDKSharedd60af9eb328d9316 value) => new AutoSDKSharedc330b43ff6fc3599((global::Vercel.AutoSDKSharedd60af9eb328d9316?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedd60af9eb328d9316?(AutoSDKSharedc330b43ff6fc3599 @this) => @this.Sharedd60af9eb328d9316;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc330b43ff6fc3599(global::Vercel.AutoSDKSharedd60af9eb328d9316? value)
        {
            Sharedd60af9eb328d9316 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc330b43ff6fc3599 FromSharedd60af9eb328d9316(global::Vercel.AutoSDKSharedd60af9eb328d9316? value) => new AutoSDKSharedc330b43ff6fc3599(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc330b43ff6fc3599(global::Vercel.AutoSDKShared5d941fd0946ddd47 value) => new AutoSDKSharedc330b43ff6fc3599((global::Vercel.AutoSDKShared5d941fd0946ddd47?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared5d941fd0946ddd47?(AutoSDKSharedc330b43ff6fc3599 @this) => @this.Shared5d941fd0946ddd47;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc330b43ff6fc3599(global::Vercel.AutoSDKShared5d941fd0946ddd47? value)
        {
            Shared5d941fd0946ddd47 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc330b43ff6fc3599 FromShared5d941fd0946ddd47(global::Vercel.AutoSDKShared5d941fd0946ddd47? value) => new AutoSDKSharedc330b43ff6fc3599(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc330b43ff6fc3599(
            global::Vercel.AutoSDKSharedd60af9eb328d9316? sharedd60af9eb328d9316,
            global::Vercel.AutoSDKShared5d941fd0946ddd47? shared5d941fd0946ddd47
            )
        {
            Sharedd60af9eb328d9316 = sharedd60af9eb328d9316;
            Shared5d941fd0946ddd47 = shared5d941fd0946ddd47;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared5d941fd0946ddd47 as object ??
            Sharedd60af9eb328d9316 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedd60af9eb328d9316?.ToString() ??
            Shared5d941fd0946ddd47?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedd60af9eb328d9316 && !IsShared5d941fd0946ddd47 || !IsSharedd60af9eb328d9316 && IsShared5d941fd0946ddd47;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedd60af9eb328d9316, TResult>? sharedd60af9eb328d9316 = null,
            global::System.Func<global::Vercel.AutoSDKShared5d941fd0946ddd47, TResult>? shared5d941fd0946ddd47 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd60af9eb328d9316 is { } __value0 && sharedd60af9eb328d9316 != null)
            {
                return sharedd60af9eb328d9316(__value0);
            }
            else if (Shared5d941fd0946ddd47 is { } __value1 && shared5d941fd0946ddd47 != null)
            {
                return shared5d941fd0946ddd47(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedd60af9eb328d9316>? sharedd60af9eb328d9316 = null,

            global::System.Action<global::Vercel.AutoSDKShared5d941fd0946ddd47>? shared5d941fd0946ddd47 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd60af9eb328d9316 is { } __value0)
            {
                sharedd60af9eb328d9316?.Invoke(__value0);
            }
            else if (Shared5d941fd0946ddd47 is { } __value1)
            {
                shared5d941fd0946ddd47?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedd60af9eb328d9316>? sharedd60af9eb328d9316 = null,
            global::System.Action<global::Vercel.AutoSDKShared5d941fd0946ddd47>? shared5d941fd0946ddd47 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedd60af9eb328d9316 is { } __value0)
            {
                sharedd60af9eb328d9316?.Invoke(__value0);
            }
            else if (Shared5d941fd0946ddd47 is { } __value1)
            {
                shared5d941fd0946ddd47?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedd60af9eb328d9316,
                typeof(global::Vercel.AutoSDKSharedd60af9eb328d9316),
                Shared5d941fd0946ddd47,
                typeof(global::Vercel.AutoSDKShared5d941fd0946ddd47),
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
        public bool Equals(AutoSDKSharedc330b43ff6fc3599 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedd60af9eb328d9316?>.Default.Equals(Sharedd60af9eb328d9316, other.Sharedd60af9eb328d9316) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared5d941fd0946ddd47?>.Default.Equals(Shared5d941fd0946ddd47, other.Shared5d941fd0946ddd47)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedc330b43ff6fc3599 obj1, AutoSDKSharedc330b43ff6fc3599 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedc330b43ff6fc3599>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedc330b43ff6fc3599 obj1, AutoSDKSharedc330b43ff6fc3599 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedc330b43ff6fc3599 o && Equals(o);
        }
    }
}
