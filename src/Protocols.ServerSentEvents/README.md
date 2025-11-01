# Server Sent Events (SSE)
1. Client sends a request to the server.
2. Server sends a never-ending response (a stream of data) to the client.
3. Client receives and parses the chunks of data.

## Pros
- Real-time updates.
- Client receives new data from the server without requesting anything, reducing server load.

## Cons
- Needs beefy clients to handle very frequent data from the server.
- Clients must be online to receive new data.
- Most browsers implement 6-connections rule per host for HTTP/1.1. 
