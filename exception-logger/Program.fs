namespace ExLog

open fszmq
open fszmq.Socket
open System.Threading
open System.Text
open MessageHandling.Handling

module start=

    [<EntryPoint>]
    let main argv =
      // socket to talk to clients
      use context = new Context ()
      use responder = Context.pull context
      Socket.bind responder "tcp://*:5555"

      printfn "listenting on tcp://*:5555"

      while true do
        let _buffer = Socket.recv responder
        let messageJson = Encoding.UTF8.GetString(_buffer)
        Handle messageJson
      0