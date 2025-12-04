namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class CustomHandleTypes
{
    public const string Input = """
        {
            "null_thing": null,
            "empty_thing": {},
            "thing": [
                {
                    "text": "hello world",
                    "number": 1,
                    "int_array": [ 1, 2, 3 ],
                    "prop_base:colon": 2,
                    "prop_custom:colon": { "blep": "nested" }
                }
            ]
        }
        """;

    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record CustomHandleTypes (
            @JsonProperty("null_thing") Object nullThing,
            @JsonProperty("empty_thing") Object emptyThing,
            @JsonProperty("thing") Thing[] thing
        );
        
        public record Thing(
            @JsonProperty("text") String text,
            @JsonProperty("number") int number,
            @JsonProperty("int_array") int[] intArray,
            @JsonProperty("prop_base:colon") int propBaseColon,
            @JsonProperty("prop_custom:colon") PropCustomColon propCustomColon
        );

        public record PropCustomColon(
            @JsonProperty("blep") String blep
        );
        """;

    public const string RecordPrimaryCtorOutputNoAtt = """
        public record CustomHandleTypes (
            Object nullThing,
            Object emptyThing,
            Thing[] thing
        );
        
        public record Thing(
            String text,
            int number,
            int[] intArray,
            int propBaseColon,
            PropCustomColon propCustomColon
        );
        
        public record PropCustomColon(
            String blep
        );
        """;

    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        
        public final class CustomHandleTypes
        {
            private Object nullThing;
            
            @JsonProperty("null_thing")
            public Object getNullThing() {
                return this.nullThing;
            }
            
            public void setNullThing(Object nullThing) {
                this.nullThing = nullThing;
            }
            
            private Object emptyThing;
            
            @JsonProperty("empty_thing")
            public Object getEmptyThing() {
                return this.emptyThing;
            }
             
            public void setEmptyThing(Object emptyThing) {
                this.emptyThing = emptyThing;
            }   
            
            private Thing[] thing;
            
            @JsonProperty("thing") 
            public Thing[] getThing() {
                return this.thing;
            }
            
            public void setThing(Thing[] thing) {
                this.thing = thing;
            }
        }

        public final class Thing
        {
            private String text;
        
            @JsonProperty("text")
            public String getText() {
                return this.text;
            }
        
            public void setText(String text) {
                this.text = text;
            }
        
            private int number;
        
            @JsonProperty("number")
            public int getNumber() {
                return number;
            }
        
            public void setNumber(int number) {
                this.number = number;
            }
        
            private int[] intArray;
        
            @JsonProperty("int_array")
            public int[] getIntArray() {
                return intArray;
            }
        
            public void setIntArray(int[] intArray) {
                this.intArray = intArray;
            }
        
            private int propBaseColon;
        
            @JsonProperty("prop_base:colon")
            public int getPropBaseColon() {
                return propBaseColon;
            }
        
            public void setPropBaseColon(int propBaseColon) {
                this.propBaseColon = propBaseColon;
            }
        
            private PropCustomColon propCustomColon;
        
            @JsonProperty("prop_custom:colon")
            public PropCustomColon getPropCustomColon() {
                return propCustomColon;
            }
        
            public void setPropCustomColon(PropCustomColon propCustomColon) {
                this.propCustomColon = propCustomColon;
            }
        }

        public final class PropCustomColon {
        
            private String blep;
        
            @JsonProperty("blep")
            public String getBlep() {
                return blep;
            }
        
            public void setBlep(String blep) {
                this.blep = blep;
            }
        }
        """;

    public const string ClassOutputNoAtt = """
        public final class CustomHandleTypes
        {
            private Object nullThing;
            
            public Object getNullThing() {
                return this.nullThing;
            }
            
            public void setNullThing(Object nullThing) {
                this.nullThing = nullThing;
            }
            
            private Object emptyThing;
            
            public Object getEmptyThing() {
                return this.emptyThing;
            }
             
            public void setEmptyThing(Object emptyThing) {
                this.emptyThing = emptyThing;
            }   
            
            private Thing[] thing;
            
            public Thing[] getThing() {
                return this.thing;
            }
            
            public void setThing(Thing[] thing) {
                this.thing = thing;
            }
        }

        public final class Thing
        {
            private String text;
        
            public String getText() {
                return this.text;
            }
        
            public void setText(String text) {
                this.text = text;
            }
        
            private int number;
        
            public int getNumber() {
                return number;
            }
        
            public void setNumber(int number) {
                this.number = number;
            }
        
            private int[] intArray;
        
            public int[] getIntArray() {
                return intArray;
            }
        
            public void setIntArray(int[] intArray) {
                this.intArray = intArray;
            }
        
            private int propBaseColon;
        
            public int getPropBaseColon() {
                return propBaseColon;
            }
        
            public void setPropBaseColon(int propBaseColon) {
                this.propBaseColon = propBaseColon;
            }
        
            private PropCustomColon propCustomColon;
        
            public PropCustomColon getPropCustomColon() {
                return propCustomColon;
            }
        
            public void setPropCustomColon(PropCustomColon propCustomColon) {
                this.propCustomColon = propCustomColon;
            }
        }
        
        public final class PropCustomColon {
        
            private String blep;
        
            public String getBlep() {
                return blep;
            }
        
            public void setBlep(String blep) {
                this.blep = blep;
            }
        }
        """;
}