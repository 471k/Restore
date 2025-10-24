using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.RequestHelpers;
using Microsoft.Net.Http.Headers;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(
            this HttpResponse response,
            PaginationMetaData metaData)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

            response.Headers.Append("Pagination", JsonSerializer.Serialize(metaData, options));

            response.Headers.Append(HeaderNames.AccessControlExposeHeaders, "Pagination");
        }
    }
}