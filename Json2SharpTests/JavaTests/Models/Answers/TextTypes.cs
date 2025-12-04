namespace Json2SharpTests.JavaTests.Models.Answers;

internal static class TextTypes
{
    public const string Input = """
        {
            "text": "hello world",
            "empty_text": "",
            "timespan": "00:00:01",
            "timespans": ["00:00:01"],
            "nullable_timespans": ["00:00:01", null],
            "date_time_offset": "2024-05-19T01:23:10.000Z",
            "date_time_offset_array": ["2024-05-19T01:23:10.000Z"],
            "date_time_offset_nullable_array": ["2024-05-19T01:23:10.000Z", null],
            "id": "6c33ac26-953b-46bf-8a5d-a34e1b99e5df",
            "ids": ["6c33ac26-953b-46bf-8a5d-a34e1b99e5df"],
            "nullable_ids": ["6c33ac26-953b-46bf-8a5d-a34e1b99e5df", null]
        }
        """;

    // Newtonsoft record → Java record with @JsonProperty
    public const string RecordPrimaryCtorOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public record TextTypes(
            @JsonProperty("text") String text,
            @JsonProperty("empty_text") String emptyText,
            @JsonProperty("timespan") LocalTime timespan,
            @JsonProperty("timespans") LocalTime[] timespans,
            @JsonProperty("nullable_timespans") LocalTime[] nullableTimespans,
            @JsonProperty("date_time_offset") OffsetDateTime dateTimeOffset,
            @JsonProperty("date_time_offset_array") OffsetDateTime[] dateTimeOffsetArray,
            @JsonProperty("date_time_offset_nullable_array") OffsetDateTime[] dateTimeOffsetNullableArray,
            @JsonProperty("id") UUID id,
            @JsonProperty("ids") UUID[] ids,
            @JsonProperty("nullable_ids") UUID[] nullableIds
        ) { }
        """;

    // No-annotation record
    public const string RecordPrimaryCtorOutputNoAtt = """
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public record TextTypes(
            String text,
            String emptyText,
            LocalTime timespan,
            LocalTime[] timespans,
            LocalTime[] nullableTimespans,
            OffsetDateTime dateTimeOffset,
            OffsetDateTime[] dateTimeOffsetArray,
            OffsetDateTime[] dateTimeOffsetNullableArray,
            UUID id,
            UUID[] ids,
            UUID[] nullableIds
        ) { }
        """;

    // STJ record → Jackson record with same annotations
    public const string RecordOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public record TextTypes(
            @JsonProperty("text") String text,
            @JsonProperty("empty_text") String emptyText,
            @JsonProperty("timespan") LocalTime timespan,
            @JsonProperty("timespans") LocalTime[] timespans,
            @JsonProperty("nullable_timespans") LocalTime[] nullableTimespans,
            @JsonProperty("date_time_offset") OffsetDateTime dateTimeOffset,
            @JsonProperty("date_time_offset_array") OffsetDateTime[] dateTimeOffsetArray,
            @JsonProperty("date_time_offset_nullable_array") OffsetDateTime[] dateTimeOffsetNullableArray,
            @JsonProperty("id") UUID id,
            @JsonProperty("ids") UUID[] ids,
            @JsonProperty("nullable_ids") UUID[] nullableIds
        ) { }
        """;

