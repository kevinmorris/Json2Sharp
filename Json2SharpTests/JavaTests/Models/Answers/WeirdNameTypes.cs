namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class WeirdNameTypes
{
    public const string Input = """
        {
            "snake_case": 1,
            "camelCase": 2,
            "PascalCase": 3,
            "SCREAMINGCASE": 4,
            "SCREAMING_SNAKE": 5,
            "kebab-case": 6,
            "Pascal_Snake": 7,
            "snake_case:colon": 8,
            "camelCase:colon": 9,
            "PascalCase:Colon": 10,
            "SCREAMINGCASE:COLON": 11,
            "SCREAMING_SNAKE:COLON": 12,
            "kebab-case:colon": 13,
            "Pascal_Snake:Colon": 14,
            "colon:object": {
                "normal_prop": 15,
                "nested:colon": 16
            },
            "snake.dot": 17,
            "snake@at": 18,
            "snake#hash": 19,
            "snake$dollar": 20,
            "snake%percentage": 21,
            "snake&ampersand": 22,
            "snake*asterisk": 23
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record WeirdNameTypes(
            @JsonProperty("snake_case") int snakeCase,
            @JsonProperty("camelCase") int camelCase,
            @JsonProperty("PascalCase") int pascalCase,
            @JsonProperty("SCREAMINGCASE") int screamingcase,
            @JsonProperty("SCREAMING_SNAKE") int screamingSnake,
            @JsonProperty("kebab-case") int kebabCase,
            @JsonProperty("Pascal_Snake") int pascalSnake,
            @JsonProperty("snake_case:colon") int snakeCaseColon,
            @JsonProperty("camelCase:colon") int camelCaseColon,
            @JsonProperty("PascalCase:Colon") int pascalCaseColon,
            @JsonProperty("SCREAMINGCASE:COLON") int screamingcaseColon,
            @JsonProperty("SCREAMING_SNAKE:COLON") int screamingSnakeColon,
            @JsonProperty("kebab-case:colon") int kebabCaseColon,
            @JsonProperty("Pascal_Snake:Colon") int pascalSnakeColon,
            @JsonProperty("colon:object") ColonObject colonObject,
            @JsonProperty("snake.dot") int snakeDot,
            @JsonProperty("snake@at") int snakeAt,
            @JsonProperty("snake#hash") int snakeHash,
            @JsonProperty("snake$dollar") int snakeDollar,
            @JsonProperty("snake%percentage") int snakePercentage,
            @JsonProperty("snake&ampersand") int snakeAmpersand,
            @JsonProperty("snake*asterisk") int snakeAsterisk
        ) { }

        public record ColonObject(
            @JsonProperty("normal_prop") int normalProp,
            @JsonProperty("nested:colon") int nestedColon
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        public record WeirdNameTypes(
            int snakeCase,
            int camelCase,
            int pascalCase,
            int screamingcase,
            int screamingSnake,
            int kebabCase,
            int pascalSnake,
            int snakeCaseColon,
            int camelCaseColon,
            int pascalCaseColon,
            int screamingcaseColon,
            int screamingSnakeColon,
            int kebabCaseColon,
            int pascalSnakeColon,
            ColonObject colonObject,
            int snakeDot,
            int snakeAt,
            int snakeHash,
            int snakeDollar,
            int snakePercentage,
            int snakeAmpersand,
            int snakeAsterisk
        ) { }

        public record ColonObject(
            int normalProp,
            int nestedColon
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public record WeirdNameTypes(
            @JsonProperty("snake_case") int snakeCase,
            @JsonProperty("camelCase") int camelCase,
            @JsonProperty("PascalCase") int pascalCase,
            @JsonProperty("SCREAMINGCASE") int screamingcase,
            @JsonProperty("SCREAMING_SNAKE") int screamingSnake,
            @JsonProperty("kebab-case") int kebabCase,
            @JsonProperty("Pascal_Snake") int pascalSnake,
            @JsonProperty("snake_case:colon") int snakeCaseColon,
            @JsonProperty("camelCase:colon") int camelCaseColon,
            @JsonProperty("PascalCase:Colon") int pascalCaseColon,
            @JsonProperty("SCREAMINGCASE:COLON") int screamingcaseColon,
            @JsonProperty("SCREAMING_SNAKE:COLON") int screamingSnakeColon,
            @JsonProperty("kebab-case:colon") int kebabCaseColon,
            @JsonProperty("Pascal_Snake:Colon") int pascalSnakeColon,
            @JsonProperty("colon:object") ColonObject colonObject,
            @JsonProperty("snake.dot") int snakeDot,
            @JsonProperty("snake@at") int snakeAt,
            @JsonProperty("snake#hash") int snakeHash,
            @JsonProperty("snake$dollar") int snakeDollar,
            @JsonProperty("snake%percentage") int snakePercentage,
            @JsonProperty("snake&ampersand") int snakeAmpersand,
            @JsonProperty("snake*asterisk") int snakeAsterisk
        ) { }

        public record ColonObject(
            @JsonProperty("normal_prop") int normalProp,
            @JsonProperty("nested:colon") int nestedColon
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class WeirdNameTypes {
            private int snakeCase;
            private int camelCase;
            private int pascalCase;
            private int screamingcase;
            private int screamingSnake;
            private int kebabCase;
            private int pascalSnake;
            private int snakeCaseColon;
            private int camelCaseColon;
            private int pascalCaseColon;
            private int screamingcaseColon;
            private int screamingSnakeColon;
            private int kebabCaseColon;
            private int pascalSnakeColon;
            private ColonObject colonObject;
            private int snakeDot;
            private int snakeAt;
            private int snakeHash;
            private int snakeDollar;
            private int snakePercentage;
            private int snakeAmpersand;
            private int snakeAsterisk;

            @JsonProperty("snake_case") public int getSnakeCase() { return snakeCase; }
            public void setSnakeCase(int v) { this.snakeCase = v; }

            @JsonProperty("camelCase") public int getCamelCase() { return camelCase; }
            public void setCamelCase(int v) { this.camelCase = v; }

            @JsonProperty("PascalCase") public int getPascalCase() { return pascalCase; }
            public void setPascalCase(int v) { this.pascalCase = v; }

            @JsonProperty("SCREAMINGCASE") public int getScreamingcase() { return screamingcase; }
            public void setScreamingcase(int v) { this.screamingcase = v; }

            @JsonProperty("SCREAMING_SNAKE") public int getScreamingSnake() { return screamingSnake; }
            public void setScreamingSnake(int v) { this.screamingSnake = v; }

            @JsonProperty("kebab-case") public int getKebabCase() { return kebabCase; }
            public void setKebabCase(int v) { this.kebabCase = v; }

            @JsonProperty("Pascal_Snake") public int getPascalSnake() { return pascalSnake; }
            public void setPascalSnake(int v) { this.pascalSnake = v; }

            @JsonProperty("snake_case:colon") public int getSnakeCaseColon() { return snakeCaseColon; }
            public void setSnakeCaseColon(int v) { this.snakeCaseColon = v; }

            @JsonProperty("camelCase:colon") public int getCamelCaseColon() { return camelCaseColon; }
            public void setCamelCaseColon(int v) { this.camelCaseColon = v; }

            @JsonProperty("PascalCase:Colon") public int getPascalCaseColon() { return pascalCaseColon; }
            public void setPascalCaseColon(int v) { this.pascalCaseColon = v; }

            @JsonProperty("SCREAMINGCASE:COLON") public int getScreamingcaseColon() { return screamingcaseColon; }
            public void setScreamingcaseColon(int v) { this.screamingcaseColon = v; }

            @JsonProperty("SCREAMING_SNAKE:COLON") public int getScreamingSnakeColon() { return screamingSnakeColon; }
            public void setScreamingSnakeColon(int v) { this.screamingSnakeColon = v; }

            @JsonProperty("kebab-case:colon") public int getKebabCaseColon() { return kebabCaseColon; }
            public void setKebabCaseColon(int v) { this.kebabCaseColon = v; }

            @JsonProperty("Pascal_Snake:Colon") public int getPascalSnakeColon() { return pascalSnakeColon; }
            public void setPascalSnakeColon(int v) { this.pascalSnakeColon = v; }

            @JsonProperty("colon:object") public ColonObject getColonObject() { return colonObject; }
            public void setColonObject(ColonObject v) { this.colonObject = v; }

            @JsonProperty("snake.dot") public int getSnakeDot() { return snakeDot; }
            public void setSnakeDot(int v) { this.snakeDot = v; }

            @JsonProperty("snake@at") public int getSnakeAt() { return snakeAt; }
            public void setSnakeAt(int v) { this.snakeAt = v; }

            @JsonProperty("snake#hash") public int getSnakeHash() { return snakeHash; }
            public void setSnakeHash(int v) { this.snakeHash = v; }

            @JsonProperty("snake$dollar") public int getSnakeDollar() { return snakeDollar; }
            public void setSnakeDollar(int v) { this.snakeDollar = v; }

            @JsonProperty("snake%percentage") public int getSnakePercentage() { return snakePercentage; }
            public void setSnakePercentage(int v) { this.snakePercentage = v; }

            @JsonProperty("snake&ampersand") public int getSnakeAmpersand() { return snakeAmpersand; }
            public void setSnakeAmpersand(int v) { this.snakeAmpersand = v; }

            @JsonProperty("snake*asterisk") public int getSnakeAsterisk() { return snakeAsterisk; }
            public void setSnakeAsterisk(int v) { this.snakeAsterisk = v; }
        }

        public final class ColonObject {
            private int normalProp;
            private int nestedColon;

            @JsonProperty("normal_prop") public int getNormalProp() { return normalProp; }
            public void setNormalProp(int v) { this.normalProp = v; }

            @JsonProperty("nested:colon") public int getNestedColon() { return nestedColon; }
            public void setNestedColon(int v) { this.nestedColon = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        public final class WeirdNameTypes {
            private int snakeCase;
            private int camelCase;
            private int pascalCase;
            private int screamingcase;
            private int screamingSnake;
            private int kebabCase;
            private int pascalSnake;
            private int snakeCaseColon;
            private int camelCaseColon;
            private int pascalCaseColon;
            private int screamingcaseColon;
            private int screamingSnakeColon;
            private int kebabCaseColon;
            private int pascalSnakeColon;
            private ColonObject colonObject;
            private int snakeDot;
            private int snakeAt;
            private int snakeHash;
            private int snakeDollar;
            private int snakePercentage;
            private int snakeAmpersand;
            private int snakeAsterisk;

            public int getSnakeCase() { return snakeCase; }
            public void setSnakeCase(int v) { this.snakeCase = v; }

            public int getCamelCase() { return camelCase; }
            public void setCamelCase(int v) { this.camelCase = v; }

            public int getPascalCase() { return pascalCase; }
            public void setPascalCase(int v) { this.pascalCase = v; }

            public int getScreamingcase() { return screamingcase; }
            public void setScreamingcase(int v) { this.screamingcase = v; }

            public int getScreamingSnake() { return screamingSnake; }
            public void setScreamingSnake(int v) { this.screamingSnake = v; }

            public int getKebabCase() { return kebabCase; }
            public void setKebabCase(int v) { this.kebabCase = v; }

            public int getPascalSnake() { return pascalSnake; }
            public void setPascalSnake(int v) { this.pascalSnake = v; }

            public int getSnakeCaseColon() { return snakeCaseColon; }
            public void setSnakeCaseColon(int v) { this.snakeCaseColon = v; }

            public int getCamelCaseColon() { return camelCaseColon; }
            public void setCamelCaseColon(int v) { this.camelCaseColon = v; }

            public int getPascalCaseColon() { return pascalCaseColon; }
            public void setPascalCaseColon(int v) { this.pascalCaseColon = v; }

            public int getScreamingcaseColon() { return screamingcaseColon; }
            public void setScreamingcaseColon(int v) { this.screamingcaseColon = v; }

            public int getScreamingSnakeColon() { return screamingSnakeColon; }
            public void setScreamingSnakeColon(int v) { this.screamingSnakeColon = v; }

            public int getKebabCaseColon() { return kebabCaseColon; }
            public void setKebabCaseColon(int v) { this.kebabCaseColon = v; }

            public int getPascalSnakeColon() { return pascalSnakeColon; }
            public void setPascalSnakeColon(int v) { this.pascalSnakeColon = v; }

            public ColonObject getColonObject() { return colonObject; }
            public void setColonObject(ColonObject v) { this.colonObject = v; }

            public int getSnakeDot() { return snakeDot; }
            public void setSnakeDot(int v) { this.snakeDot = v; }

            public int getSnakeAt() { return snakeAt; }
            public void setSnakeAt(int v) { this.snakeAt = v; }

            public int getSnakeHash() { return snakeHash; }
            public void setSnakeHash(int v) { this.snakeHash = v; }

            public int getSnakeDollar() { return snakeDollar; }
            public void setSnakeDollar(int v) { this.snakeDollar = v; }

            public int getSnakePercentage() { return snakePercentage; }
            public void setSnakePercentage(int v) { this.snakePercentage = v; }

            public int getSnakeAmpersand() { return snakeAmpersand; }
            public void setSnakeAmpersand(int v) { this.snakeAmpersand = v; }

            public int getSnakeAsterisk() { return snakeAsterisk; }
            public void setSnakeAsterisk(int v) { this.snakeAsterisk = v; }
        }

        public final class ColonObject {
            private int normalProp;
            private int nestedColon;

            public int getNormalProp() { return normalProp; }
            public void setNormalProp(int v) { this.normalProp = v; }

            public int getNestedColon() { return nestedColon; }
            public void setNestedColon(int v) { this.nestedColon = v; }
        }
        """;

    // C# readonly struct → Java final immutable class (ctor + getters)
    public const string StructOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;

        public final class WeirdNameTypes {
            private final int snakeCase;
            private final int camelCase;
            private final int pascalCase;
            private final int screamingcase;
            private final int screamingSnake;
            private final int kebabCase;
            private final int pascalSnake;
            private final int snakeCaseColon;
            private final int camelCaseColon;
            private final int pascalCaseColon;
            private final int screamingcaseColon;
            private final int screamingSnakeColon;
            private final int kebabCaseColon;
            private final int pascalSnakeColon;
            private final ColonObject colonObject;
            private final int snakeDot;
            private final int snakeAt;
            private final int snakeHash;
            private final int snakeDollar;
            private final int snakePercentage;
            private final int snakeAmpersand;
            private final int snakeAsterisk;

            public WeirdNameTypes(
                @JsonProperty("snake_case") int snakeCase,
                @JsonProperty("camelCase") int camelCase,
                @JsonProperty("PascalCase") int pascalCase,
                @JsonProperty("SCREAMINGCASE") int screamingcase,
                @JsonProperty("SCREAMING_SNAKE") int screamingSnake,
                @JsonProperty("kebab-case") int kebabCase,
                @JsonProperty("Pascal_Snake") int pascalSnake,
                @JsonProperty("snake_case:colon") int snakeCaseColon,
                @JsonProperty("camelCase:colon") int camelCaseColon,
                @JsonProperty("PascalCase:Colon") int pascalCaseColon,
                @JsonProperty("SCREAMINGCASE:COLON") int screamingcaseColon,
                @JsonProperty("SCREAMING_SNAKE:COLON") int screamingSnakeColon,
                @JsonProperty("kebab-case:colon") int kebabCaseColon,
                @JsonProperty("Pascal_Snake:Colon") int pascalSnakeColon,
                @JsonProperty("colon:object") ColonObject colonObject,
                @JsonProperty("snake.dot") int snakeDot,
                @JsonProperty("snake@at") int snakeAt,
                @JsonProperty("snake#hash") int snakeHash,
                @JsonProperty("snake$dollar") int snakeDollar,
                @JsonProperty("snake%percentage") int snakePercentage,
                @JsonProperty("snake&ampersand") int snakeAmpersand,
                @JsonProperty("snake*asterisk") int snakeAsterisk
            ) {
                this.snakeCase = snakeCase;
                this.camelCase = camelCase;
                this.pascalCase = pascalCase;
                this.screamingcase = screamingcase;
                this.screamingSnake = screamingSnake;
                this.kebabCase = kebabCase;
                this.pascalSnake = pascalSnake;
                this.snakeCaseColon = snakeCaseColon;
                this.camelCaseColon = camelCaseColon;
                this.pascalCaseColon = pascalCaseColon;
                this.screamingcaseColon = screamingcaseColon;
                this.screamingSnakeColon = screamingSnakeColon;
                this.kebabCaseColon = kebabCaseColon;
                this.pascalSnakeColon = pascalSnakeColon;
                this.colonObject = colonObject;
                this.snakeDot = snakeDot;
                this.snakeAt = snakeAt;
                this.snakeHash = snakeHash;
                this.snakeDollar = snakeDollar;
                this.snakePercentage = snakePercentage;
                this.snakeAmpersand = snakeAmpersand;
                this.snakeAsterisk = snakeAsterisk;
            }

            @JsonProperty("snake_case") public int getSnakeCase() { return snakeCase; }
            @JsonProperty("camelCase") public int getCamelCase() { return camelCase; }
            @JsonProperty("PascalCase") public int getPascalCase() { return pascalCase; }
            @JsonProperty("SCREAMINGCASE") public int getScreamingcase() { return screamingcase; }
            @JsonProperty("SCREAMING_SNAKE") public int getScreamingSnake() { return screamingSnake; }
            @JsonProperty("kebab-case") public int getKebabCase() { return kebabCase; }
            @JsonProperty("Pascal_Snake") public int getPascalSnake() { return pascalSnake; }
            @JsonProperty("snake_case:colon") public int getSnakeCaseColon() { return snakeCaseColon; }
            @JsonProperty("camelCase:colon") public int getCamelCaseColon() { return camelCaseColon; }
            @JsonProperty("PascalCase:Colon") public int getPascalCaseColon() { return pascalCaseColon; }
            @JsonProperty("SCREAMINGCASE:COLON") public int getScreamingcaseColon() { return screamingcaseColon; }
            @JsonProperty("SCREAMING_SNAKE:COLON") public int getScreamingSnakeColon() { return screamingSnakeColon; }
            @JsonProperty("kebab-case:colon") public int getKebabCaseColon() { return kebabCaseColon; }
            @JsonProperty("Pascal_Snake:Colon") public int getPascalSnakeColon() { return pascalSnakeColon; }
            @JsonProperty("colon:object") public ColonObject getColonObject() { return colonObject; }
            @JsonProperty("snake.dot") public int getSnakeDot() { return snakeDot; }
            @JsonProperty("snake@at") public int getSnakeAt() { return snakeAt; }
            @JsonProperty("snake#hash") public int getSnakeHash() { return snakeHash; }
            @JsonProperty("snake$dollar") public int getSnakeDollar() { return snakeDollar; }
            @JsonProperty("snake%percentage") public int getSnakePercentage() { return snakePercentage; }
            @JsonProperty("snake&ampersand") public int getSnakeAmpersand() { return snakeAmpersand; }
            @JsonProperty("snake*asterisk") public int getSnakeAsterisk() { return snakeAsterisk; }
        }

        public final class ColonObject {
            private final int normalProp;
            private final int nestedColon;

            public ColonObject(
                @JsonProperty("normal_prop") int normalProp,
                @JsonProperty("nested:colon") int nestedColon
            ) {
                this.normalProp = normalProp;
                this.nestedColon = nestedColon;
            }

            @JsonProperty("normal_prop") public int getNormalProp() { return normalProp; }
            @JsonProperty("nested:colon") public int getNestedColon() { return nestedColon; }
        }
        """;
}
