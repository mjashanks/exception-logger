namespace ExLog.Client

open fszmq
open fszmq.Socket
open System.Text
open Newtonsoft.Json

type ExceptionLog={
    name : string;
    message : string;
}

module Sender=
    let Send ex=
      use context = new Context ()
      use sender = Context.push context
      Socket.bind sender "tcp://*:5555"

      JsonConvert.SerializeObject(ex) 
      |> UTF8Encoding.UTF8.GetBytes
      |> Socket.send sender
      ()



