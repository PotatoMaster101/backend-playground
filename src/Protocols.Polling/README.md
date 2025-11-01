# Polling (Short Polling)
1. Client sends a long-running request (like upload a video).
2. Server sends back a response containing a handle immediately.
3. Server processes the request.
4. Client can check for status using the handle.
5. Server responds with the status immediately.

## Pros
- Real-time updates.
- Good for long-running tasks (like uploading a video).
- Clients can disconnect after getting the handle, save the handle and check for status once online.

## Cons
- Clients are noisy, too many status checks can increase server load.
- Needs higher network bandwidth which can lead to higher cloud costs.
