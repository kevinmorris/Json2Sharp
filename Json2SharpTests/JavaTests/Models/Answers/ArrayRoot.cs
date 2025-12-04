namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class ArrayRoot
{
    public const string Input = """
        [
            { "id": 1 },
            { "id": 2 },
            { "id": 3 },
            { "id": 4 },
            { "id": 5 }
        ]
        """;

    public const string BadInput1 = """
        [
            { "id": 1 },
            { "number": 1 }
        ]
        """;

    public const string BadInput2 = """
        [
            { "id": 1 },
            { "name": "blep" }
        ]
        """;

    public const string BadInput3 = """
        [
            { "id": 1 },
            null
        ]
        """;

    public const string BadInput4 = "[]";

    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ArrayRoot(
            @JsonProperty("id") int id
        ) { }
        """;

    public const string RecordPrimaryCtorOutputNoAtt = """
        public record ArrayRoot(
            int id
        ) { }
        """;

    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ArrayRoot(
            @JsonProperty("id") int id
        ) { }
        """;

    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class ArrayRoot {
            private int id;

            @JsonProperty("id")
            public int getId() { return id; }

            public void setId(int id) { this.id = id; }
        }
        """;

    public const string ClassOutputNoAtt = """
        public final class ArrayRoot {
            private int id;

            public int getId() { return id; }

            public void setId(int id) { this.id = id; }
        }
        """;
}
