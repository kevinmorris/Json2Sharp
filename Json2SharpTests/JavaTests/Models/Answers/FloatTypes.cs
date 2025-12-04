namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class FloatTypes
{
    public const string Input = """
    {
        "float_number": 3.4028235E+38,
        "double_number": 1.7976931348623157E+308,
        "decimal_number": 7.9228162514264337593543950335
    }
    """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record FloatTypes(
          @JsonProperty("float_number") float floatNumber,
          @JsonProperty("double_number") double doubleNumber,
          @JsonProperty("decimal_number") java.math.BigDecimal decimalNumber
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        public record FloatTypes(
           float floatNumber,
           double doubleNumber,
           java.math.BigDecimal decimalNumber
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record FloatTypes(
           @JsonProperty("float_number") float floatNumber,
           @JsonProperty("double_number") double doubleNumber,
           @JsonProperty("decimal_number") java.math.BigDecimal decimalNumber
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigDecimal;

        public final class FloatTypes {
          private float floatNumber;
          private double doubleNumber;
          private BigDecimal decimalNumber;

          @JsonProperty("float_number")
          public float getFloatNumber() { return floatNumber; }
          public void setFloatNumber(float v) { this.floatNumber = v; }

          @JsonProperty("double_number")
          public double getDoubleNumber() { return doubleNumber; }
          public void setDoubleNumber(double v) { this.doubleNumber = v; }

          @JsonProperty("decimal_number")
          public BigDecimal getDecimalNumber() { return decimalNumber; }
          public void setDecimalNumber(BigDecimal v) { this.decimalNumber = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        import java.math.BigDecimal;

        public final class FloatTypes {
           private float floatNumber;
           private double doubleNumber;
           private BigDecimal decimalNumber;

           public float getFloatNumber() { return floatNumber; }
           public void setFloatNumber(float v) { this.floatNumber = v; }

           public double getDoubleNumber() { return doubleNumber; }
           public void setDoubleNumber(double v) { this.doubleNumber = v; }

           public BigDecimal getDecimalNumber() { return decimalNumber; }
           public void setDecimalNumber(BigDecimal v) { this.decimalNumber = v; }
        }
        """;

    // C# readonly struct → Java final immutable class (ctor + getters)
    public const string StructOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.math.BigDecimal;

        public final class FloatTypes {
           private final float floatNumber;
           private final double doubleNumber;
           private final BigDecimal decimalNumber;

           public FloatTypes(
               @JsonProperty("float_number") float floatNumber,
               @JsonProperty("double_number") double doubleNumber,
               @JsonProperty("decimal_number") BigDecimal decimalNumber
           ) {
               this.floatNumber = floatNumber;
               this.doubleNumber = doubleNumber;
               this.decimalNumber = decimalNumber;
           }

           @JsonProperty("float_number")
           public float getFloatNumber() { return floatNumber; }

           @JsonProperty("double_number")
           public double getDoubleNumber() { return doubleNumber; }

           @JsonProperty("decimal_number")
           public BigDecimal getDecimalNumber() { return decimalNumber; }
        }
        """;
}