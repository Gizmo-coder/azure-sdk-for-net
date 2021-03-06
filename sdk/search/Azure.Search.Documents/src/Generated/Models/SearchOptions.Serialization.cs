// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    public partial class SearchOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IncludeTotalCount != null)
            {
                writer.WritePropertyName("count");
                writer.WriteBooleanValue(IncludeTotalCount.Value);
            }
            if (Facets != null)
            {
                writer.WritePropertyName("facets");
                writer.WriteStartArray();
                foreach (var item in Facets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (HighlightFieldsRaw != null)
            {
                writer.WritePropertyName("highlight");
                writer.WriteStringValue(HighlightFieldsRaw);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (OrderByRaw != null)
            {
                writer.WritePropertyName("orderby");
                writer.WriteStringValue(OrderByRaw);
            }
            if (QueryType != null)
            {
                writer.WritePropertyName("queryType");
                writer.WriteStringValue(QueryType.Value.ToSerialString());
            }
            if (ScoringParameters != null)
            {
                writer.WritePropertyName("scoringParameters");
                writer.WriteStartArray();
                foreach (var item in ScoringParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ScoringProfile != null)
            {
                writer.WritePropertyName("scoringProfile");
                writer.WriteStringValue(ScoringProfile);
            }
            if (SearchText != null)
            {
                writer.WritePropertyName("search");
                writer.WriteStringValue(SearchText);
            }
            if (SearchFieldsRaw != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFieldsRaw);
            }
            if (SearchMode != null)
            {
                writer.WritePropertyName("searchMode");
                writer.WriteStringValue(SearchMode.Value.ToSerialString());
            }
            if (SelectRaw != null)
            {
                writer.WritePropertyName("select");
                writer.WriteStringValue(SelectRaw);
            }
            if (Skip != null)
            {
                writer.WritePropertyName("skip");
                writer.WriteNumberValue(Skip.Value);
            }
            if (Size != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Size.Value);
            }
            writer.WriteEndObject();
        }

        internal static SearchOptions DeserializeSearchOptions(JsonElement element)
        {
            bool? count = default;
            IList<string> facets = default;
            string filter = default;
            string highlight = default;
            string highlightPostTag = default;
            string highlightPreTag = default;
            double? minimumCoverage = default;
            string orderby = default;
            SearchQueryType? queryType = default;
            IList<string> scoringParameters = default;
            string scoringProfile = default;
            string search = default;
            string searchFields = default;
            SearchMode? searchMode = default;
            string select = default;
            int? skip = default;
            int? top = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    facets = array;
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highlight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("orderby"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orderby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = property.Value.GetString().ToSearchQueryType();
                    continue;
                }
                if (property.NameEquals("scoringParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    scoringParameters = array;
                    continue;
                }
                if (property.NameEquals("scoringProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("search"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    search = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchMode = property.Value.GetString().ToSearchMode();
                    continue;
                }
                if (property.NameEquals("select"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    select = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
            }
            return new SearchOptions(count, facets, filter, highlight, highlightPostTag, highlightPreTag, minimumCoverage, orderby, queryType, scoringParameters, scoringProfile, search, searchFields, searchMode, select, skip, top);
        }
    }
}
