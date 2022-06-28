// Script which can be run after HTTP requests
client.test("Successful request with Not Found 404", () => {
    client.assert(response.status === 404, "HTTP Response status code is not 404");
});
