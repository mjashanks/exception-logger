open fszmq
open fszmq.Socket
open System.Threading
open System.Text
open ServiceStack.Text
open MessageHandling

[<EntryPoint>]
let main argv =
  // socket to talk to clients
  use context = new Context ()
  use responder = Context.pull context
  Socket.bind responder "tcp://*:5555"

  while true do
    // wait for next request from client
    let _buffer = Socket.recv responder
    let messageJson = Encoding.UTF8.GetString(_buffer)

    // do some work
    Thread.Sleep 1000 // msecs

    // send reply back to client
    Socket.send responder "World"B

  0 // return code
