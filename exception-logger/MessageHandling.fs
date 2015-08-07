namespace MessageHandling

open ExLog.Messages
open Newtonsoft.Json
open ExLog.Handlers

module Handling=

    let DeserializeJson msgJson : Message=
        JsonConvert.DeserializeObject<Message>(msgJson)
    
    let Handle msgJson=
        let msg = msgJson |> DeserializeJson
        match msg with
        | ExceptionLog el -> ErrBit el
        | Text str -> Text str