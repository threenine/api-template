// Script which can be run after HTTP requests
client.test("Unsuccessful request with Conflict Exception 409", () => {
    client.assert(response.status === 409, "HTTP Response status code is not 409");
});
