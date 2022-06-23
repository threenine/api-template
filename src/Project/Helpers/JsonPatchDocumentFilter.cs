using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Kingsbridge.Helpers;

public class JsonPatchDocumentFilter : IDocumentFilter
{
    private const string JsonPatchDocument = "JsonPatchDocument";
    private const string JsonPatchApplication = "application/json-patch+json";
    private const string Operation = "Operation";

    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        var schemas = swaggerDoc.Components.Schemas.ToList();
        foreach (var item in schemas)
            if (item.Key.StartsWith(Operation) || item.Key.StartsWith(JsonPatchDocument))
                swaggerDoc.Components.Schemas.Remove(item.Key);

        swaggerDoc.Components.Schemas.Add(Operation, new OpenApiSchema
        {
            Type = "object",
            Properties = new Dictionary<string, OpenApiSchema>
            {
                { "op", new OpenApiSchema { Type = "string" } },
                { "value", new OpenApiSchema { Type = "string" } },
                { "path", new OpenApiSchema { Type = "string" } }
            }
        });

        swaggerDoc.Components.Schemas.Add(JsonPatchDocument, new OpenApiSchema
        {
            Type = nameof(Array).ToLower(),
            Items = new OpenApiSchema
            {
                Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = Operation }
            },
            Description = "Array of operations to perform"
        });


        foreach (var path in swaggerDoc.Paths.SelectMany(p => p.Value.Operations)
                     .Where(p => p.Key == OperationType.Patch))
        {
            // Any PATCH operation that needs to be excluded from assigning JsonPatchDocument contract resolver
            // include the operation ID here
            if (path.Value.OperationId.Contains("0c77c6c0-7689-44dc-aafd-a354c4336086")) continue;

            foreach (var item in path.Value.RequestBody.Content.Where(c => c.Key != JsonPatchApplication))
                path.Value.RequestBody.Content.Remove(item.Key);

            var response = path.Value.RequestBody.Content.SingleOrDefault(c => c.Key == JsonPatchApplication);

            response.Value.Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = JsonPatchDocument }
            };
        }
    }
}