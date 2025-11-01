# Push
1. Client and server establish a connection.
2. Server sends notifications to clients periodically (like when new user login, new chat message etc.).
3. Client doesn't need to request anything.

## Pros
- Real-time updates.
- Client receives new data from the server without requesting anything, reducing server load.

## Cons
- Needs beefy clients to handle very frequent pushes from the server.
- Clients must be online to receive pushes.
