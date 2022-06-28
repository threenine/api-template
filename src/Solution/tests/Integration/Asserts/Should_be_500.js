// Script which can be run after HTTP requests
client.test("Bad Request error 500", () => {
    client.assert(response.status === 500, "HTTP Response status code is not 500, received '" + response.status + "'");
});
