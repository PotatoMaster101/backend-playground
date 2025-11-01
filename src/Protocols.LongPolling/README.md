# Long Polling
1. Client sends a long-running request (like upload a video).
2. Server sends back a response containing a handle immediately.
3. Server processes the request.
4. Client can check for status using the handle.
5. Server does not respond until a response is ready.
6. Client will keep waiting until the server responds, usually with a timeout.

## Pros
- Good for long-running tasks (like uploading a video).
- Clients can disconnect after getting the handle, save the handle and check for status once online.
- Clients are not noisy because they will be waiting for a response when checking for status.

## Cons
- Not truly real-time, if the client times out before new data is available, the client will need to send another request which creates small gaps between updates.