    // STJ class → Jackson class with annotated getters
    public const string ClassOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public final class TextTypes {
            private String text;
            private String emptyText;
            private LocalTime timespan;
            private LocalTime[] timespans;
            private LocalTime[] nullableTimespans;
            private OffsetDateTime dateTimeOffset;
            private OffsetDateTime[] dateTimeOffsetArray;
            private OffsetDateTime[] dateTimeOffsetNullableArray;
            private UUID id;
            private UUID[] ids;
            private UUID[] nullableIds;

            @JsonProperty("text") public String getText() { return text; }
            public void setText(String v) { this.text = v; }

            @JsonProperty("empty_text") public String getEmptyText() { return emptyText; }
            public void setEmptyText(String v) { this.emptyText = v; }

            @JsonProperty("timespan") public LocalTime getTimespan() { return timespan; }
            public void setTimespan(LocalTime v) { this.timespan = v; }

            @JsonProperty("timespans") public LocalTime[] getTimespans() { return timespans; }
            public void setTimespans(LocalTime[] v) { this.timespans = v; }

            @JsonProperty("nullable_timespans") public LocalTime[] getNullableTimespans() { return nullableTimespans; }
            public void setNullableTimespans(LocalTime[] v) { this.nullableTimespans = v; }

            @JsonProperty("date_time_offset") public OffsetDateTime getDateTimeOffset() { return dateTimeOffset; }
            public void setDateTimeOffset(OffsetDateTime v) { this.dateTimeOffset = v; }

            @JsonProperty("date_time_offset_array") public OffsetDateTime[] getDateTimeOffsetArray() { return dateTimeOffsetArray; }
            public void setDateTimeOffsetArray(OffsetDateTime[] v) { this.dateTimeOffsetArray = v; }

            @JsonProperty("date_time_offset_nullable_array") public OffsetDateTime[] getDateTimeOffsetNullableArray() { return dateTimeOffsetNullableArray; }
            public void setDateTimeOffsetNullableArray(OffsetDateTime[] v) { this.dateTimeOffsetNullableArray = v; }

            @JsonProperty("id") public UUID getId() { return id; }
            public void setId(UUID v) { this.id = v; }

            @JsonProperty("ids") public UUID[] getIds() { return ids; }
            public void setIds(UUID[] v) { this.ids = v; }

            @JsonProperty("nullable_ids") public UUID[] getNullableIds() { return nullableIds; }
            public void setNullableIds(UUID[] v) { this.nullableIds = v; }
        }
        """;

    // No-annotation class
    public const string ClassOutputNoAtt = """
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public final class TextTypes {
            private String text;
            private String emptyText;
            private LocalTime timespan;
            private LocalTime[] timespans;
            private LocalTime[] nullableTimespans;
            private OffsetDateTime dateTimeOffset;
            private OffsetDateTime[] dateTimeOffsetArray;
            private OffsetDateTime[] dateTimeOffsetNullableArray;
            private UUID id;
            private UUID[] ids;
            private UUID[] nullableIds;

            public String getText() { return text; }
            public void setText(String v) { this.text = v; }

            public String getEmptyText() { return emptyText; }
            public void setEmptyText(String v) { this.emptyText = v; }

            public LocalTime getTimespan() { return timespan; }
            public void setTimespan(LocalTime v) { this.timespan = v; }

            public LocalTime[] getTimespans() { return timespans; }
            public void setTimespans(LocalTime[] v) { this.timespans = v; }

            public LocalTime[] getNullableTimespans() { return nullableTimespans; }
            public void setNullableTimespans(LocalTime[] v) { this.nullableTimespans = v; }

            public OffsetDateTime getDateTimeOffset() { return dateTimeOffset; }
            public void setDateTimeOffset(OffsetDateTime v) { this.dateTimeOffset = v; }

            public OffsetDateTime[] getDateTimeOffsetArray() { return dateTimeOffsetArray; }
            public void setDateTimeOffsetArray(OffsetDateTime[] v) { this.dateTimeOffsetArray = v; }

            public OffsetDateTime[] getDateTimeOffsetNullableArray() { return dateTimeOffsetNullableArray; }
            public void setDateTimeOffsetNullableArray(OffsetDateTime[] v) { this.dateTimeOffsetNullableArray = v; }

            public UUID getId() { return id; }
            public void setId(UUID v) { this.id = v; }

            public UUID[] getIds() { return ids; }
            public void setIds(UUID[] v) { this.ids = v; }

            public UUID[] getNullableIds() { return nullableIds; }
            public void setNullableIds(UUID[] v) { this.nullableIds = v; }
        }
        """;

    // C# readonly struct → Java final immutable class (ctor + getters)
    public const string StructOutput = """
        import com.fasterxml.jackson.annotation.JsonProperty;
        import java.time.LocalTime;
        import java.time.OffsetDateTime;
        import java.util.UUID;

        public final class TextTypes {
            private final String text;
            private final String emptyText;
            private final LocalTime timespan;
            private final LocalTime[] timespans;
            private final LocalTime[] nullableTimespans;
            private final OffsetDateTime dateTimeOffset;
            private final OffsetDateTime[] dateTimeOffsetArray;
            private final OffsetDateTime[] dateTimeOffsetNullableArray;
            private final UUID id;
            private final UUID[] ids;
            private final UUID[] nullableIds;

            public TextTypes(
                @JsonProperty("text") String text,
                @JsonProperty("empty_text") String emptyText,
                @JsonProperty("timespan") LocalTime timespan,
                @JsonProperty("timespans") LocalTime[] timespans,
                @JsonProperty("nullable_timespans") LocalTime[] nullableTimespans,
                @JsonProperty("date_time_offset") OffsetDateTime dateTimeOffset,
                @JsonProperty("date_time_offset_array") OffsetDateTime[] dateTimeOffsetArray,
                @JsonProperty("date_time_offset_nullable_array") OffsetDateTime[] dateTimeOffsetNullableArray,
                @JsonProperty("id") UUID id,
                @JsonProperty("ids") UUID[] ids,
                @JsonProperty("nullable_ids") UUID[] nullableIds
            ) {
                this.text = text;
                this.emptyText = emptyText;
                this.timespan = timespan;
                this.timespans = timespans;
                this.nullableTimespans = nullableTimespans;
                this.dateTimeOffset = dateTimeOffset;
                this.dateTimeOffsetArray = dateTimeOffsetArray;
                this.dateTimeOffsetNullableArray = dateTimeOffsetNullableArray;
                this.id = id;
                this.ids = ids;
                this.nullableIds = nullableIds;
            }

            @JsonProperty("text") public String getText() { return text; }
            @JsonProperty("empty_text") public String getEmptyText() { return emptyText; }
            @JsonProperty("timespan") public LocalTime getTimespan() { return timespan; }
            @JsonProperty("timespans") public LocalTime[] getTimespans() { return timespans; }
            @JsonProperty("nullable_timespans") public LocalTime[] getNullableTimespans() { return nullableTimespans; }
            @JsonProperty("date_time_offset") public OffsetDateTime getDateTimeOffset() { return dateTimeOffset; }
            @JsonProperty("date_time_offset_array") public OffsetDateTime[] getDateTimeOffsetArray() { return dateTimeOffsetArray; }
            @JsonProperty("date_time_offset_nullable_array") public OffsetDateTime[] getDateTimeOffsetNullableArray() { return dateTimeOffsetNullableArray; }
            @JsonProperty("id") public UUID getId() { return id; }
            @JsonProperty("ids") public UUID[] getIds() { return ids; }
            @JsonProperty("nullable_ids") public UUID[] getNullableIds() { return nullableIds; }
        }
        """;
}
