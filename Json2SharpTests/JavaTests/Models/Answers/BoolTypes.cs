namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class BoolTypes
{
    public const string Input = """
        {
            "true_bool": true,
            "false_bool": false
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record BoolTypes(
            @JsonProperty("true_bool") boolean trueBool,
            @JsonProperty("false_bool") boolean falseBool
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        public record BoolTypes(
            boolean trueBool,
            boolean falseBool
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record BoolTypes(
            @JsonProperty("true_bool") boolean trueBool,
            @JsonProperty("false_bool") boolean falseBool
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class BoolTypes {
            private boolean trueBool;
            private boolean falseBool;

            @JsonProperty("true_bool")
            public boolean isTrueBool() { return trueBool; }
            public void setTrueBool(boolean v) { this.trueBool = v; }

            @JsonProperty("false_bool")
            public boolean isFalseBool() { return falseBool; }
            public void setFalseBool(boolean v) { this.falseBool = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        public final class BoolTypes {
            private boolean trueBool;
            private boolean falseBool;

            public boolean isTrueBool() { return trueBool; }
            public void setTrueBool(boolean v) { this.trueBool = v; }

            public boolean isFalseBool() { return falseBool; }
            public void setFalseBool(boolean v) { this.falseBool = v; }
        }
        """;
}
