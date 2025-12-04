namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class IntegerTypes
{
    public const string Input = """
        {
            "int_number": 2147483647,
            "uint_number": 2147483648,
            "long_number": 4294967296,
            "ulong_number": 9223372036854775808
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigInteger;

        public record IntegerTypes(
            @JsonProperty("int_number") int intNumber,
            @JsonProperty("uint_number") long uintNumber,
            @JsonProperty("long_number") long longNumber,
            @JsonProperty("ulong_number") BigInteger ulongNumber
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        import java.math.BigInteger;

        public record IntegerTypes(
            int intNumber,
            long uintNumber,
            long longNumber,
            BigInteger ulongNumber
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigInteger;

        public record IntegerTypes(
            @JsonProperty("int_number") int intNumber,
            @JsonProperty("uint_number") long uintNumber,
            @JsonProperty("long_number") long longNumber,
            @JsonProperty("ulong_number") BigInteger ulongNumber
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigInteger;

        public final class IntegerTypes {
            private int intNumber;
            private long uintNumber;
            private long longNumber;
            private BigInteger ulongNumber;

            @JsonProperty("int_number")
            public int getIntNumber() { return intNumber; }
            public void setIntNumber(int v) { this.intNumber = v; }

            @JsonProperty("uint_number")
            public long getUintNumber() { return uintNumber; }
            public void setUintNumber(long v) { this.uintNumber = v; }

            @JsonProperty("long_number")
            public long getLongNumber() { return longNumber; }
            public void setLongNumber(long v) { this.longNumber = v; }

            @JsonProperty("ulong_number")
            public BigInteger getUlongNumber() { return ulongNumber; }
            public void setUlongNumber(BigInteger v) { this.ulongNumber = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        import java.math.BigInteger;

        public final class IntegerTypes {
            private int intNumber;
            private long uintNumber;
            private long longNumber;
            private BigInteger ulongNumber;

            public int getIntNumber() { return intNumber; }
            public void setIntNumber(int v) { this.intNumber = v; }

            public long getUintNumber() { return uintNumber; }
            public void setUintNumber(long v) { this.uintNumber = v; }

            public long getLongNumber() { return longNumber; }
            public void setLongNumber(long v) { this.longNumber = v; }

            public BigInteger getUlongNumber() { return ulongNumber; }
            public void setUlongNumber(BigInteger v) { this.ulongNumber = v; }
        }
        """;

    // C# readonly struct → Java final immutable class (ctor + getters)
    public const string StructOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigInteger;

        public final class IntegerTypes {
            private final int intNumber;
            private final long uintNumber;
            private final long longNumber;
            private final BigInteger ulongNumber;

            public IntegerTypes(
                @JsonProperty("int_number") int intNumber,
                @JsonProperty("uint_number") long uintNumber,
                @JsonProperty("long_number") long longNumber,
                @JsonProperty("ulong_number") BigInteger ulongNumber
            ) {
                this.intNumber = intNumber;
                this.uintNumber = uintNumber;
                this.longNumber = longNumber;
                this.ulongNumber = ulongNumber;
            }

            @JsonProperty("int_number")
            public int getIntNumber() { return intNumber; }

            @JsonProperty("uint_number")
            public long getUintNumber() { return uintNumber; }

            @JsonProperty("long_number")
            public long getLongNumber() { return longNumber; }

            @JsonProperty("ulong_number")
            public BigInteger getUlongNumber() { return ulongNumber; }
        }
        """;
}
