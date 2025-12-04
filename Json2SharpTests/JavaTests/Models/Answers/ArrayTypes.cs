namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class ArrayTypes
{
    public const string Input = """
        {
            "empty_array": [],
            "int_array": [ 1, 2, 3 ],
            "nullable_int_array" : [ 1, 2, null ],
            "float_array": [ 1.0, 2.0, 3.0 ],
            "nullable_float_array" : [ 1.0, 2.0, null ],
            "string_array": [ "a", "b", "c" ],
            "nullable_string_array": [ "a", "b", null ],
            "mixed_array": [ 1, "a", 2.1 ],
            "nullable_mixed_array": [ 1, "a", 2.1, null ],
            "thing_array": [ { "text": "hello" } ],
            "nullable_thing_array": [ { "text": "hello" }, null ],
            "null_array": [ null ],
            "objects_array": [
                { "text": "hello" },
                { "id": 1 }
            ],
            "nullable_objects_array": [
                { "text": "hello" },
                { "id": 1 },
                null
            ]
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ArrayTypes(
            @JsonProperty("empty_array") Object[] emptyArray,
            @JsonProperty("int_array") int[] intArray,
            @JsonProperty("nullable_int_array") Integer[] nullableIntArray,
            @JsonProperty("float_array") float[] floatArray,
            @JsonProperty("nullable_float_array") Float[] nullableFloatArray,
            @JsonProperty("string_array") String[] stringArray,
            @JsonProperty("nullable_string_array") String[] nullableStringArray,
            @JsonProperty("mixed_array") Object[] mixedArray,
            @JsonProperty("nullable_mixed_array") Object[] nullableMixedArray,
            @JsonProperty("thing_array") ThingArray[] thingArray,
            @JsonProperty("nullable_thing_array") NullableThingArray[] nullableThingArray,
            @JsonProperty("null_array") Object[] nullArray,
            @JsonProperty("objects_array") Object[] objectsArray,
            @JsonProperty("nullable_objects_array") Object[] nullableObjectsArray
        ) { }

        public record ThingArray(
            @JsonProperty("text") String text
        ) { }

        public record NullableThingArray(
            @JsonProperty("text") String text
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        public record ArrayTypes(
            Object[] emptyArray,
            int[] intArray,
            Integer[] nullableIntArray,
            float[] floatArray,
            Float[] nullableFloatArray,
            String[] stringArray,
            String[] nullableStringArray,
            Object[] mixedArray,
            Object[] nullableMixedArray,
            ThingArray[] thingArray,
            NullableThingArray[] nullableThingArray,
            Object[] nullArray,
            Object[] objectsArray,
            Object[] nullableObjectsArray
        ) { }

        public record ThingArray(
            String text
        ) { }

        public record NullableThingArray(
            String text
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record ArrayTypes(
            @JsonProperty("empty_array") Object[] emptyArray,
            @JsonProperty("int_array") int[] intArray,
            @JsonProperty("nullable_int_array") Integer[] nullableIntArray,
            @JsonProperty("float_array") float[] floatArray,
            @JsonProperty("nullable_float_array") Float[] nullableFloatArray,
            @JsonProperty("string_array") String[] stringArray,
            @JsonProperty("nullable_string_array") String[] nullableStringArray,
            @JsonProperty("mixed_array") Object[] mixedArray,
            @JsonProperty("nullable_mixed_array") Object[] nullableMixedArray,
            @JsonProperty("thing_array") ThingArray[] thingArray,
            @JsonProperty("nullable_thing_array") NullableThingArray[] nullableThingArray,
            @JsonProperty("null_array") Object[] nullArray,
            @JsonProperty("objects_array") Object[] objectsArray,
            @JsonProperty("nullable_objects_array") Object[] nullableObjectsArray
        ) { }

        public record ThingArray(
            @JsonProperty("text") String text
        ) { }

        public record NullableThingArray(
            @JsonProperty("text") String text
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class ArrayTypes {
            private Object[] emptyArray;
            private int[] intArray;
            private Integer[] nullableIntArray;
            private float[] floatArray;
            private Float[] nullableFloatArray;
            private String[] stringArray;
            private String[] nullableStringArray;
            private Object[] mixedArray;
            private Object[] nullableMixedArray;
            private ThingArray[] thingArray;
            private NullableThingArray[] nullableThingArray;
            private Object[] nullArray;
            private Object[] objectsArray;
            private Object[] nullableObjectsArray;

            @JsonProperty("empty_array") public Object[] getEmptyArray() { return emptyArray; }
            public void setEmptyArray(Object[] v) { this.emptyArray = v; }

            @JsonProperty("int_array") public int[] getIntArray() { return intArray; }
            public void setIntArray(int[] v) { this.intArray = v; }

            @JsonProperty("nullable_int_array") public Integer[] getNullableIntArray() { return nullableIntArray; }
            public void setNullableIntArray(Integer[] v) { this.nullableIntArray = v; }

            @JsonProperty("float_array") public float[] getFloatArray() { return floatArray; }
            public void setFloatArray(float[] v) { this.floatArray = v; }

            @JsonProperty("nullable_float_array") public Float[] getNullableFloatArray() { return nullableFloatArray; }
            public void setNullableFloatArray(Float[] v) { this.nullableFloatArray = v; }

            @JsonProperty("string_array") public String[] getStringArray() { return stringArray; }
            public void setStringArray(String[] v) { this.stringArray = v; }

            @JsonProperty("nullable_string_array") public String[] getNullableStringArray() { return nullableStringArray; }
            public void setNullableStringArray(String[] v) { this.nullableStringArray = v; }

            @JsonProperty("mixed_array") public Object[] getMixedArray() { return mixedArray; }
            public void setMixedArray(Object[] v) { this.mixedArray = v; }

            @JsonProperty("nullable_mixed_array") public Object[] getNullableMixedArray() { return nullableMixedArray; }
            public void setNullableMixedArray(Object[] v) { this.nullableMixedArray = v; }

            @JsonProperty("thing_array") public ThingArray[] getThingArray() { return thingArray; }
            public void setThingArray(ThingArray[] v) { this.thingArray = v; }

            @JsonProperty("nullable_thing_array") public NullableThingArray[] getNullableThingArray() { return nullableThingArray; }
            public void setNullableThingArray(NullableThingArray[] v) { this.nullableThingArray = v; }

            @JsonProperty("null_array") public Object[] getNullArray() { return nullArray; }
            public void setNullArray(Object[] v) { this.nullArray = v; }

            @JsonProperty("objects_array") public Object[] getObjectsArray() { return objectsArray; }
            public void setObjectsArray(Object[] v) { this.objectsArray = v; }

            @JsonProperty("nullable_objects_array") public Object[] getNullableObjectsArray() { return nullableObjectsArray; }
            public void setNullableObjectsArray(Object[] v) { this.nullableObjectsArray = v; }
        }

        public final class ThingArray {
            private String text;
            @JsonProperty("text") public String getText() { return text; }
            public void setText(String t) { this.text = t; }
        }

        public final class NullableThingArray {
            private String text;
            @JsonProperty("text") public String getText() { return text; }
            public void setText(String t) { this.text = t; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        public final class ArrayTypes {
            private Object[] emptyArray;
            private int[] intArray;
            private Integer[] nullableIntArray;
            private float[] floatArray;
            private Float[] nullableFloatArray;
            private String[] stringArray;
            private String[] nullableStringArray;
            private Object[] mixedArray;
            private Object[] nullableMixedArray;
            private ThingArray[] thingArray;
            private NullableThingArray[] nullableThingArray;
            private Object[] nullArray;
            private Object[] objectsArray;
            private Object[] nullableObjectsArray;

            public Object[] getEmptyArray() { return emptyArray; }
            public void setEmptyArray(Object[] v) { this.emptyArray = v; }

            public int[] getIntArray() { return intArray; }
            public void setIntArray(int[] v) { this.intArray = v; }

            public Integer[] getNullableIntArray() { return nullableIntArray; }
            public void setNullableIntArray(Integer[] v) { this.nullableIntArray = v; }

            public float[] getFloatArray() { return floatArray; }
            public void setFloatArray(float[] v) { this.floatArray = v; }

            public Float[] getNullableFloatArray() { return nullableFloatArray; }
            public void setNullableFloatArray(Float[] v) { this.nullableFloatArray = v; }

            public String[] getStringArray() { return stringArray; }
            public void setStringArray(String[] v) { this.stringArray = v; }

            public String[] getNullableStringArray() { return nullableStringArray; }
            public void setNullableStringArray(String[] v) { this.nullableStringArray = v; }

            public Object[] getMixedArray() { return mixedArray; }
            public void setMixedArray(Object[] v) { this.mixedArray = v; }

            public Object[] getNullableMixedArray() { return nullableMixedArray; }
            public void setNullableMixedArray(Object[] v) { this.nullableMixedArray = v; }

            public ThingArray[] getThingArray() { return thingArray; }
            public void setThingArray(ThingArray[] v) { this.thingArray = v; }

            public NullableThingArray[] getNullableThingArray() { return nullableThingArray; }
            public void setNullableThingArray(NullableThingArray[] v) { this.nullableThingArray = v; }

            public Object[] getNullArray() { return nullArray; }
            public void setNullArray(Object[] v) { this.nullArray = v; }

            public Object[] getObjectsArray() { return objectsArray; }
            public void setObjectsArray(Object[] v) { this.objectsArray = v; }

            public Object[] getNullableObjectsArray() { return nullableObjectsArray; }
            public void setNullableObjectsArray(Object[] v) { this.nullableObjectsArray = v; }
        }

        public final class ThingArray {
            private String text;
            public String getText() { return text; }
            public void setText(String t) { this.text = t; }
        }

        public final class NullableThingArray {
            private String text;
            public String getText() { return text; }
            public void setText(String t) { this.text = t; }
        }
        """;
}
