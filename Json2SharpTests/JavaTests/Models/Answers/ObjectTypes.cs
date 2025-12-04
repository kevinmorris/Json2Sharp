namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class ObjectTypes
{
    public const string Input = """
        {
            "null_thing": null,
            "empty_thing": {},
            "thing": {
                "text": "hello world",
                "number": 1,
                "int_array": [ 1, 2, 3 ],
                "prop_base:colon": 2,
                "prop_custom:colon": { "blep": "nested" }
            }
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ObjectTypes(
            @JsonProperty("null_thing") Object nullThing,
            @JsonProperty("empty_thing") Object emptyThing,
            @JsonProperty("thing") Thing thing
        ) { }

        public record Thing(
            @JsonProperty("text") String text,
            @JsonProperty("number") int number,
            @JsonProperty("int_array") int[] intArray,
            @JsonProperty("prop_base:colon") int propBaseColon,
            @JsonProperty("prop_custom:colon") PropCustomColon propCustomColon
        ) { }

        public record PropCustomColon(
            @JsonProperty("blep") String blep
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        public record ObjectTypes(
            Object nullThing,
            Object emptyThing,
            Thing thing
        ) { }

        public record Thing(
            String text,
            int number,
            int[] intArray,
            int propBaseColon,
            PropCustomColon propCustomColon
        ) { }

        public record PropCustomColon(
            String blep
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ObjectTypes(
            @JsonProperty("null_thing") Object nullThing,
            @JsonProperty("empty_thing") Object emptyThing,
            @JsonProperty("thing") Thing thing
        ) { }

        public record Thing(
            @JsonProperty("text") String text,
            @JsonProperty("number") int number,
            @JsonProperty("int_array") int[] intArray,
            @JsonProperty("prop_base:colon") int propBaseColon,
            @JsonProperty("prop_custom:colon") PropCustomColon propCustomColon
        ) { }

        public record PropCustomColon(
            @JsonProperty("blep") String blep
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class ObjectTypes {
            private Object nullThing;
            private Object emptyThing;
            private Thing thing;

            @JsonProperty("null_thing")
            public Object getNullThing() { return nullThing; }
            public void setNullThing(Object v) { this.nullThing = v; }

            @JsonProperty("empty_thing")
            public Object getEmptyThing() { return emptyThing; }
            public void setEmptyThing(Object v) { this.emptyThing = v; }

            @JsonProperty("thing")
            public Thing getThing() { return thing; }
            public void setThing(Thing v) { this.thing = v; }
        }

        public final class Thing {
            private String text;
            private int number;
            private int[] intArray;
            private int propBaseColon;
            private PropCustomColon propCustomColon;

            @JsonProperty("text")
            public String getText() { return text; }
            public void setText(String v) { this.text = v; }

            @JsonProperty("number")
            public int getNumber() { return number; }
            public void setNumber(int v) { this.number = v; }

            @JsonProperty("int_array")
            public int[] getIntArray() { return intArray; }
            public void setIntArray(int[] v) { this.intArray = v; }

            @JsonProperty("prop_base:colon")
            public int getPropBaseColon() { return propBaseColon; }
            public void setPropBaseColon(int v) { this.propBaseColon = v; }

            @JsonProperty("prop_custom:colon")
            public PropCustomColon getPropCustomColon() { return propCustomColon; }
            public void setPropCustomColon(PropCustomColon v) { this.propCustomColon = v; }
        }

        public final class PropCustomColon {
            private String blep;

            @JsonProperty("blep")
            public String getBlep() { return blep; }
            public void setBlep(String v) { this.blep = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        public final class ObjectTypes {
            private Object nullThing;
            private Object emptyThing;
            private Thing thing;

            public Object getNullThing() { return nullThing; }
            public void setNullThing(Object v) { this.nullThing = v; }

            public Object getEmptyThing() { return emptyThing; }
            public void setEmptyThing(Object v) { this.emptyThing = v; }

            public Thing getThing() { return thing; }
            public void setThing(Thing v) { this.thing = v; }
        }

        public final class Thing {
            private String text;
            private int number;
            private int[] intArray;
            private int propBaseColon;
            private PropCustomColon propCustomColon;

            public String getText() { return text; }
            public void setText(String v) { this.text = v; }

            public int getNumber() { return number; }
            public void setNumber(int v) { this.number = v; }

            public int[] getIntArray() { return intArray; }
            public void setIntArray(int[] v) { this.intArray = v; }

            public int getPropBaseColon() { return propBaseColon; }
            public void setPropBaseColon(int v) { this.propBaseColon = v; }

            public PropCustomColon getPropCustomColon() { return propCustomColon; }
            public void setPropCustomColon(PropCustomColon v) { this.propCustomColon = v; }
        }

        public final class PropCustomColon {
            private String blep;

            public String getBlep() { return blep; }
            public void setBlep(String v) { this.blep = v; }
        }
        """;

    // C# readonly struct → Java final immutable classes (ctor + getters)
    public const string StructOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class ObjectTypes {
            private final Object nullThing;
            private final Object emptyThing;
            private final Thing thing;

            public ObjectTypes(
                @JsonProperty("null_thing") Object nullThing,
                @JsonProperty("empty_thing") Object emptyThing,
                @JsonProperty("thing") Thing thing
            ) {
                this.nullThing = nullThing;
                this.emptyThing = emptyThing;
                this.thing = thing;
            }

            @JsonProperty("null_thing")
            public Object getNullThing() { return nullThing; }

            @JsonProperty("empty_thing")
            public Object getEmptyThing() { return emptyThing; }

            @JsonProperty("thing")
            public Thing getThing() { return thing; }
        }

        public final class Thing {
            private final String text;
            private final int number;
            private final int[] intArray;
            private final int propBaseColon;
            private final PropCustomColon propCustomColon;

            public Thing(
                @JsonProperty("text") String text,
                @JsonProperty("number") int number,
                @JsonProperty("int_array") int[] intArray,
                @JsonProperty("prop_base:colon") int propBaseColon,
                @JsonProperty("prop_custom:colon") PropCustomColon propCustomColon
            ) {
                this.text = text;
                this.number = number;
                this.intArray = intArray;
                this.propBaseColon = propBaseColon;
                this.propCustomColon = propCustomColon;
            }

            @JsonProperty("text")
            public String getText() { return text; }

            @JsonProperty("number")
            public int getNumber() { return number; }

            @JsonProperty("int_array")
            public int[] getIntArray() { return intArray; }

            @JsonProperty("prop_base:colon")
            public int getPropBaseColon() { return propBaseColon; }

            @JsonProperty("prop_custom:colon")
            public PropCustomColon getPropCustomColon() { return propCustomColon; }
        }

        public final class PropCustomColon {
            private final String blep;

            public PropCustomColon(@JsonProperty("blep") String blep) {
                this.blep = blep;
            }

            @JsonProperty("blep")
            public String getBlep() { return blep; }
        }
        """;
}
