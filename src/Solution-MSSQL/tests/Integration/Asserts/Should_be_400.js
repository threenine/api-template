// Script which can be run after HTTP requests
client.test("Bad Request error 400", () => {
    client.assert(response.status === 400, "HTTP Response status code is not 400, received '" + response.status + "'");
});
