// Script which can be run after HTTP requests
client.test("Successful request with OK 201", () => {
    client.assert(response.status === 201, "HTTP Response status code is not 201");
});

client.test("Response content-type is json", () => {
    var contentType = response.contentType.mimeType;
    client.assert(contentType === "application/json", "Expected content-type 'application/json' but received '" + contentType + "'");
});
